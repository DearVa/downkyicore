using DownKyi.Core.BiliApi.Bangumi.Models;

namespace DownKyi.Core.BiliApi.Bangumi;

public static class BangumiInfo
{
    /// <summary>
    ///     剧集基本信息（mediaId方式）
    /// </summary>
    /// <param name="mediaId"></param>
    /// <returns></returns>
    public async static Task<BangumiMedia> BangumiMediaInfo(long mediaId)
    {
        var url = $"https://api.bilibili.com/pgc/review/user?media_id={mediaId}";
        const string referer = "https://www.bilibili.com";
        var media = await WebClient.RequestWebAsync<BangumiMediaOrigin>(url, referer);
        return media.Result.Media;
    }

    /// <summary>
    ///     获取剧集明细（web端）（seasonId/episodeId方式）
    /// </summary>
    /// <param name="seasonId"></param>
    /// <param name="episodeId"></param>
    /// <returns></returns>
    public async static Task<BangumiSeason> BangumiSeasonInfo(long seasonId = -1, long episodeId = -1)
    {
        const string baseUrl = "https://api.bilibili.com/pgc/view/web/season";
        const string referer = "https://www.bilibili.com";
        string url;
        if (seasonId > -1)
        {
            url = $"{baseUrl}?season_id={seasonId}";
        }
        else if (episodeId > -1)
        {
            url = $"{baseUrl}?ep_id={episodeId}";
        }
        else
        {
            throw new ArgumentException("seasonId和episodeId不能同时为空");
        }

        var bangumiSeason = await WebClient.RequestWebAsync<BangumiSeasonOrigin>(url, referer);
        return bangumiSeason.Result;
    }
}