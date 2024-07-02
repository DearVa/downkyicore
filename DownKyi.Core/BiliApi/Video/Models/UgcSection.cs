using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class UgcSection : BaseModel
{
    [JsonPropertyName("season_id")]
    public long SeasonId { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("episodes")]
    public required List<UgcEpisode> Episodes { get; set; }
}