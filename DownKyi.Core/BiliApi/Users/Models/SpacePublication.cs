using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/space/arc/search
public class SpacePublicationOrigin : BaseModel
{
    [JsonPropertyName("data")] public required SpacePublication Data { get; set; }
}

public class SpacePublication : BaseModel
{
    [JsonPropertyName("list")] public required SpacePublicationList List { get; set; }
    [JsonPropertyName("page")] public required SpacePublicationPage Page { get; set; }
}