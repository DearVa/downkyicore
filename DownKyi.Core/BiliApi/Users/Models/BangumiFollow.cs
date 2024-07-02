using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class BangumiFollow : BaseModel
{
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }
    [JsonPropertyName("media_id")] public long MediaId { get; set; }
    [JsonPropertyName("season_type")] public int SeasonType { get; set; }
    [JsonPropertyName("season_type_name")] public required string SeasonTypeName { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }

    [JsonPropertyName("total_count")] public int TotalCount { get; set; }

    // is_finish
    // is_started
    // is_play
    [JsonPropertyName("badge")] public required string Badge { get; set; }

    [JsonPropertyName("badge_type")] public int BadgeType { get; set; }

    // rights
    // stat
    [JsonPropertyName("new_ep")] public BangumiFollowNewEp NewEp { get; set; }

    // rating
    // square_cover
    [JsonPropertyName("season_status")] public int SeasonStatus { get; set; }
    [JsonPropertyName("season_title")] public required string SeasonTitle { get; set; }

    [JsonPropertyName("badge_ep")] public required string BadgeEp { get; set; }

    // media_attr
    // season_attr
    [JsonPropertyName("evaluate")] public required string Evaluate { get; set; }
    [JsonPropertyName("areas")] public required List<BangumiFollowAreas> Areas { get; set; }
    [JsonPropertyName("subtitle")] public required string Subtitle { get; set; }

    [JsonPropertyName("first_ep")] public long FirstEp { get; set; }

    // can_watch
    // series
    // publish
    // mode
    // section
    [JsonPropertyName("url")] public required string Url { get; set; }

    // badge_info
    // first_ep_info
    // formal_ep_count
    // short_url
    // badge_infos
    // season_version
    // horizontal_cover_16_9
    // horizontal_cover_16_10
    // subtitle_14
    // viewable_crowd_type
    // producers
    // follow_status
    // is_new
    [JsonPropertyName("progress")] public required string Progress { get; set; }
    // both_follow
}