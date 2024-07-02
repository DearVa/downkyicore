using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/series/series?series_id={seriesId}
public class SpaceSeriesMetaOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required SpaceSeriesMetaData Data { get; set; }
}

public class SpaceSeriesMetaData : BaseModel
{
    [JsonPropertyName("meta")] public required SpaceSeriesMeta Meta { get; set; }
    [JsonPropertyName("recent_aids")] public required List<long> RecentAids { get; set; }
}