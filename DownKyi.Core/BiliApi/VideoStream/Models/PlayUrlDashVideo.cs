using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

public class PlayUrlDashVideo : BaseModel
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("base_url")] public required string BaseUrl { get; set; }

    [JsonPropertyName("backup_url")] public required List<string> BackupUrl { get; set; }

    // bandwidth
    [JsonPropertyName("mimeType")] public required string MimeType { get; set; }

    // mime_type
    [JsonPropertyName("codecs")] public required string Codecs { get; set; }
    [JsonPropertyName("width")] public int Width { get; set; }
    [JsonPropertyName("height")] public int Height { get; set; }

    [JsonPropertyName("frameRate")] public required string FrameRate { get; set; }

    // frame_rate
    // sar
    // startWithSap
    // start_with_sap
    // SegmentBase
    // segment_base
    [JsonPropertyName("codecid")] public int CodecId { get; set; }
}