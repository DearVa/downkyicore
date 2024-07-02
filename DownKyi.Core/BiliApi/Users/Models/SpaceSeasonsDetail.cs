using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/polymer/space/seasons_archives_list?mid={mid}&season_id={seasonId}&page_num={pageNum}&page_size={pageSize}&sort_reverse=false
public class SpaceSeasonsDetailOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required SpaceSeasonsDetail Data { get; set; }
}

public class SpaceSeasonsDetail : BaseModel
{
    [JsonPropertyName("aids")] public required List<long> Aids { get; set; }
    [JsonPropertyName("archives")] public required List<SpaceSeasonsSeriesArchives> Archives { get; set; }
    [JsonPropertyName("meta")] public required SpaceSeasonsMeta Meta { get; set; }
    [JsonPropertyName("page")] public required SpaceSeasonsSeriesPage Page { get; set; }
}