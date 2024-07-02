using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/space/upstat?mid={mid}
public class UpStatOrigin : BaseModel
{
    [JsonPropertyName("data")] public required UpStat Data { get; set; }
}

public class UpStat : BaseModel
{
    [JsonPropertyName("archive")] public required UpStatArchive Archive { get; set; }
    [JsonPropertyName("article")] public required UpStatArchive Article { get; set; }
    [JsonPropertyName("likes")] public long Likes { get; set; }
}

public class UpStatArchive : BaseModel
{
    [JsonPropertyName("view")] public long View { get; set; } // 视频/文章播放量
}