using DownKyi.Core.BiliApi.Login.Models;

namespace DownKyi.Core.BiliApi.Login;

public static class LoginQr
{
    /// <summary>
    ///     申请二维码URL及扫码密钥（web端）
    /// </summary>
    /// <returns></returns>
    public async static Task<LoginUrlOrigin> GetLoginUrl()
    {
        const string getLoginUrl = "https://passport.bilibili.com/x/passport-login/web/qrcode/generate";
        return await WebClient.RequestWebAsync<LoginUrlOrigin>(getLoginUrl);
    }

    /// <summary>
    ///     使用扫码登录（web端）
    /// </summary>
    /// <param name="qrCodeKey"></param>
    /// <param name="goUrl"></param>
    /// <returns></returns>
    public async static Task<LoginStatus> GetLoginStatus(string qrCodeKey, string goUrl = "https://www.bilibili.com")
    {
        var url = "https://passport.bilibili.com/x/passport-login/web/qrcode/poll?qrcode_key=" + qrCodeKey;
        return await WebClient.RequestWebAsync<LoginStatus>(url);
    }
}