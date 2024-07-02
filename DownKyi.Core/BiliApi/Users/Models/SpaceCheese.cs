using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceCheese : BaseModel
{
    [JsonPropertyName("cover")] public required string Cover { get; set; }
    [JsonPropertyName("ep_count")] public int EpCount { get; set; }
    [JsonPropertyName("link")] public required string Link { get; set; }
    [JsonPropertyName("page")] public int Page { get; set; }
    [JsonPropertyName("play")] public int Play { get; set; }
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }
    [JsonPropertyName("status")] public required string Status { get; set; }
    [JsonPropertyName("subtitle")] public required string SubTitle { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
}