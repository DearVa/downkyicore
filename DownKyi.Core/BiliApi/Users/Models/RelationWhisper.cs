using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/relation/whispers?pn={pn}&ps={ps}
public class RelationWhisper : BaseModel
{
    [JsonPropertyName("data")] public required RelationWhisperData Data { get; set; }
}

public class RelationWhisperData : BaseModel
{
    [JsonPropertyName("list")] public required List<RelationFollowInfo> List { get; set; }
    // re_version
}