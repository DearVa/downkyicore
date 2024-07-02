using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.History.Models;

// https://api.bilibili.com/x/v2/history/toview
public class ToViewOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required stringMessage { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")]
    public required ToViewData Data { get; set; }
}

public class ToViewData : BaseModel
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("list")]
    public required List<ToViewList> List { get; set; }
}