using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.History.Models;

public class HistoryListHistory : BaseModel
{
    [JsonPropertyName("oid")]
    public long Oid { get; set; }

    [JsonPropertyName("epid")]
    public long Epid { get; set; }

    [JsonPropertyName("bvid")]
    public required string Bvid { get; set; }

    [JsonPropertyName("page")]
    public int Page { get; set; }

    [JsonPropertyName("cid")]
    public long Cid { get; set; }

    [JsonPropertyName("part")]
    public required string Part { get; set; }

    [JsonPropertyName("business")]
    public required string Business { get; set; }

    [JsonPropertyName("dt")]
    public int Dt { get; set; }
}