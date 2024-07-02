using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Favorites.Models;

// https://api.bilibili.com/x/v3/fav/folder/info
public class FavoritesMetaInfoOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required stringMessage { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required FavoritesMetaInfo Data { get; set; }
}

public class FavoritesMetaInfo : BaseModel
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("fid")] public long Fid { get; set; }

    [JsonPropertyName("mid")] public long Mid { get; set; }

    // attr
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }

    [JsonPropertyName("upper")] public required FavUpper Upper { get; set; }

    // cover_type
    [JsonPropertyName("cnt_info")] public required FavStatus CntInfo { get; set; }

    // type
    [JsonPropertyName("intro")] public required string Intro { get; set; }
    [JsonPropertyName("ctime")] public long Ctime { get; set; }

    [JsonPropertyName("mtime")] public long Mtime { get; set; }

    // state
    [JsonPropertyName("fav_state")] public int FavState { get; set; }
    [JsonPropertyName("like_state")] public int LikeState { get; set; }
    [JsonPropertyName("media_count")] public int MediaCount { get; set; }
}