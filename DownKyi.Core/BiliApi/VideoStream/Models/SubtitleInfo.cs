using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

public class SubtitleInfo : BaseModel
{
    [JsonPropertyName("allow_submit")] public bool AllowSubmit { get; set; }
    [JsonPropertyName("lan")] public required string Lan { get; set; }
    [JsonPropertyName("lan_doc")] public required string LanDoc { get; set; }
    [JsonPropertyName("subtitles")] public required List<Subtitle> Subtitles { get; set; }
}