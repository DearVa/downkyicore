using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://space.bilibili.com/ajax/settings/getSettings?mid={mid}
public class SpaceSettingsOrigin : BaseModel
{
    [JsonPropertyName("status")] public bool Status { get; set; }
    [JsonPropertyName("data")] public required SpaceSettings Data { get; set; }
}

public class SpaceSettings : BaseModel
{
    // ...
    [JsonPropertyName("toutu")] public required SpaceSettingsToutu Toutu { get; set; }
}