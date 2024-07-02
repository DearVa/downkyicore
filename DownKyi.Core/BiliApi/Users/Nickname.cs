using DownKyi.Core.BiliApi.Users.Models;

namespace DownKyi.Core.BiliApi.Users;

/// <summary>
///     用户昵称
/// </summary>
public class Nickname
{
    /// <summary>
    ///     检查昵称
    /// </summary>
    /// <param name="nickName"></param>
    /// <returns></returns>
    public async static Task<NicknameStatus> CheckNickname(string nickName)
    {
        var url = $"https://api.bilibili.com/x/relation/stat?nickName={nickName}";
        const string referer = "https://www.bilibili.com";
        var nickname = await WebClient.RequestWebAsync<NicknameStatus>(url, referer);
        return nickname;
    }
}