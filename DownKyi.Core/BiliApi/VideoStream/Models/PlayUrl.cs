using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

public class PlayUrlOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public PlayUrl? Data { get; set; }
    [JsonPropertyName("result")] public PlayUrl? Result { get; set; }
}

public class PlayUrl : BaseModel
{
    // from
    // result
    // message
    // quality
    // format
    // timelength
    // accept_format
    [JsonPropertyName("accept_description")] public required List<string> AcceptDescription { get; set; }

    [JsonPropertyName("accept_quality")] public required List<int> AcceptQuality { get; set; }

    // video_codecid
    // seek_param
    // seek_type
    [JsonPropertyName("durl")] public List<PlayUrlDurl> Durl { get; set; } = [];
    [JsonPropertyName("dash")] public PlayUrlDash Dash { get; set; }

    [JsonPropertyName("support_formats")] public required List<PlayUrlSupportFormat> SupportFormats { get; set; }
    // high_format
}