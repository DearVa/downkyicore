using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/pugv/app/web/season/page?mid={mid}&pn={pn}&ps={ps}
public class SpaceCheeseOrigin : BaseModel
{
    [JsonPropertyName("data")] public required SpaceCheeseData Data { get; set; }
}

public class SpaceCheeseData : BaseModel
{
    [JsonPropertyName("items")] public required List<SpaceCheese> Items { get; set; }
    [JsonPropertyName("page")] public required SpaceCheesePage Page { get; set; }
}