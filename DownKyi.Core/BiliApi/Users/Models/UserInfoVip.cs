using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

public class UserInfoVip : BaseModel
{
    [JsonPropertyName("type")] public int Type { get; set; }
    [JsonPropertyName("status")] public int Status { get; set; }

    [JsonPropertyName("due_date")] public long DueDate { get; set; }

    // vip_pay_type
    // theme_type
    [JsonPropertyName("label")] public UserInfoVipLabel? Label { get; set; }
    [JsonPropertyName("avatar_subscript")] public int AvatarSubscript { get; set; }

    [JsonPropertyName("nickname_color")] public required string NicknameColor { get; set; }

    // role
    [JsonPropertyName("avatar_subscript_url")] public required string AvatarSubscriptUrl { get; set; }
}

public class UserInfoVipLabel : BaseModel
{
    // path
    [JsonPropertyName("text")] public required string Text { get; set; }
    [JsonPropertyName("label_theme")] public required string LabelTheme { get; set; }

    [JsonPropertyName("text_color")] public required string TextColor { get; set; }
    // bg_style
    // bg_color
    // border_color
}