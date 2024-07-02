using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/relation/tag?tagid={tagId}&pn={pn}&ps={ps}&order_type={orderType}
public class FollowingGroupContent : BaseModel
{
    [JsonPropertyName("data")] public List<RelationFollowInfo>? Data { get; set; }
}