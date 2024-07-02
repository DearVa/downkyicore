using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceCheesePage : BaseModel
{
    [JsonPropertyName("next")] public bool Next { get; set; }
    [JsonPropertyName("num")] public int Num { get; set; }
    [JsonPropertyName("size")] public int Size { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
}