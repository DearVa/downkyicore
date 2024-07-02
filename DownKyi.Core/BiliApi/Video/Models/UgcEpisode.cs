using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Video.Models;

public class UgcEpisode : BaseModel
{
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }
    [JsonPropertyName("section_id")] public long SectionId { get; set; }
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("aid")] public long Aid { get; set; }
    [JsonPropertyName("cid")] public long Cid { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }
    [JsonPropertyName("attribute")] public int Attribute { get; set; }
    [JsonPropertyName("arc")] public required UgcArc Arc { get; set; }
    [JsonPropertyName("page")] public required VideoPage Page { get; set; }
    [JsonPropertyName("bvid")] public required string Bvid { get; set; }
}