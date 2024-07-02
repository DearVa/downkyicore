using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Favorites.Models;

public class FavStatus : BaseModel
{
    [JsonPropertyName("collect")] public long Collect { get; set; }
    [JsonPropertyName("play")] public long Play { get; set; }
    [JsonPropertyName("thumb_up")] public long ThumbUp { get; set; }
    [JsonPropertyName("share")] public long Share { get; set; }
}