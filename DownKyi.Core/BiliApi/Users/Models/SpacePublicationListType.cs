using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpacePublicationListType : BaseModel
{
    [JsonPropertyName("1")] public required SpacePublicationListTypeVideoZone Douga { get; set; }
    [JsonPropertyName("13")] public required SpacePublicationListTypeVideoZone Anime { get; set; }
    [JsonPropertyName("167")] public required SpacePublicationListTypeVideoZone Guochuang { get; set; }
    [JsonPropertyName("3")] public required SpacePublicationListTypeVideoZone Music { get; set; }
    [JsonPropertyName("129")] public required SpacePublicationListTypeVideoZone Dance { get; set; }
    [JsonPropertyName("4")] public required SpacePublicationListTypeVideoZone Game { get; set; }
    [JsonPropertyName("36")] public required SpacePublicationListTypeVideoZone Technology { get; set; }
    [JsonPropertyName("188")] public required SpacePublicationListTypeVideoZone Digital { get; set; }
    [JsonPropertyName("234")] public required SpacePublicationListTypeVideoZone Sports { get; set; }
    [JsonPropertyName("223")] public required SpacePublicationListTypeVideoZone Car { get; set; }
    [JsonPropertyName("160")] public required SpacePublicationListTypeVideoZone Life { get; set; }
    [JsonPropertyName("211")] public required SpacePublicationListTypeVideoZone Food { get; set; }
    [JsonPropertyName("217")] public required SpacePublicationListTypeVideoZone Animal { get; set; }
    [JsonPropertyName("119")] public required SpacePublicationListTypeVideoZone Kichiku { get; set; }
    [JsonPropertyName("155")] public required SpacePublicationListTypeVideoZone Fashion { get; set; }
    [JsonPropertyName("202")] public required SpacePublicationListTypeVideoZone Information { get; set; }
    [JsonPropertyName("5")] public required SpacePublicationListTypeVideoZone Ent { get; set; }
    [JsonPropertyName("181")] public required SpacePublicationListTypeVideoZone Cinephile { get; set; }
    [JsonPropertyName("177")] public required SpacePublicationListTypeVideoZone Documentary { get; set; }
    [JsonPropertyName("23")] public required SpacePublicationListTypeVideoZone Movie { get; set; }
    [JsonPropertyName("11")] public required SpacePublicationListTypeVideoZone Tv { get; set; }
}