using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/relation/stat?vmid={mid}
public class UserRelationStatOrigin : BaseModel
{
    [JsonPropertyName("data")] public required UserRelationStat Data { get; set; }
}

public class UserRelationStat : BaseModel
{
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("following")] public long Following { get; set; } // 关注数
    [JsonPropertyName("whisper")] public long Whisper { get; set; }
    [JsonPropertyName("black")] public long Black { get; set; }
    [JsonPropertyName("follower")] public long Follower { get; set; } // 粉丝数
}