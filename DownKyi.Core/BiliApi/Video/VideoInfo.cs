using DownKyi.Core.BiliApi.Sign;
using DownKyi.Core.BiliApi.Video.Models;

namespace DownKyi.Core.BiliApi.Video;

public static class VideoInfo
{
    /// <summary>
    ///     获取视频详细信息(web端)
    /// </summary>
    /// <param name="bvid"></param>
    /// <param name="aid"></param>
    /// <returns></returns>
    public async static Task<VideoView> VideoViewInfo(string? bvid = null, long aid = -1)
    {
        // https://api.bilibili.com/x/web-interface/view/detail?bvid=BV1Sg411F7cb&aid=969147110&need_operation_card=1&web_rm_repeat=1&need_elec=1&out_referer=https%3A%2F%2Fspace.bilibili.com%2F42018135%2Ffavlist%3Ffid%3D94341835

        var parameters = new Dictionary<string, object>();
        if (bvid != null)
        {
            parameters.Add("bvid", bvid);
        }
        else if (aid > -1)
        {
            parameters.Add("aid", aid);
        }
        else
        {
            throw new Exception("bvid和aid不能同时为空");
        }

        var query = WbiSign.ParametersToQuery(WbiSign.EncodeWbi(parameters));
        var url = $"https://api.bilibili.com/x/web-interface/wbi/view?{query}";
        const string referer = "https://www.bilibili.com";
        var videoView = await WebClient.RequestWebAsync<VideoViewOrigin>(url, referer);
        return videoView.Data;
    }

    /// <summary>
    ///     获取视频简介
    /// </summary>
    /// <param name="bvid"></param>
    /// <param name="aid"></param>
    /// <returns></returns>
    public async static Task<string> VideoDescription(string? bvid = null, long aid = -1)
    {
        const string baseUrl = "https://api.bilibili.com/x/web-interface/archive/desc";
        const string referer = "https://www.bilibili.com";
        string url;
        if (bvid != null) url = $"{baseUrl}?bvid={bvid}";
        else if (aid >= -1) url = $"{baseUrl}?aid={aid}";
        else throw new Exception("bvid和aid不能同时为空");
        var desc = await WebClient.RequestWebAsync<VideoDescription>(url, referer);
        return desc.Data;
    }

    /// <summary>
    ///     查询视频分P列表 (avid/bvid转cid)
    /// </summary>
    /// <param name="bvid"></param>
    /// <param name="aid"></param>
    /// <returns></returns>
    public async static Task<List<VideoPage>> VideoPageList(string? bvid = null, long aid = -1)
    {
        const string baseUrl = "https://api.bilibili.com/x/player/pagelist";
        const string referer = "https://www.bilibili.com";
        string url;
        if (bvid != null) url = $"{baseUrl}?bvid={bvid}";
        else if (aid > -1) url = $"{baseUrl}?aid={aid}";
        else throw new Exception("bvid和aid不能同时为空");
        var pagelist = await WebClient.RequestWebAsync<VideoPagelist>(url, referer);
        return pagelist.Data;
    }
}