using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class RankingVideoView : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }
    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
    [JsonPropertyName("typename")] public required string TypeName { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("subtitle")] public required string Subtitle { get; set; }
    [JsonPropertyName("play")] public long Play { get; set; }
    [JsonPropertyName("review")] public long Review { get; set; }
    [JsonPropertyName("video_review")] public long VideoReview { get; set; }
    [JsonPropertyName("favorites")] public long Favorites { get; set; }
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("author")] public required string Author { get; set; }
    [JsonPropertyName("description")] public required string Description { get; set; }
    [JsonPropertyName("create")] public required string Create { get; set; }
    [JsonPropertyName("pic")] public required string Pic { get; set; }
    [JsonPropertyName("coins")] public long Coins { get; set; }
    [JsonPropertyName("duration")] public required string Duration { get; set; }
    [JsonPropertyName("badgepay")] public bool Badgepay { get; set; }
    [JsonPropertyName("pts")] public long Pts { get; set; }
    [JsonPropertyName("redirect_url")] public required string RedirectUrl { get; set; }
}