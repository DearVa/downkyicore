using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Login.Models;

public class LoginStatus : BaseModel
{
    [JsonPropertyName("code")] public int Code { get; set; }
    [JsonPropertyName("message")] public required string Message { get; set; }
    [JsonPropertyName("data")] public required LoginStatusData Data { get; set; }
}

public class LoginStatusData : BaseModel
{
    [JsonPropertyName("url")] public required string Url { get; set; }
    [JsonPropertyName("refresh_token")] public required string RefreshToken { get; set; }
    [JsonPropertyName("code")] public int Code { get; set; }
    [JsonPropertyName("message")] public required string Message { get; set; }
}