using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Cheese.Models;

public class CheeseEpisode : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }
    [JsonPropertyName("catalogue_index")] public int CatalogueIndex { get; set; }
    [JsonPropertyName("cid")] public long Cid { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }
    [JsonPropertyName("duration")] public long Duration { get; set; }
    [JsonPropertyName("from")] public required string From { get; set; }
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("index")] public int Index { get; set; }
    [JsonPropertyName("page")] public int Page { get; set; }
    [JsonPropertyName("play")] public long Play { get; set; }
    [JsonPropertyName("play_way")] public int PlayWay { get; set; }
    [JsonPropertyName("play_way_format")] public required string PlayWayFormat { get; set; }
    [JsonPropertyName("release_date")] public long ReleaseDate { get; set; }
    [JsonPropertyName("status")] public int Status { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("watched")] public bool Watched { get; set; }
    [JsonPropertyName("watchedHistory")] public int WatchedHistory { get; set; }
}