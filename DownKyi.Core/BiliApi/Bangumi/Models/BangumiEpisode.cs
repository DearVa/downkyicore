using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Bangumi.Models;

public class BangumiEpisode : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }

    [JsonPropertyName("badge")] public required string Badge { get; set; }

    // badge_info
    // badge_type
    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
    [JsonPropertyName("cid")] public long Cid { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }
    [JsonPropertyName("dimension")] public Dimension Dimension { get; set; }
    [JsonPropertyName("duration")] public long Duration { get; set; }
    [JsonPropertyName("from")] public required string From { get; set; }
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("link")] public required string Link { get; set; }
    [JsonPropertyName("long_title")] public required string LongTitle { get; set; }

    [JsonPropertyName("pub_time")] public long PubTime { get; set; }

    // pv
    // release_date
    // rights
    [JsonPropertyName("share_copy")] public required string ShareCopy { get; set; }
    [JsonPropertyName("share_url")] public required string ShareUrl { get; set; }

    [JsonPropertyName("short_link")] public required string ShortLink { get; set; }

    // stat
    [JsonPropertyName("status")] public int Status { get; set; }
    [JsonPropertyName("subtitle")] public required string Subtitle { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("vid")] public required string Vid { get; set; }
}