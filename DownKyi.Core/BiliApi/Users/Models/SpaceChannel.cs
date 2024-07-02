using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/space/channel/list?mid={mid}
public class SpaceChannelOrigin : BaseModel
{
    [JsonPropertyName("data")]
    public required SpaceChannel Data { get; set; }
}

public class SpaceChannel : BaseModel
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("list")]
    public required List<SpaceChannelList> List { get; set; }
}