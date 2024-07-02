using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.History.Models;

public class HistoryList : BaseModel
{
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    // long_title
    [JsonPropertyName("cover")]
    public required string Cover { get; set; }

    // covers
    [JsonPropertyName("uri")]
    public required string Uri { get; set; }

    [JsonPropertyName("history")]
    public required HistoryListHistory History { get; set; }

    [JsonPropertyName("videos")]
    public int Videos { get; set; }

    [JsonPropertyName("author_name")]
    public required string AuthorName { get; set; }

    [JsonPropertyName("author_face")]
    public required string AuthorFace { get; set; }

    [JsonPropertyName("author_mid")]
    public long AuthorMid { get; set; }

    [JsonPropertyName("view_at")]
    public long ViewAt { get; set; }

    [JsonPropertyName("progress")]
    public long Progress { get; set; }

    // badge
    [JsonPropertyName("show_title")]
    public required string ShowTitle { get; set; }

    [JsonPropertyName("duration")]
    public long Duration { get; set; }

    // current
    // total
    [JsonPropertyName("new_desc")]
    public required string NewDesc { get; set; }

    // is_finish
    // is_fav
    // kid
    [JsonPropertyName("tag_name")]
    public required string TagName { get; set; }
    // live_status
}