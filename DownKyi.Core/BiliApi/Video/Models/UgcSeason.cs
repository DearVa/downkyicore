using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class UgcSeason : BaseModel
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("intro")] public required string Intro { get; set; }
    [JsonPropertyName("sign_state")] public int SignState { get; set; }
    [JsonPropertyName("attribute")] public int Attribute { get; set; }
    [JsonPropertyName("sections")] public required List<UgcSection> Sections { get; set; }
    [JsonPropertyName("stat")] public required UgcStat Stat { get; set; }
    [JsonPropertyName("ep_count")] public int EpCount { get; set; }
    [JsonPropertyName("season_type")] public int SeasonType { get; set; }
}