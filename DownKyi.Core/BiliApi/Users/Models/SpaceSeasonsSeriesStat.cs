using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceSeasonsSeriesStat : BaseModel
{
    [JsonPropertyName("view")] public long View { get; set; }
}