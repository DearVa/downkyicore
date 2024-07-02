using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

public class Subtitle : BaseModel
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("lan")] public required string Lan { get; set; }
    [JsonPropertyName("lan_doc")] public required string LanDoc { get; set; }
    [JsonPropertyName("is_lock")] public bool IsLock { get; set; }
    [JsonPropertyName("author_mid")] public long AuthorMid { get; set; }
    [JsonPropertyName("subtitle_url")] public required string SubtitleUrl { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
    [JsonPropertyName("id_str")] public required string IdStr { get; set; }
}