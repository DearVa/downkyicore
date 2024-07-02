using DownKyi.Core.BiliApi.History.Models;

namespace DownKyi.Core.BiliApi.History;

/// <summary>
///     历史记录
/// </summary>
public static class History
{
    /// <summary>
    ///     获取历史记录列表（视频、直播、专栏）
    ///     startId和startTime必须同时使用才有效，分别对应结果中的max和view_at，默认为0
    /// </summary>
    /// <param name="startId">历史记录开始目标ID</param>
    /// <param name="startTime">历史记录开始时间</param>
    /// <param name="ps">每页项数</param>
    /// <param name="business">历史记录ID类型</param>
    /// <returns></returns>
    public async static Task<HistoryData?> GetHistory(long startId, long startTime, int ps = 30, HistoryBusiness business = HistoryBusiness.ARCHIVE)
    {
        var businessStr = string.Empty;
        switch (business)
        {
            case HistoryBusiness.ARCHIVE:
                businessStr = "archive";
                break;
            case HistoryBusiness.PGC:
                businessStr = "pgc";
                break;
            case HistoryBusiness.LIVE:
                businessStr = "live";
                break;
            case HistoryBusiness.ARTICLE_LIST:
                businessStr = "article-list";
                break;
            case HistoryBusiness.ARTICLE:
                businessStr = "article";
                break;
        }

        var url = $"https://api.bilibili.com/x/web-interface/history/cursor?max={startId}&view_at={startTime}&ps={ps}&business={businessStr}";
        const string referer = "https://www.bilibili.com";


        var history = await WebClient.RequestWebAsync<HistoryOrigin>(url, referer);
        return history.Data;

    }
}