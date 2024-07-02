using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.History.Models;

public class HistoryCursor : BaseModel
{
    [JsonPropertyName("max")]
    public long Max { get; set; }

    [JsonPropertyName("view_at")]
    public long ViewAt { get; set; }

    [JsonPropertyName("business")]
    public required string Business { get; set; }

    [JsonPropertyName("ps")]
    public int Ps { get; set; }
}