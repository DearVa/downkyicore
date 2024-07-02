using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class UgcStat : BaseModel
{
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }
    [JsonPropertyName("view")] public long View { get; set; }
    [JsonPropertyName("danmaku")] public long Danmaku { get; set; }
    [JsonPropertyName("reply")] public long Reply { get; set; }
    [JsonPropertyName("fav")] public long Favorite { get; set; }
    [JsonPropertyName("coin")] public long Coin { get; set; }
    [JsonPropertyName("share")] public long Share { get; set; }
    [JsonPropertyName("now_rank")] public long NowRank { get; set; }
    [JsonPropertyName("his_rank")] public long HisRank { get; set; }
    [JsonPropertyName("like")] public long Like { get; set; }
}