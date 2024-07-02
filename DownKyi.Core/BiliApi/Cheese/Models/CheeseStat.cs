using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Cheese.Models;

public class CheeseStat : BaseModel
{
    [JsonPropertyName("play")] public long Play { get; set; }
    [JsonPropertyName("play_desc")] public required string PlayDesc { get; set; }
}