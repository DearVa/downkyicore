using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpacePublicationListVideo : BaseModel
{
    //[JsonPropertyName("comment")]
    //public int Comment { get; set; }
    [JsonPropertyName("typeid")] public int Typeid { get; set; }
    [JsonPropertyName("play")] public int Play { get; set; }

    [JsonPropertyName("pic")] public required string Pic { get; set; }

    //[JsonPropertyName("subtitle")]
    //public required string Subtitle { get; set; }
    //[JsonPropertyName("description")]
    //public required string Description { get; set; }
    //[JsonPropertyName("copyright")]
    //public required string Copyright { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }

    //[JsonPropertyName("review")]
    //public int Review { get; set; }
    //[JsonPropertyName("author")]
    //public required string Author { get; set; }
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("created")] public long Created { get; set; }

    [JsonPropertyName("length")] public required string Length { get; set; }

    //[JsonPropertyName("video_review")]
    //public int VideoReview { get; set; }
    [JsonPropertyName("aid")] public long Aid { get; set; }

    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
    //[JsonPropertyName("hide_click")]
    //public bool HideClick { get; set; }
    //[JsonPropertyName("is_pay")]
    //public int IsPay { get; set; }
    //[JsonPropertyName("is_union_video")]
    //public int IsUnionVideo { get; set; }
    //[JsonPropertyName("is_steins_gate")]
    //public int IsSteinsGate { get; set; }
    //[JsonPropertyName("is_live_playback")]
    //public int IsLivePlayback { get; set; }
}