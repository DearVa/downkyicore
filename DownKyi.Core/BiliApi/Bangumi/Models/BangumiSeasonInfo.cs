using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Bangumi.Models;

public class BangumiSeasonInfo : BaseModel
{
    [JsonPropertyName("badge")] public required string Badge { get; set; }

    // badge_info
    // badge_type
    [JsonPropertyName("cover")] public required string Cover { get; set; }

    [JsonPropertyName("media_id")] public long MediaId { get; set; }

    // new_ep
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }
    [JsonPropertyName("season_title")] public required string SeasonTitle { get; set; }

    [JsonPropertyName("season_type")] public int SeasonType { get; set; }
    // stat
}