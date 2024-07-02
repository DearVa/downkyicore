using DownKyi.Core.BiliApi.Users.Models;

namespace DownKyi.Core.BiliApi.Users;

/// <summary>
///     用户状态数
/// </summary>
public static class UserStatus
{
    /// <summary>
    ///     关系状态数
    /// </summary>
    /// <param name="mid"></param>
    /// <returns></returns>
    public async static Task<UserRelationStat> GetUserRelationStat(long mid)
    {
        var url = $"https://api.bilibili.com/x/relation/stat?vmid={mid}";
        const string referer = "https://www.bilibili.com";
        var userRelationStat = await WebClient.RequestWebAsync<UserRelationStatOrigin>(url, referer);
        return userRelationStat.Data;
    }

    /// <summary>
    ///     UP主状态数
    ///     注：该接口需要任意用户登录，否则不会返回任何数据
    /// </summary>
    /// <param name="mid"></param>
    /// <returns></returns>
    public async static Task<UpStat> GetUpStat(long mid)
    {
        var url = $"https://api.bilibili.com/x/space/upstat?mid={mid}";
        const string referer = "https://www.bilibili.com";
        var upStat = await WebClient.RequestWebAsync<UpStatOrigin>(url, referer);
        return upStat.Data;
    }
}