using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Cheese.Models;

// https://api.bilibili.com/pugv/view/web/ep/list
public class CheeseEpisodeListOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required stringMessage { get; set; }
    [JsonPropertyName("data")] public required CheeseEpisodeList Data { get; set; }
}

public class CheeseEpisodeList : BaseModel
{
    [JsonPropertyName("items")] public required List<CheeseEpisode> Items { get; set; }
    [JsonPropertyName("page")] public required CheeseEpisodePage Page { get; set; }
}