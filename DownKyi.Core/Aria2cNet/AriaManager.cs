using DownKyi.Core.Aria2cNet.Client;

namespace DownKyi.Core.Aria2cNet;

public class AriaManager
{
    // 下载结果回调
    public delegate void DownloadFinishHandler(bool isSuccess, string? downloadPath, string gid, string? msg = null);

    // 全局下载状态
    public delegate void GetGlobalStatusHandler(long speed);

    // gid对应项目的状态
    public delegate void TellStatusHandler(long totalLength, long completedLength, long speed, string gid);

    public event TellStatusHandler? TellStatus;

    protected virtual void OnTellStatus(long totalLength, long completedLength, long speed, string gid)
    {
        TellStatus?.Invoke(totalLength, completedLength, speed, gid);
    }

    public event DownloadFinishHandler? DownloadFinish;

    protected virtual void OnDownloadFinish(bool isSuccess, string? downloadPath, string gid, string? msg = null)
    {
        DownloadFinish?.Invoke(isSuccess, downloadPath, gid, msg);
    }

    public event GetGlobalStatusHandler? GlobalStatus;

    protected virtual void OnGlobalStatus(long speed)
    {
        GlobalStatus?.Invoke(speed);
    }

    /// <summary>
    ///     获取gid下载项的状态
    ///     TODO
    ///     对于下载的不同状态的返回值的测试
    /// </summary>
    /// <param name="gid"></param>
    /// <param name="action"></param>
    /// <returns></returns>
    public async Task<DownloadResult> GetDownloadStatus(string gid, Action? action = null)
    {
        var filePath = "";
        while (true)
        {
            var status = await AriaClient.TellStatus(gid);
            if (status.Error != null)
            {
                if (status.Error.Message.Contains("is not found"))
                {
                    OnDownloadFinish(false, null, gid, status.Error.Message);
                    return DownloadResult.Abort;
                }
            }

            if (status.Result.Files is { Count: >= 1 })
            {
                filePath = status.Result.Files[0].Path;
            }

            // 回调
            OnTellStatus(
                long.Parse(status.Result.TotalLength), 
                long.Parse(status.Result.CompletedLength), 
                long.Parse(status.Result.DownloadSpeed), 
                gid);

            // 在外部执行
            action?.Invoke();

            if (status.Result.Status == "complete")
            {
                break;
            }

            if (status.Result.ErrorCode != null && status.Result.ErrorCode != "0")
            {
                Console.Error.WriteLine("ErrorMessage: " + status.Result.ErrorMessage);

                //// 如果返回状态码不是200，则继续
                //if (status.Result.Result.ErrorMessage.Contains("The response status is not successful"))
                //{
                //    Thread.Sleep(1000);
                //    continue;
                //}

                // aira中删除记录
                var ariaRemove1 = AriaClient.RemoveDownloadResultAsync(gid);
                Console.Error.WriteLine(ariaRemove1);

                // 返回回调信息，退出函数
                OnDownloadFinish(false, null, gid, status.Result.ErrorMessage);
                return DownloadResult.Failed;
            }

            // 降低CPU占用
            Thread.Sleep(100);
        }

        OnDownloadFinish(true, filePath, gid);
        return DownloadResult.Success;
    }

    /// <summary>
    ///     获取全局下载速度
    /// </summary>
    public async void GetGlobalStatus()
    {
        while (true)
        {
            // 查询全局status
            var globalStatus = await AriaClient.GetGlobalStatAsync();
            if (globalStatus == null || globalStatus.Result == null)
            {
                continue;
            }

            var globalSpeed = long.Parse(globalStatus.Result.DownloadSpeed);
            // 回调
            OnGlobalStatus(globalSpeed);

            // 降低CPU占用
            Thread.Sleep(100);
        }
    }
}