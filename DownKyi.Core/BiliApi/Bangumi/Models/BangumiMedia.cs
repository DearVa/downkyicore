using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Bangumi.Models;

// https://api.bilibili.com/pgc/review/user
public class BangumiMediaOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required stringMessage { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("result")] public required BangumiMediaData Result { get; set; }
}

public class BangumiMediaData : BaseModel
{
    [JsonPropertyName("media")] public required BangumiMedia Media { get; set; }
}

public class BangumiMedia : BaseModel
{
    [JsonPropertyName("areas")] public required List<BangumiArea> Areas { get; set; }
    [JsonPropertyName("cover")] public required string Cover { get; set; }

    [JsonPropertyName("media_id")] public long MediaId { get; set; }

    // new_ep
    // rating
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }
    [JsonPropertyName("share_url")] public required string ShareUrl { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("type_name")] public required string TypeName { get; set; }
}