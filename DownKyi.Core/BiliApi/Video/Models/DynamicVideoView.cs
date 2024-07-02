using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class DynamicVideoView : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }
    [JsonPropertyName("videos")] public int Videos { get; set; }
    [JsonPropertyName("tid")] public int Tid { get; set; }
    [JsonPropertyName("tname")] public required string Tname { get; set; }
    [JsonPropertyName("copyright")] public int Copyright { get; set; }
    [JsonPropertyName("pic")] public required string Pic { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("pubdate")] public long Pubdate { get; set; }
    [JsonPropertyName("ctime")] public long Ctime { get; set; }
    [JsonPropertyName("desc")] public required string Desc { get; set; }
    [JsonPropertyName("state")] public int State { get; set; }
    [JsonPropertyName("duration")] public long Duration { get; set; }
    [JsonPropertyName("owner")] public required VideoOwner Owner { get; set; }
    [JsonPropertyName("stat")] public required VideoStat Stat { get; set; }
    [JsonPropertyName("dynamic")] public required string Dynamic { get; set; }
    [JsonPropertyName("cid")] public long Cid { get; set; }
    [JsonPropertyName("dimension")] public required Dimension Dimension { get; set; }
    [JsonPropertyName("short_link")] public required string ShortLink { get; set; }
    [JsonPropertyName("short_link_v2")] public required string ShortLinkV2 { get; set; }
    [JsonPropertyName("first_frame")] public required string FirstFrame { get; set; }
    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
    [JsonPropertyName("season_type")] public int SeasonType { get; set; }
    [JsonPropertyName("is_ogv")] public bool IsOgv { get; set; }
}