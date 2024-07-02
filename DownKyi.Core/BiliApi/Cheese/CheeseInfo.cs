using DownKyi.Core.BiliApi.Cheese.Models;

namespace DownKyi.Core.BiliApi.Cheese;

public static class CheeseInfo
{
    /// <summary>
    ///     获取课程基本信息
    /// </summary>
    /// <param name="seasonId"></param>
    /// <param name="episodeId"></param>
    /// <returns></returns>
    public async static Task<CheeseView> CheeseViewInfo(long seasonId = -1, long episodeId = -1)
    {
        var baseUrl = "https://api.bilibili.com/pugv/view/web/season";
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
            throw new Exception("CheeseViewInfo()参数错误");
        }
        
        var cheese = await WebClient.RequestWebAsync<CheeseViewOrigin>(url, referer);
        return cheese.Data;
    }

    /// <summary>
    ///     获取课程分集列表
    /// </summary>
    /// <param name="seasonId"></param>
    /// <param name="ps"></param>
    /// <param name="pn"></param>
    /// <returns></returns>
    public async static Task<CheeseEpisodeList> CheeseEpisodeList(long seasonId, int ps = 50, int pn = 1)
    {
        var url = $"https://api.bilibili.com/pugv/view/web/ep/list?season_id={seasonId}&pn={pn}&ps={ps}";
        const string referer = "https://www.bilibili.com";
        var cheese = await WebClient.RequestWebAsync<CheeseEpisodeListOrigin>(url, referer);
        return cheese.Data;
    }
}