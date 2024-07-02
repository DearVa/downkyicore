using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceSeasonsSeriesMeta : BaseModel
{
    [JsonPropertyName("category")] public int Category { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }
    [JsonPropertyName("description")] public required string Description { get; set; }
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
}

public class SpaceSeasonsMeta : SpaceSeasonsSeriesMeta
{
    [JsonPropertyName("ptime")] public long Ptime { get; set; }
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }
}

public class SpaceSeriesMeta : SpaceSeasonsSeriesMeta
{
    [JsonPropertyName("creator")] public required string Creator { get; set; }
    [JsonPropertyName("ctime")] public long Ctime { get; set; }
    [JsonPropertyName("keywords")] public required List<string> Keywords { get; set; }
    [JsonPropertyName("last_update_ts")] public long LastUpdate { get; set; }
    [JsonPropertyName("mtime")] public long Mtime { get; set; }
    [JsonPropertyName("raw_keywords")] public required string RawKeywords { get; set; }
    [JsonPropertyName("series_id")] public long SeriesId { get; set; }
    [JsonPropertyName("state")] public int State { get; set; }
}