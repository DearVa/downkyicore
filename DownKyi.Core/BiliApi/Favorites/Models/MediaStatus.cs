using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Favorites.Models;

public class MediaStatus : BaseModel
{
    [JsonPropertyName("collect")] public long Collect { get; set; }
    [JsonPropertyName("play")] public long Play { get; set; }
    [JsonPropertyName("danmaku")] public long Danmaku { get; set; }
}