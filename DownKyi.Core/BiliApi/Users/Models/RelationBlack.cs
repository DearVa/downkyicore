using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/relation/blacks?pn={pn}&ps={ps}
public class RelationBlack : BaseModel
{
    [JsonPropertyName("data")] public required List<RelationFollowInfo> Data { get; set; }
}