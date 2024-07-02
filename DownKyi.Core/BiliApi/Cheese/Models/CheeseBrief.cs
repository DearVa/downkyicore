using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Cheese.Models;

public class CheeseBrief : BaseModel
{
    // content
    [JsonPropertyName("img")] public required List<CheeseImg> Img { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("type")] public int Type { get; set; }
}