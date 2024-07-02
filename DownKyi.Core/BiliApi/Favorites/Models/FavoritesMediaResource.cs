using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Favorites.Models;

// https://api.bilibili.com/x/v3/fav/resource/list
public class FavoritesMediaResourceOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required stringMessage { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required FavoritesMediaResource Data { get; set; }
}

public class FavoritesMediaResource : BaseModel
{
    [JsonPropertyName("info")] public required FavoritesMetaInfo Info { get; set; }
    [JsonPropertyName("medias")] public required List<FavoritesMedia> Medias { get; set; }
    [JsonPropertyName("has_more")] public bool HasMore { get; set; }
}