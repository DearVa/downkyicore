using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Bangumi.Models;

public class BangumiUpInfo : BaseModel
{
    [JsonPropertyName("avatar")] public required string Avatar { get; set; }

    // follower
    // is_follow
    [JsonPropertyName("mid")] public long Mid { get; set; }

    // pendant
    // theme_type
    [JsonPropertyName("uname")] public required string Name { get; set; }
    // verify_type
    // vip_status
    // vip_type
}