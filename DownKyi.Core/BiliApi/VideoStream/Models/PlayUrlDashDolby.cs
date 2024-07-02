using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

public class PlayUrlDashDolby : BaseModel
{
    // type
    [JsonPropertyName("audio")]
    public required List<PlayUrlDashVideo> Audio { get; set; }
}