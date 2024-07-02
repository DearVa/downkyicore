using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.History.Models;

// https://api.bilibili.com/x/web-interface/history/cursor?max={startId}&view_at={startTime}&ps={ps}&business={businessStr}
public class HistoryOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required stringMessage { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")]
    public required HistoryData Data { get; set; }
}

public class HistoryData : BaseModel
{
    [JsonPropertyName("cursor")]
    public required HistoryCursor Cursor { get; set; }

    //public required List<HistoryDataTab> tab { get; set; }
    [JsonPropertyName("list")]
    public required List<HistoryList> List { get; set; }
}