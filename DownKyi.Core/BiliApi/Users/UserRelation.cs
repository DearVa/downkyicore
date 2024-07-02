using DownKyi.Core.BiliApi.Users.Models;

namespace DownKyi.Core.BiliApi.Users;

/// <summary>
///     用户关系相关
/// </summary>
public static class UserRelation
{
    /// <summary>
    ///     查询用户粉丝明细
    /// </summary>
    /// <param name="mid">目标用户UID</param>
    /// <param name="pn">页码</param>
    /// <param name="ps">每页项数</param>
    /// <returns></returns>
    public async static Task<RelationFollow> GetFollowers(long mid, int pn, int ps)
    {
        var url = $"https://api.bilibili.com/x/relation/followers?vmid={mid}&pn={pn}&ps={ps}";
        const string referer = "https://www.bilibili.com";
        var relationFollower = await WebClient.RequestWebAsync<RelationFollowOrigin>(url, referer);
        return relationFollower.Data;
    }

    /// <summary>
    ///     查询用户所有的粉丝明细
    /// </summary>
    /// <param name="mid">目标用户UID</param>
    /// <returns></returns>
    public async static Task<List<RelationFollowInfo>> GetAllFollowers(long mid)
    {
        var result = new List<RelationFollowInfo>();

        var i = 0;
        while (true)
        {
            i++;
            var ps = 50;

            var data = await GetFollowers(mid, i, ps);
            if (data?.List == null || data.List.Count == 0)
            {
                break;
            }

            result.AddRange(data.List);
        }

        return result;
    }

    /// <summary>
    ///     查询用户关注明细
    /// </summary>
    /// <param name="mid">目标用户UID</param>
    /// <param name="pn">页码</param>
    /// <param name="ps">每页项数</param>
    /// <param name="order">排序方式</param>
    /// <returns></returns>
    public async static Task<RelationFollow> GetFollowings(
        long mid,
        int pn,
        int ps,
        FollowingOrder order = FollowingOrder.DEFAULT)
    {
        var orderType = "";
        if (order == FollowingOrder.ATTENTION)
        {
            orderType = "attention";
        }

        var url = $"https://api.bilibili.com/x/relation/followings?vmid={mid}&pn={pn}&ps={ps}&order_type={orderType}";
        const string referer = "https://www.bilibili.com";
        var relationFollower = await WebClient.RequestWebAsync<RelationFollowOrigin>(url, referer);
        return relationFollower.Data;
    }

    /// <summary>
    ///     查询用户所有的关注明细
    /// </summary>
    /// <param name="mid">目标用户UID</param>
    /// <param name="order">排序方式</param>
    /// <returns></returns>
    public async static Task<List<RelationFollowInfo>> GetAllFollowings(long mid, FollowingOrder order = FollowingOrder.DEFAULT)
    {
        var result = new List<RelationFollowInfo>();

        var i = 0;
        while (true)
        {
            i++;
            var ps = 50;

            var data = await GetFollowings(mid, i, ps, order);
            if (data == null || data.List == null || data.List.Count == 0)
            {
                break;
            }

            result.AddRange(data.List);
        }

        return result;
    }

    /// <summary>
    ///     查询悄悄关注明细
    /// </summary>
    /// <param name="pn">页码</param>
    /// <param name="ps">每页项数</param>
    /// <returns></returns>
    public async static Task<List<RelationFollowInfo>> GetWhispers(int pn, int ps)
    {
        var url = $"https://api.bilibili.com/x/relation/whispers?pn={pn}&ps={ps}";
        const string referer = "https://www.bilibili.com";
        var relationWhisper = await WebClient.RequestWebAsync<RelationWhisper>(url, referer);
        return relationWhisper.Data.List;
    }

    /// <summary>
    ///     查询黑名单明细
    /// </summary>
    /// <param name="pn">页码</param>
    /// <param name="ps">每页项数</param>
    /// <returns></returns>
    public async static Task<List<RelationFollowInfo>> GetBlacks(int pn, int ps)
    {
        var url = $"https://api.bilibili.com/x/relation/blacks?pn={pn}&ps={ps}";
        const string referer = "https://www.bilibili.com";
        var relationBlack = await WebClient.RequestWebAsync<RelationBlack>(url, referer);
        return relationBlack.Data;
    }

    #region 关注分组相关，只能查询当前登录账户的信息

    /// <summary>
    ///     查询关注分组列表
    /// </summary>
    /// <returns></returns>
    public async static Task<List<FollowingGroup>?> GetFollowingGroup()
    {
        var url = "https://api.bilibili.com/x/relation/tags";
        const string referer = "https://www.bilibili.com";
        var followingGroup = await WebClient.RequestWebAsync<FollowingGroupOrigin>(url, referer);
        return followingGroup.Data;
    }

    /// <summary>
    ///     查询关注分组明细
    /// </summary>
    /// <param name="tagId">分组ID</param>
    /// <param name="pn">页数</param>
    /// <param name="ps">每页项数</param>
    /// <param name="order">排序方式</param>
    /// <returns></returns>
    public async static Task<List<RelationFollowInfo>?> GetFollowingGroupContent(
        long tagId,
        int pn,
        int ps,
        FollowingOrder order = FollowingOrder.DEFAULT)
    {
        var orderType = "";
        if (order == FollowingOrder.ATTENTION)
        {
            orderType = "attention";
        }

        var url = $"https://api.bilibili.com/x/relation/tag?tagid={tagId}&pn={pn}&ps={ps}&order_type={orderType}";
        const string referer = "https://www.bilibili.com";
        var content = await WebClient.RequestWebAsync<FollowingGroupContent>(url, referer);
        return content.Data;
    }

    /// <summary>
    ///     查询所有的关注分组明细
    /// </summary>
    /// <param name="tagId">分组ID</param>
    /// <param name="order">排序方式</param>
    /// <returns></returns>
    public async static Task<List<RelationFollowInfo>> GetAllFollowingGroupContent(
        int tagId,
        FollowingOrder order = FollowingOrder.DEFAULT)
    {
        var result = new List<RelationFollowInfo>();

        var i = 0;
        while (true)
        {
            i++;
            var ps = 50;

            var data = await GetFollowingGroupContent(tagId, i, ps, order);
            if (data == null || data.Count == 0)
            {
                break;
            }

            result.AddRange(data);
        }

        return result;
    }

    #endregion

}