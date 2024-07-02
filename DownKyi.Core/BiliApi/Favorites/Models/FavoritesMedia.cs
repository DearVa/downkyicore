using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Favorites.Models;

public class FavoritesMedia : BaseModel
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }
    [JsonPropertyName("intro")] public required string Intro { get; set; }
    [JsonPropertyName("page")] public int Page { get; set; }
    [JsonPropertyName("duration")] public long Duration { get; set; }

    [JsonPropertyName("upper")] public required FavUpper Upper { get; set; }

    // attr
    [JsonPropertyName("cnt_info")] public required MediaStatus CntInfo { get; set; }
    [JsonPropertyName("link")] public required string Link { get; set; }
    [JsonPropertyName("ctime")] public long Ctime { get; set; }
    [JsonPropertyName("pubtime")] public long Pubtime { get; set; }
    [JsonPropertyName("fav_time")] public long FavTime { get; set; }
    [JsonPropertyName("bv_id")] public required string BvId { get; set; }

    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
    // season
    // ogv
    // ugc
}