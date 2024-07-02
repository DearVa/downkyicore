using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/space/channel/video?mid={mid}&cid={cid}&pn={pn}&ps={ps}
public class SpaceChannelVideoOrigin : BaseModel
{
    [JsonPropertyName("data")] public required SpaceChannelVideo Data { get; set; }
}

public class SpaceChannelVideo : BaseModel
{
    // episodic_button
    [JsonPropertyName("list")] public required SpaceChannelVideoList List { get; set; }
    [JsonPropertyName("page")] public required SpaceChannelVideoPage Page { get; set; }
}