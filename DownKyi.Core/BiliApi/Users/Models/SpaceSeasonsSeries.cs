using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceSeasons : BaseModel
{
    [JsonPropertyName("archives")] public required List<SpaceSeasonsSeriesArchives> Archives { get; set; }
    [JsonPropertyName("meta")] public required SpaceSeasonsMeta Meta { get; set; }
    [JsonPropertyName("recent_aids")] public required List<long> RecentAids { get; set; }
}

public class SpaceSeries : BaseModel
{
    [JsonPropertyName("archives")] public required List<SpaceSeasonsSeriesArchives> Archives { get; set; }
    [JsonPropertyName("meta")] public required SpaceSeriesMeta Meta { get; set; }
    [JsonPropertyName("recent_aids")] public required List<long> RecentAids { get; set; }
}