using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/space/channel/video?mid={mid}&page_num={pageNum}&page_size={pageSize}
public class SpaceSeasonsSeriesOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required SpaceSeasonsSeriesData Data { get; set; }
}

public class SpaceSeasonsSeriesData : BaseModel
{
    [JsonPropertyName("items_lists")] public required SpaceSeasonsSeries ItemsLists { get; set; }
}

public class SpaceSeasonsSeries : BaseModel
{
    [JsonPropertyName("page")] public required SpaceSeasonsSeriesPage Page { get; set; }
    [JsonPropertyName("seasons_list")] public required List<SpaceSeasons> SeasonsList { get; set; }
    [JsonPropertyName("series_list")] public required List<SpaceSeries> SeriesList { get; set; }
}