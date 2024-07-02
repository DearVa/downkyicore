using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

public class PlayUrlSupportFormat : BaseModel
{
    [JsonPropertyName("quality")] public int Quality { get; set; }
    [JsonPropertyName("format")] public required string Format { get; set; }
    [JsonPropertyName("new_description")] public required string NewDescription { get; set; }
    [JsonPropertyName("display_desc")] public required string DisplayDesc { get; set; }
    [JsonPropertyName("superscript")] public required string Superscript { get; set; }
}