using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceSeasonsSeriesPage : BaseModel
{
    [JsonPropertyName("page_num")] public int PageNum;
    [JsonPropertyName("page_size")] public int PageSize;
    [JsonPropertyName("total")] public int Total;
}