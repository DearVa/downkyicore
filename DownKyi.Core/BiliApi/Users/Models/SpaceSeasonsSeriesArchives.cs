using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceSeasonsSeriesArchives : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }
    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
    [JsonPropertyName("ctime")] public long Ctime { get; set; }
    [JsonPropertyName("duration")] public long Duration { get; set; }
    [JsonPropertyName("interactive_video")] public bool InteractiveVideo { get; set; }
    [JsonPropertyName("pic")] public required string Pic { get; set; }
    [JsonPropertyName("pubdate")] public long Pubdate { get; set; }

    [JsonPropertyName("stat")] public required SpaceSeasonsSeriesStat Stat { get; set; }

    // state
    [JsonPropertyName("title")] public required string Title { get; set; }
    // ugc_pay
}