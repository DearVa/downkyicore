using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class SpaceSettingsToutu : BaseModel
{
    [JsonPropertyName("sid")] public int Sid { get; set; }
    [JsonPropertyName("expire")] public long Expire { get; set; }
    [JsonPropertyName("s_img")] public required string Simg { get; set; } // 完整url为http://i0.hdslb.com/+相对路径
    [JsonPropertyName("l_img")] public required string Limg { get; set; } // 完整url为http://i0.hdslb.com/+相对路径
    [JsonPropertyName("android_img")] public required string AndroidImg { get; set; }
    [JsonPropertyName("iphone_img")] public required string IphoneImg { get; set; }
    [JsonPropertyName("ipad_img")] public required string IpadImg { get; set; }
    [JsonPropertyName("thumbnail_img")] public required string ThumbnailImg { get; set; }
    [JsonPropertyName("platform")] public int Platform { get; set; }
}