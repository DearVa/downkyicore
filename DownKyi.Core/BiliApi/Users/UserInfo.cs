using DownKyi.Core.BiliApi.Sign;
using DownKyi.Core.BiliApi.Users.Models;

namespace DownKyi.Core.BiliApi.Users;

/// <summary>
///     用户基本信息
/// </summary>
public static class UserInfo
{
    /// <summary>
    ///     导航栏用户信息
    /// </summary>
    /// <returns></returns>
    public async static Task<UserInfoForNavigation> GetUserInfoForNavigation()
    {
        const string url = "https://api.bilibili.com/x/web-interface/nav";
        const string referer = "https://www.bilibili.com";
        var userInfo = await WebClient.RequestWebAsync<UserInfoForNavigationOrigin>(url, referer);
        return userInfo.Data;
    }

    /// <summary>
    ///     用户空间详细信息
    /// </summary>
    /// <param name="mid"></param>
    /// <returns></returns>
    public async static Task<UserInfoForSpace> GetUserInfoForSpace(long mid)
    {
        var parameters = new Dictionary<string, object>
        {
            { "mid", mid },
        };
        var query = WbiSign.ParametersToQuery(WbiSign.EncodeWbi(parameters));
        var url = $"https://api.bilibili.com/x/space/wbi/acc/info?{query}";
        const string referer = "https://www.bilibili.com";
        var spaceInfo = await WebClient.RequestWebAsync<UserInfoForSpaceOrigin>(url, referer, needRandomBvuid3: true);
        return spaceInfo.Data;
    }

    /// <summary>
    ///     本用户详细信息
    /// </summary>
    /// <returns></returns>
    public async static Task<MyInfo> GetMyInfo()
    {
        const string url = "https://api.bilibili.com/x/space/myinfo";
        const string referer = "https://www.bilibili.com";
        var myInfo = await WebClient.RequestWebAsync<MyInfoOrigin>(url, referer);
        return myInfo.Data;
    }
}