using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

public class PlayUrlDurl : BaseModel
{
    [JsonPropertyName("order")] public int Order { get; set; }
    [JsonPropertyName("length")] public long Length { get; set; }

    [JsonPropertyName("size")] public long Size { get; set; }

    // ahead
    // vhead
    [JsonPropertyName("url")] public required string Url { get; set; }
    [JsonPropertyName("backup_url")] public required List<string> BackupUrl { get; set; }
}