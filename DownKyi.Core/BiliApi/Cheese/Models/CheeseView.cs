using System.Text.Json.Serialization;
using DownKyi.Core.BiliApi.Models;

namespace DownKyi.Core.BiliApi.Cheese.Models;

// https://api.bilibili.com/pugv/view/web/season
public class CheeseViewOrigin : BaseModel
{
    //[JsonPropertyName("code")]
    //public int Code { get; set; }
    //[JsonPropertyName("message")]
    //public required stringMessage { get; set; }
    [JsonPropertyName("data")] public CheeseView Data { get; set; }
}

public class CheeseView : BaseModel
{
    // active_market
    // activity_list
    [JsonPropertyName("brief")] public CheeseBrief Brief { get; set; }

    // cooperation
    // coupon
    // course_content
    // courses
    [JsonPropertyName("cover")] public required string Cover { get; set; }

    // ep_catalogue
    // ep_count
    // episode_page
    // episode_sort
    // episode_tag
    [JsonPropertyName("episodes")] public required List<CheeseEpisode> Episodes { get; set; }

    // faq
    // faq1
    // live_ep_count
    // opened_ep_count
    // payment
    // previewed_purchase_note
    // purchase_format_note
    // purchase_note
    // purchase_protocol
    // recommend_seasons 推荐课程
    // release_bottom_info
    // release_info
    // release_info2
    // release_status
    [JsonPropertyName("season_id")] public long SeasonId { get; set; }

    [JsonPropertyName("share_url")] public required string ShareUrl { get; set; }

    // short_link
    [JsonPropertyName("stat")] public CheeseStat Stat { get; set; }

    // status
    [JsonPropertyName("subtitle")] public required string Subtitle { get; set; }
    [JsonPropertyName("title")] public required string Title { get; set; }

    [JsonPropertyName("up_info")] public CheeseUpInfo UpInfo { get; set; }
    // update_status
    // user_status
}