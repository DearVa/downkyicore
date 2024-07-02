using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/relation/stat?nickName={nickName}
public class NicknameStatus : BaseModel
{
    [JsonPropertyName("code")] public int Code { get; set; }
    [JsonPropertyName("message")] public required string Message { get; set; }
}