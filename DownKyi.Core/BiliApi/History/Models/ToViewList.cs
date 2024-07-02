using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.History.Models;

public class ToViewList : BaseModel
{
    [JsonPropertyName("aid")]
    public long Aid { get; set; }

    // videos
    // tid
    // tname
    // copyright
    [JsonPropertyName("pic")]
    public required string Pic { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    // pubdate
    // ctime
    // desc
    // state
    // duration
    // rights
    [JsonPropertyName("owner")]
    public VideoOwner Owner { get; set; }

    // stat
    // dynamic
    // dimension
    // short_link_v2
    // first_frame
    // page
    // count
    [JsonPropertyName("cid")]
    public long Cid { get; set; }

    // progress
    [JsonPropertyName("add_at")]
    public long AddAt { get; set; }

    [JsonPropertyName("bvid")]
    public required string Bvid { get; set; }
    // uri
    // viewed
}