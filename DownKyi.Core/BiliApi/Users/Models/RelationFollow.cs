using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/relation/followers?vmid={mid}&pn={pn}&ps={ps}
// https://api.bilibili.com/x/relation/followings?vmid={mid}&pn={pn}&ps={ps}&order_type={orderType}
public class RelationFollowOrigin : BaseModel
{
    [JsonPropertyName("data")] public required RelationFollow Data { get; set; }
}

public class RelationFollow : BaseModel
{
    [JsonPropertyName("list")] public List<RelationFollowInfo>? List { get; set; }

    //[JsonPropertyName("re_version")]
    //public long reVersion { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
}