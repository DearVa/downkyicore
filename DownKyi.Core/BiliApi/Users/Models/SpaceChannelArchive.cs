using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceChannelArchive : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }

    // videos
    [JsonPropertyName("tid")] public int Tid { get; set; }

    [JsonPropertyName("tname")] public required string Tname { get; set; }

    // copyright
    [JsonPropertyName("pic")] public required string Pic { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("pubdate")] public long Pubdate { get; set; }
    [JsonPropertyName("ctime")] public long Ctime { get; set; }

    [JsonPropertyName("desc")] public required string Desc { get; set; }

    // state
    [JsonPropertyName("duration")] public long Duration { get; set; }

    // mission_id
    // rights
    [JsonPropertyName("owner")] public required VideoOwner Owner { get; set; }

    [JsonPropertyName("stat")] public required SpaceChannelArchiveStat Stat { get; set; }

    // dynamic
    [JsonPropertyName("cid")] public long Cid { get; set; }

    [JsonPropertyName("dimension")] public required Dimension Dimension { get; set; }

    // season_id
    // short_link_v2
    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
    // inter_video
    // is_live_playback
}