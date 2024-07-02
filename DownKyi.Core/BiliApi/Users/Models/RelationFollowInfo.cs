using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class RelationFollowInfo : BaseModel
{
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("attribute")] public int Attribute { get; set; }
    [JsonPropertyName("mtime")] public long Mtime { get; set; }
    [JsonPropertyName("tag")] public required List<long> Tag { get; set; }

    [JsonPropertyName("special")] public int Special { get; set; }

    // contract_info
    [JsonPropertyName("uname")] public required string Name { get; set; }
    [JsonPropertyName("face")] public required string Face { get; set; }

    [JsonPropertyName("sign")] public required string Sign { get; set; }
    // face_nft
    // official_verify
    // vip
    // nft_icon
}