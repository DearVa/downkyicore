using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Bangumi.Models;

public class BangumiSection : BaseModel
{
    [JsonPropertyName("episode_id")] public long EpisodeId { get; set; }
    [JsonPropertyName("episodes")] public required List<BangumiEpisode> Episodes { get; set; }
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
}