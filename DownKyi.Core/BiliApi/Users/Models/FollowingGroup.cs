using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/relation/tags
public class FollowingGroupOrigin : BaseModel
{
    [JsonPropertyName("data")] public List<FollowingGroup>? Data { get; set; }
}

public class FollowingGroup : BaseModel
{
    [JsonPropertyName("tagid")] public int TagId { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("count")] public int Count { get; set; }
    [JsonPropertyName("tip")] public required string Tip { get; set; }
}