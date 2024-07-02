using DownKyi.Core.BiliApi.Models.Json;
using DownKyi.Core.BiliApi.Sign;
using DownKyi.Core.BiliApi.VideoStream.Models;

namespace DownKyi.Core.BiliApi.VideoStream;

public static class VideoStream
{
    /// <summary>
    ///     获取播放器信息（web端）
    /// </summary>
    /// <param name="avid"></param>
    /// <param name="bvid"></param>
    /// <param name="cid"></param>
    /// <returns></returns>
    public async static Task<PlayerV2?> PlayerV2(long avid, string bvid, long cid)
    {
        var parameters = new Dictionary<string, object>
        {
            { "avid", avid },
            { "bvid", bvid },
            { "cid", cid },
        };
        var query = WbiSign.ParametersToQuery(WbiSign.EncodeWbi(parameters));
        var url = $"https://api.bilibili.com/x/player/wbi/v2?{query}";
        const string referer = "https://www.bilibili.com";

        var playUrl = await WebClient.RequestWebAsync<PlayerV2Origin>(url, referer);
        return playUrl.Data;
    }

    /// <summary>
    ///     获取所有字幕<br />
    ///     若视频没有字幕，返回null
    /// </summary>
    /// <param name="avid"></param>
    /// <param name="bvid"></param>
    /// <param name="cid"></param>
    /// <returns></returns>
    public async static Task<List<SubRipText>?> GetSubtitle(long avid, string bvid, long cid)
    {
        var subRipTexts = new List<SubRipText>();

        // 获取播放器信息
        var player = await PlayerV2(avid, bvid, cid);
        if (player == null)
        {
            return subRipTexts;
        }

        foreach (var subtitle in player.Subtitle.Subtitles)
        {
            const string referer = "https://www.bilibili.com";
            var subtitleJson = await WebClient.RequestWebAsync<SubtitleJson>($"https:{subtitle.SubtitleUrl}", referer);
            subRipTexts.Add(new SubRipText
            {
                Lan = subtitle.Lan,
                LanDoc = subtitle.LanDoc,
                SrtString = subtitleJson.ToSubRip(),
            });
        }

        return subRipTexts;
    }

    /// <summary>
    ///     获取普通视频的视频流
    /// </summary>
    /// <param name="avid"></param>
    /// <param name="bvid"></param>
    /// <param name="cid"></param>
    /// <param name="quality"></param>
    /// <returns></returns>
    public async static Task<PlayUrl> GetVideoPlayUrl(long avid, string? bvid, long cid, int quality = 125)
    {
        var parameters = new Dictionary<string, object>
        {
            { "fourk", 1 },
            { "fnver", 0 },
            { "fnval", 4048 },
            { "cid", cid },
            { "qn", quality },
        };

        if (bvid != null)
        {
            parameters.Add("bvid", bvid);
        }
        else if (avid > -1)
        {
            parameters.Add("aid", avid);
        }
        else
        {
            throw new Exception("avid和bvid不能同时为空");
        }

        var query = WbiSign.ParametersToQuery(WbiSign.EncodeWbi(parameters));
        var url = $"https://api.bilibili.com/x/player/wbi/playurl?{query}";

        return await GetPlayUrl(url);
    }

    /// <summary>
    ///     获取普通视频的视频流（WebPage方式）
    /// </summary>
    /// <param name="avid"></param>
    /// <param name="bvid"></param>
    /// <param name="cid"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    // public async static Task<PlayUrl?> GetVideoPlayUrlWebPage(long avid, string bvid, long cid, int p)
    // {
    //     var url = "https://www.bilibili.com/video";
    //     if (bvid == string.Empty)
    //     {
    //         url = $"{url}/{bvid}/?p={p}";
    //     }
    //     else if (avid > -1)
    //     {
    //         url = $"{url}/av{avid}/?p={p}";
    //     }
    //
    //     var playUrl = await GetPlayUrlWebPage(url);
    //     if (playUrl == null)
    //     {
    //         playUrl = await GetVideoPlayUrl(avid, bvid, cid);
    //     }
    //
    //     return playUrl;
    // }

