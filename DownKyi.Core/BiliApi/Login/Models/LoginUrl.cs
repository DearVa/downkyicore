using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Login.Models;
// https://passport.bilibili.com/qrcode/getLoginUrl

public class LoginUrlOrigin : BaseModel
{
    //public int code { get; set; }
    [JsonPropertyName("data")] public required LoginUrl Data { get; set; }

    [JsonPropertyName("code")] public int Code { get; set; }
    //public long ts { get; set; }
}

public class LoginUrl : BaseModel
{
    [JsonPropertyName("qrcode_key")] public required string QrCodeKey { get; set; }
    [JsonPropertyName("url")] public required string Url { get; set; }
}