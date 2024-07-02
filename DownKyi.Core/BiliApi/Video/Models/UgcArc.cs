using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class UgcArc : BaseModel
{
    [JsonPropertyName("aid")] public long Aid { get; set; }
    [JsonPropertyName("videos")] public int Videos { get; set; }
    [JsonPropertyName("type_id")] public int TypeId { get; set; }
    [JsonPropertyName("type_name")] public required string TypeName { get; set; }
    [JsonPropertyName("copyright")] public int Copyright { get; set; }
    [JsonPropertyName("pic")] public required string Pic { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("pubdate")] public long Pubdate { get; set; }
    [JsonPropertyName("ctime")] public long Ctime { get; set; }
    [JsonPropertyName("desc")] public required string Desc { get; set; }
    [JsonPropertyName("state")] public int State { get; set; }

    [JsonPropertyName("duration")] public long Duration { get; set; }

    //[JsonPropertyName("rights")]
    //public VideoRights Rights { get; set; }
    [JsonPropertyName("author")] public required VideoOwner Author { get; set; }
    [JsonPropertyName("stat")] public required VideoStat Stat { get; set; }
    [JsonPropertyName("dynamic")] public required string Dynamic { get; set; }
    [JsonPropertyName("dimension")] public required Dimension Dimension { get; set; }
}