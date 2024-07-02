using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpacePublicationList : BaseModel
{
    [JsonPropertyName("tlist")] public required SpacePublicationListType Tlist { get; set; }
    [JsonPropertyName("vlist")] public List<SpacePublicationListVideo>? Vlist { get; set; }
}