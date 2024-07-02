using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceChannelVideoList : BaseModel
{
    [JsonPropertyName("cid")] public long Cid { get; set; }
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("intro")] public required string Intro { get; set; }
    [JsonPropertyName("mtime")] public long Mtime { get; set; }
    [JsonPropertyName("count")] public int Count { get; set; }

    [JsonPropertyName("cover")] public required string Cover { get; set; }

    // is_live_playback
    [JsonPropertyName("archives")] public required List<SpaceChannelArchive> Archives { get; set; }
}