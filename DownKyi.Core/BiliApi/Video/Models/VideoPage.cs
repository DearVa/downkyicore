using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class VideoPage : BaseModel
{
    [JsonPropertyName("cid")] public long Cid { get; set; }
    [JsonPropertyName("page")] public int Page { get; set; }
    [JsonPropertyName("from")] public required string From { get; set; }
    [JsonPropertyName("part")] public required string Part { get; set; }
    [JsonPropertyName("duration")] public long Duration { get; set; }
    [JsonPropertyName("vid")] public required string Vid { get; set; }
    [JsonPropertyName("weblink")] public required string Weblink { get; set; }
    [JsonPropertyName("dimension")] public required Dimension Dimension { get; set; }
    [JsonPropertyName("first_frame")] public string? FirstFrame { get; set; }
}