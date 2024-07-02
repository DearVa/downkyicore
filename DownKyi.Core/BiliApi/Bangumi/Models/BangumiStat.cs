using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Bangumi.Models;

public class BangumiStat : BaseModel
{
    [JsonPropertyName("coins")] public long Coins { get; set; }
    [JsonPropertyName("danmakus")] public long Danmakus { get; set; }
    [JsonPropertyName("favorite")] public long Favorite { get; set; }
    [JsonPropertyName("favorites")] public long Favorites { get; set; }
    [JsonPropertyName("likes")] public long Likes { get; set; }
    [JsonPropertyName("reply")] public long Reply { get; set; }
    [JsonPropertyName("share")] public long Share { get; set; }
    [JsonPropertyName("views")] public long Views { get; set; }
}