    /// <summary>
    ///     获取番剧的视频流
    /// </summary>
    /// <param name="avid"></param>
    /// <param name="bvid"></param>
    /// <param name="cid"></param>
    /// <param name="quality"></param>
    /// <returns></returns>
    public async static Task<PlayUrl> GetBangumiPlayUrl(long avid, string? bvid, long cid, int quality = 125)
    {
        var baseUrl =
            $"https://api.bilibili.com/pgc/player/web/playurl?cid={cid}&qn={quality}&fourk=1&fnver=0&fnval=4048";
        string url;
        if (bvid != null)
        {
            url = $"{baseUrl}&bvid={bvid}";
        }
        else if (avid > -1)
        {
            url = $"{baseUrl}&aid={avid}";
        }
        else
        {
            throw new Exception("avid和bvid不能同时为空");
        }

        return await GetPlayUrl(url);
    }

    /// <summary>
    ///     获取课程的视频流
    /// </summary>
    /// <param name="avid"></param>
    /// <param name="bvid"></param>
    /// <param name="cid"></param>
    /// <param name="episodeId"></param>
    /// <param name="quality"></param>
    /// <returns></returns>
    public async static Task<PlayUrl> GetCheesePlayUrl(long avid, string? bvid, long cid, long episodeId, int quality = 125)
    {
        var baseUrl =
            $"https://api.bilibili.com/pugv/player/web/playurl?cid={cid}&qn={quality}&fourk=1&fnver=0&fnval=4048";
        string url;
        if (bvid != null)
        {
            url = $"{baseUrl}&bvid={bvid}";
        }
        else if (avid > -1)
        {
            url = $"{baseUrl}&aid={avid}";
        }
        else
        {
            throw new Exception("avid和bvid不能同时为空");
        }

        // 必须有episodeId，否则会返回请求错误
        if (episodeId != 0)
        {
            url += $"&ep_id={episodeId}";
        }

        return await GetPlayUrl(url);
    }

    /// <summary>
    ///     获取视频流
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    private async static Task<PlayUrl> GetPlayUrl(string url)
    {
        const string referer = "https://m.bilibili.com";
        var playUrl = await WebClient.RequestWebAsync<PlayUrlOrigin>(url, referer);
        if (playUrl.Data != null)
        {
            return playUrl.Data;
        }
        if (playUrl.Result != null)
        {
            return playUrl.Result;
        }
        throw new Exception("获取视频流失败");
    }

    /// <summary>
    ///     获取视频流（WebPage方式）
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    // private async static Task<PlayUrl?> GetPlayUrlWebPage(string url)
    // {
    //     const string referer = "https://www.bilibili.com";
    //     await using var response = await WebClient.RequestWebAsync(url, referer);
    //
    //     try
    //     {
    //         var regex = new Regex(@"<script>window\.__playinfo__=(.*?)<\/script>");
    //         var m = regex.Match(await new StreamReader(response).ReadToEndAsync());
    //         PlayUrlOrigin? playUrl = null;
    //         if (m.Success)
    //         {
    //             playUrl = JsonSerializer.Deserialize<PlayUrlOrigin>(m.Groups[1].ToString());
    //         }
    //
    //         if (playUrl == null)
    //         {
    //             return null;
    //         }
    //         if (playUrl.Data != null)
    //         {
    //             return playUrl.Data;
    //         }
    //         if (playUrl.Result != null)
    //         {
    //             return playUrl.Result;
    //         }
    //         return null;
    //     }
    //     catch (Exception e)
    //     {
    //         Console.Error.WriteLine("GetPlayUrlPc()发生异常: {0}", e);
    //             //         return null;
    //     }
    // }
}