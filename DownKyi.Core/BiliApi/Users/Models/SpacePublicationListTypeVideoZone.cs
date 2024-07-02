using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpacePublicationListTypeVideoZone : BaseModel
{
    [JsonPropertyName("tid")] public int Tid { get; set; }
    [JsonPropertyName("count")] public int Count { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
}