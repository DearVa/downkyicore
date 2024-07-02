using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/space/bangumi/follow/list?vmid={mid}&type={type:D}&pn={pn}&ps={ps}
public class BangumiFollowOrigin : BaseModel
{
    [JsonPropertyName("data")] public required BangumiFollowData Data { get; set; }
}

public class BangumiFollowData : BaseModel
{
    [JsonPropertyName("list")] public required List<BangumiFollow> List { get; set; }
    [JsonPropertyName("pn")] public int Pn { get; set; }
    [JsonPropertyName("ps")] public int Ps { get; set; }
    [JsonPropertyName("total")] public int Total { get; set; }
}