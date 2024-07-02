using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Cheese.Models;

public class CheeseUpInfo : BaseModel
{
    [JsonPropertyName("avatar")] public required string Avatar { get; set; }
    [JsonPropertyName("brief")] public required string Brief { get; set; }
    [JsonPropertyName("follower")] public long Follower { get; set; }
    [JsonPropertyName("is_follow")] public int IsFollow { get; set; }
    [JsonPropertyName("link")] public required string Link { get; set; }
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("uname")] public required string Name { get; set; }
}