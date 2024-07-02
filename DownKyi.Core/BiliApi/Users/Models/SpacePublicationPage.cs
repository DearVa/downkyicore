using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpacePublicationPage : BaseModel
{
    [JsonPropertyName("pn")] public int Pn { get; set; }
    [JsonPropertyName("ps")] public int Ps { get; set; }
    [JsonPropertyName("count")] public int Count { get; set; }
}