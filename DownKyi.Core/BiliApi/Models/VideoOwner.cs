using System.Text.Json.Serialization;

namespace DownKyi.Core.BiliApi.Models;

public class VideoOwner : BaseModel
{
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("face")] public required string Face { get; set; }
}