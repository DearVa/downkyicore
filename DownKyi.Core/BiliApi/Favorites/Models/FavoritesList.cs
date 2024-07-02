using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Favorites.Models;

// https://api.bilibili.com/x/v3/fav/folder/collected/list
public class FavoritesListOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required stringMessage { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required FavoritesList Data { get; set; }
}

public class FavoritesList : BaseModel
{
    [JsonPropertyName("count")] public int Count { get; set; }

    [JsonPropertyName("list")] public required List<FavoritesMetaInfo> List { get; set; }
    //[JsonPropertyName("has_more")]
    //public bool HasMore { get; set; }
}