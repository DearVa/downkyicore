namespace DownKyi.Core.Aria2cNet;

/// <summary>
///     下载状态
/// </summary>
public enum DownloadResult
{
    None,
    Success = 1,
    Failed,
    Abort,
}