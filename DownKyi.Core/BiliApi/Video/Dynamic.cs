﻿using DownKyi.Core.BiliApi.Video.Models;

namespace DownKyi.Core.BiliApi.Video;

public static class Dynamic
{
    /// <summary>
    ///     获取分区最新视频列表
    /// </summary>
    /// <param name="rid">目标分区tid</param>
    /// <param name="pn">页码</param>
    /// <param name="ps">每页项数（最大50）</param>
    /// <returns></returns>
    public async static Task<List<DynamicVideoView>> RegionDynamicList(int rid, int pn = 1, int ps = 5)
    {
        var url = $"https://api.bilibili.com/x/web-interface/dynamic/region?rid={rid}&pn={pn}&ps={ps}";
        const string referer = "https://www.bilibili.com";
        var dynamic = await WebClient.RequestWebAsync<RegionDynamicOrigin>(url, referer);
        return dynamic.Data.Archives;
    }
}