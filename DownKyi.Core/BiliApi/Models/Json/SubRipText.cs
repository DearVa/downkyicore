using System.Text.Json.Serialization;

namespace DownKyi.Core.BiliApi.Models.Json;

public class SubRipText : BaseModel
{
    [JsonPropertyName("lan")] public required string Lan { get; set; }
    [JsonPropertyName("lan_doc")] public required string LanDoc { get; set; }
    [JsonPropertyName("srtString")] public required string SrtString { get; set; }
}