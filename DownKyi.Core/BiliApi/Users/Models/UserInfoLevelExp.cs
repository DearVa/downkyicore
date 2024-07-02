using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class UserInfoLevelExp : BaseModel
{
    [JsonPropertyName("current_level")] public int CurrentLevel { get; set; }
    [JsonPropertyName("current_min")] public int CurrentMin { get; set; }
    [JsonPropertyName("current_exp")] public int CurrentExp { get; set; }
    [JsonPropertyName("next_exp")] public int NextExp { get; set; }
}