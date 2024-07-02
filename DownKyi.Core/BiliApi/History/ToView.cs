using DownKyi.Core.BiliApi.History.Models;

namespace DownKyi.Core.BiliApi.History;

/// <summary>
///     稍后再看
/// </summary>
public static class ToView
{
    /// <summary>
    ///     获取稍后再看视频列表
    /// </summary>
    /// <returns></returns>
    public async static Task<List<ToViewList>?> GetToView()
    {
        var url = "https://api.bilibili.com/x/v2/history/toview";
        const string referer = "https://www.bilibili.com";


        var toView = await WebClient.RequestWebAsync<ToViewOrigin>(url, referer);
        return toView.Data.List;

    }
}