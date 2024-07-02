using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

public class PlayUrlDashFlac : BaseModel
{
    [JsonPropertyName("audio")] public PlayUrlDashVideo Audio { get; set; }
    //bool display { get; set; }
}