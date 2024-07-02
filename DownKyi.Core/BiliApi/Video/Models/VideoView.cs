using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

// https://api.bilibili.com/x/web-interface/view
public class VideoViewOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required VideoView Data { get; set; }
}

public class VideoView : BaseModel
{
    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
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
    [JsonPropertyName("redirect_url")] public string? RedirectUrl { get; set; }

    [JsonPropertyName("mission_id")] public long MissionId { get; set; }

    //[JsonPropertyName("rights")]
    //public VideoRights Rights { get; set; }
    [JsonPropertyName("owner")] public required VideoOwner Owner { get; set; }
    [JsonPropertyName("stat")] public required VideoStat Stat { get; set; }
    [JsonPropertyName("dynamic")] public required string Dynamic { get; set; }
    [JsonPropertyName("cid")] public long Cid { get; set; }
    [JsonPropertyName("dimension")] public required Dimension Dimension { get; set; }
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }

    [JsonPropertyName("festival_jump_url")] public string? FestivalJumpUrl { get; set; }

    //[JsonPropertyName("no_cache")]
    //public bool no_cache { get; set; }
    [JsonPropertyName("pages")] public required List<VideoPage> Pages { get; set; }
    [JsonPropertyName("subtitle")] public required VideoSubtitle Subtitle { get; set; }

    [JsonPropertyName("ugc_season")] public required UgcSeason UgcSeason { get; set; }
    //[JsonPropertyName("staff")]
    //public required List<Staff> staff { get; set; }
    //[JsonPropertyName("user_garb")]
    //public user_garb user_garb { get; set; }
}