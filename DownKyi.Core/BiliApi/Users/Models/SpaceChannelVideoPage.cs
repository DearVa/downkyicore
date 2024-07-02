using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceChannelVideoPage : BaseModel
{
    [JsonPropertyName("count")] public int Count { get; set; }
    [JsonPropertyName("num")] public int Num { get; set; }
    [JsonPropertyName("size")] public int Size { get; set; }
}