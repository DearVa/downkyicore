using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/web-interface/nav

public class UserInfoForNavigationOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    [JsonPropertyName("data")] public required UserInfoForNavigation Data { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
}

public class UserInfoForNavigation : BaseModel
{
    //public int allowance_count { get; set; }
    //public int answer_status { get; set; }
    //public int email_verified { get; set; }
    [JsonPropertyName("face")] public string? Face { get; set; }

    //public bool has_shop { get; set; }
    [JsonPropertyName("isLogin")] public bool IsLogin { get; set; }

    //public NavDataLevelInfo level_info { get; set; }
    [JsonPropertyName("mid")] public long Mid { get; set; }

    //public int mobile_verified { get; set; }
    [JsonPropertyName("money")] public float Money { get; set; }

    //public int moral { get; set; }
    //public NavDataOfficial official { get; set; }
    //public NavDataOfficialVerify officialVerify { get; set; }
    //public NavDataPendant pendant { get; set; }
    //public int scores { get; set; }
    //public required string shop_url { get; set; }
    [JsonPropertyName("uname")] public string? Name { get; set; }

    //public long vipDueDate { get; set; }
    [JsonPropertyName("vipStatus")] public int VipStatus { get; set; }

    //public int vipType { get; set; }
    //public int vip_avatar_subscript { get; set; }
    //public NavDataVipLabel vip_label { get; set; }
    //public required string vip_nickname_color { get; set; }
    //public int vip_pay_type { get; set; }
    //public int vip_theme_type { get; set; }
    [JsonPropertyName("wallet")] public UserInfoWallet? Wallet { get; set; }

    [JsonPropertyName("wbi_img")] public Wbi? Wbi { get; set; }
}

//public class NavDataLevelInfo
//{
//    public int current_exp { get; set; }
//    public int current_level { get; set; }
//    public int current_min { get; set; }
//    //public int next_exp { get; set; } // 当等级为6时，next_exp为string类型，值为"--"
//}

//public class NavDataOfficial
//{
//    public required string desc { get; set; }
//    public int role { get; set; }
//    public required string title { get; set; }
//    public int type { get; set; }
//}

//public class NavDataOfficialVerify
//{
//    public required string desc { get; set; }
//    public int type { get; set; }
//}

//public class NavDataPendant
//{
//    public int expire { get; set; }
//    public required string image { get; set; }
//    public required string image_enhance { get; set; }
//    public required string name { get; set; }
//    public int pid { get; set; }
//}

//public class NavDataVipLabel
//{
//    public required string label_theme { get; set; }
//    public required string path { get; set; }
//    public required string text { get; set; }
//}

public class UserInfoWallet : BaseModel
{
    [JsonPropertyName("bcoin_balance")] public float BcoinBalance { get; set; }
    [JsonPropertyName("coupon_balance")] public float CouponBalance { get; set; }
    [JsonPropertyName("coupon_due_time")] public long CouponDueTime { get; set; }
    [JsonPropertyName("mid")] public long Mid { get; set; }
}

public class Wbi
{
    [JsonPropertyName("img_url")] public string? ImgUrl { get; set; }
    [JsonPropertyName("sub_url")] public string? SubUrl { get; set; }
}