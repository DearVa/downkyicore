using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

[Serializable]
public class PlayUrlDash : BaseModel
{
    [JsonPropertyName("duration")] public long Duration { get; set; }

    //[JsonPropertyName("minBufferTime")]
    //public float minBufferTime { get; set; }
    //[JsonPropertyName("min_buffer_time")]
    //public float min_buffer_time { get; set; }
    [JsonPropertyName("video")] public required List<PlayUrlDashVideo> Video { get; set; }
    [JsonPropertyName("audio")] public required List<PlayUrlDashVideo> Audio { get; set; }
    [JsonPropertyName("dolby")] public PlayUrlDashDolby? Dolby { get; set; }
    [JsonPropertyName("flac")] public PlayUrlDashFlac? Flac { get; set; }
}