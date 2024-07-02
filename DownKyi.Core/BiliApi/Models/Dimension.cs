using System.Text.Json.Serialization;

namespace DownKyi.Core.BiliApi.Models;

public class Dimension : BaseModel
{
    [JsonPropertyName("width")] public int Width { get; set; }
    [JsonPropertyName("height")] public int Height { get; set; }
    [JsonPropertyName("rotate")] public int Rotate { get; set; }
}