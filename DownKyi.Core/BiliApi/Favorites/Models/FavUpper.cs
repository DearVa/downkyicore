using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Favorites.Models;

public class FavUpper : BaseModel
{
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("face")] public required string Face { get; set; }

    [JsonPropertyName("followed")] public bool Followed { get; set; }
    // vip_type
    // vip_statue
}