using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Bangumi.Models;

// https://api.bilibili.com/pgc/view/web/season
public class BangumiSeasonOrigin : BaseModel
{
    [JsonPropertyName("result")] public required BangumiSeason Result { get; set; }
}

public class BangumiSeason : BaseModel
{
    // activity
    // alias
    [JsonPropertyName("areas")] public required List<BangumiArea> Areas { get; set; } = [];
    [JsonPropertyName("bkg_cover")] public required string BkgCover { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }
    [JsonPropertyName("episodes")] public required List<BangumiEpisode> Episodes { get; set; } = [];

    [JsonPropertyName("evaluate")] public required string Evaluate { get; set; }

    // freya
    // jp_title
    [JsonPropertyName("link")] public required string Link { get; set; }

    [JsonPropertyName("media_id")] public long MediaId { get; set; }

    // mode
    // new_ep
    // payment
    [JsonPropertyName("positive")] public required BangumiPositive Positive { get; set; }

    // publish
    // rating
    // record
    // rights
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }
    [JsonPropertyName("season_title")] public required string SeasonTitle { get; set; }
    [JsonPropertyName("seasons")] public required List<BangumiSeasonInfo> Seasons { get; set; } = [];

    [JsonPropertyName("section")] public required List<BangumiSection> Section { get; set; } = [];

    // series
    // share_copy
    // share_sub_title
    // share_url
    // show
    [JsonPropertyName("square_cover")] public required string SquareCover { get; set; }

    [JsonPropertyName("stat")] public BangumiStat Stat { get; set; }

    // status
    [JsonPropertyName("subtitle")] public required string Subtitle { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
    [JsonPropertyName("up_info")] public BangumiUpInfo UpInfo { get; set; }
}