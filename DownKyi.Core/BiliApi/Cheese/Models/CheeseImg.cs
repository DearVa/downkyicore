using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Cheese.Models;

public class CheeseImg : BaseModel
{
    [JsonPropertyName("aspect_ratio")] public double AspectRatio { get; set; }
    [JsonPropertyName("url")] public required string Url { get; set; }
}