using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/series/archives?mid={mid}&series_id={seriesId}&only_normal=true&sort=desc&pn={pn}&ps={ps}
public class SpaceSeriesDetailOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required SpaceSeriesDetail Data { get; set; }
}

public class SpaceSeriesDetail : BaseModel
{
    [JsonPropertyName("aids")] public required List<long> Aids { get; set; }

    // page
    [JsonPropertyName("archives")] public required List<SpaceSeasonsSeriesArchives> Archives { get; set; }
}