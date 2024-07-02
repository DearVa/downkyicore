using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

// https://api.bilibili.com/x/web-interface/dynamic/region
public class RegionDynamicOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required RegionDynamic Data { get; set; }
}

public class RegionDynamic : BaseModel
{
    [JsonPropertyName("archives")] public required List<DynamicVideoView> Archives { get; set; }
    // page
}