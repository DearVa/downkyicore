using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Bangumi.Models;

public class BangumiPositive : BaseModel
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
}