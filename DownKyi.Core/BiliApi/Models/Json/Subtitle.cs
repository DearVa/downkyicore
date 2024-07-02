using System.Text.Json.Serialization;

namespace DownKyi.Core.BiliApi.Models.Json;

public class Subtitle : BaseModel
{
    [JsonPropertyName("from")] public float From { get; set; }
    [JsonPropertyName("to")] public float To { get; set; }
    [JsonPropertyName("location")] public int Location { get; set; }
    [JsonPropertyName("content")] public required string Content { get; set; }
}