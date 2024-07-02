using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class BangumiFollowNewEp : BaseModel
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("index_show")] public required string IndexShow { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("long_title")] public required string LongTitle { get; set; }
    [JsonPropertyName("pub_time")] public required string PubTime { get; set; }
    [JsonPropertyName("duration")] public long Duration { get; set; }
}