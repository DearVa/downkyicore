using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.VideoStream.Models;

// https://api.bilibili.com/x/player/v2?cid={cid}&aid={avid}&bvid={bvid}
public class PlayerV2Origin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required PlayerV2 Data { get; set; }
}

public class PlayerV2 : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }

    [JsonPropertyName("bvid")] public required string Bvid { get; set; }

    // allow_bp
    // no_share
    [JsonPropertyName("cid")] public long Cid { get; set; }

    // ...
    [JsonPropertyName("subtitle")] public required SubtitleInfo Subtitle { get; set; }
}