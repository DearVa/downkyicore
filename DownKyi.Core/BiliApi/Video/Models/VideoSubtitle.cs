using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class VideoSubtitle : BaseModel
{
    [JsonPropertyName("allow_submit")] public bool AllowSubmit { get; set; }
    [JsonPropertyName("list")] public List<Subtitle> List { get; set; } = [];
}

public class Subtitle : BaseModel
{
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("lan")] public string? Lan { get; set; }
    [JsonPropertyName("lan_doc")] public string? LanDoc { get; set; }
    [JsonPropertyName("is_lock")] public bool IsLock { get; set; }
    [JsonPropertyName("author_mid")] public long AuthorMid { get; set; }
    [JsonPropertyName("subtitle_url")] public string? SubtitleUrl { get; set; }
    [JsonPropertyName("author")] public SubtitleAuthor? Author { get; set; }
}

public class SubtitleAuthor : BaseModel
{
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("sex")] public string? Sex { get; set; }
    [JsonPropertyName("face")] public string? Face { get; set; }

    [JsonPropertyName("sign")] public string? Sign { get; set; }
    //[JsonPropertyName("rank")]
    //public int Rank { get; set; }
    //[JsonPropertyName("birthday")]
    //public int Birthday { get; set; }
    //[JsonPropertyName("is_fake_account")]
    //public int IsFakeAccount { get; set; }
    //[JsonPropertyName("is_deleted")]
    //public int IsDeleted { get; set; }
}