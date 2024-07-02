using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/space/acc/info?mid={mid}
public class UserInfoForSpaceOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required UserInfoForSpace Data { get; set; }
}

public class UserInfoForSpace : BaseModel
{
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("sex")] public required string Sex { get; set; }

    [JsonPropertyName("face")] public required string Face { get; set; }

    // face_nft
    [JsonPropertyName("sign")] public required string Sign { get; set; }

    // rank
    [JsonPropertyName("level")] public int Level { get; set; }

    // jointime
    // moral
    // silence
    // coins
    //[JsonPropertyName("fans_badge")]
    //public bool FansBadge { get; set; }
    // fans_medal
    // official
    [JsonPropertyName("vip")] public UserInfoVip? Vip { get; set; }

    // pendant
    // nameplate
    // user_honour_info
    [JsonPropertyName("is_followed")] public bool IsFollowed { get; set; }

    [JsonPropertyName("top_photo")] public required string TopPhoto { get; set; }
    // ...
}