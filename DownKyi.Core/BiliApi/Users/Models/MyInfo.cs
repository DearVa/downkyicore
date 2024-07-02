using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Users.Models;

// https://api.bilibili.com/x/space/myinfo
public class MyInfoOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required string Message { get; set; }
    //[JsonPropertyName("ttl")]
    //public int Ttl { get; set; }
    [JsonPropertyName("data")] public required MyInfo Data { get; set; }
}

public class MyInfo : BaseModel
{
    [JsonPropertyName("mid")] public long Mid { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("sex")] public required string Sex { get; set; }
    [JsonPropertyName("face")] public required string Face { get; set; }

    [JsonPropertyName("sign")] public required string Sign { get; set; }

    // rank
    [JsonPropertyName("level")] public int Level { get; set; }

    // jointime
    [JsonPropertyName("moral")] public int Moral { get; set; }
    [JsonPropertyName("silence")] public int Silence { get; set; }
    [JsonPropertyName("email_status")] public int EmailStatus { get; set; }
    [JsonPropertyName("tel_status")] public int TelStatus { get; set; }
    [JsonPropertyName("identification")] public int Identification { get; set; }

    [JsonPropertyName("vip")] public required UserInfoVip Vip { get; set; }

    // pendant
    // nameplate
    // official
    [JsonPropertyName("birthday")] public long Birthday { get; set; }
    [JsonPropertyName("is_tourist")] public int IsTourist { get; set; }
    [JsonPropertyName("is_fake_account")] public int IsFakeAccount { get; set; }
    [JsonPropertyName("pin_prompting")] public int PinPrompting { get; set; }

    [JsonPropertyName("is_deleted")] public int IsDeleted { get; set; }

    // in_reg_audit
    // is_rip_user
    // profession
    // face_nft
    // face_nft_new
    // is_senior_member
    [JsonPropertyName("level_exp")] public required UserInfoLevelExp LevelExp { get; set; }
    [JsonPropertyName("coins")] public float Coins { get; set; }
    [JsonPropertyName("following")] public int Following { get; set; }
    [JsonPropertyName("follower")] public int Follower { get; set; }
}