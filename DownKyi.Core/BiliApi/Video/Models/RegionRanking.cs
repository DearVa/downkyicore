﻿using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

// https://api.bilibili.com/x/web-interface/ranking/region
public class RegionRanking : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required List<RankingVideoView> Data { get; set; }
}