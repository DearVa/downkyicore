using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceChannelArchiveStat : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }
    [JsonPropertyName("view")] public long View { get; set; }
    [JsonPropertyName("danmaku")] public long Danmaku { get; set; }
    [JsonPropertyName("reply")] public long Reply { get; set; }
    [JsonPropertyName("favorite")] public long Favorite { get; set; }
    [JsonPropertyName("coin")] public long Coin { get; set; }
    [JsonPropertyName("share")] public long Share { get; set; }
    [JsonPropertyName("now_rank")] public long NowRank { get; set; }
    [JsonPropertyName("his_rank")] public long HisRank { get; set; }
    [JsonPropertyName("like")] public long Like { get; set; }
    [JsonPropertyName("dislike")] public long Dislike { get; set; }
}