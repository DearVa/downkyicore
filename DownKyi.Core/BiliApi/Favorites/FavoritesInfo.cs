using DownKyi.Core.BiliApi.Favorites.Models;

namespace DownKyi.Core.BiliApi.Favorites;

public static class FavoritesInfo
{
    /// <summary>
    ///     获取收藏夹元数据
    /// </summary>
    /// <param name="mediaId"></param>
    public async static Task<FavoritesMetaInfo> GetFavoritesInfo(long mediaId)
    {
        var url = $"https://api.bilibili.com/x/v3/fav/folder/info?media_id={mediaId}";
        const string referer = "https://www.bilibili.com";


        var info = await WebClient.RequestWebAsync<FavoritesMetaInfoOrigin>(url, referer);
        return info.Data;

    }

    /// <summary>
    ///     查询用户创建的视频收藏夹
    /// </summary>
    /// <param name="mid">目标用户UID</param>
    /// <param name="pn">页码</param>
    /// <param name="ps">每页项数</param>
    /// <returns></returns>
    public async static Task<List<FavoritesMetaInfo>> GetCreatedFavorites(long mid, int pn, int ps)
    {
        var url = $"https://api.bilibili.com/x/v3/fav/folder/created/list?up_mid={mid}&pn={pn}&ps={ps}";
        const string referer = "https://www.bilibili.com";

        var favorites = await WebClient.RequestWebAsync<FavoritesListOrigin>(url, referer);
        return favorites.Data.List;

    }

    /// <summary>
    ///     查询所有的用户创建的视频收藏夹
    /// </summary>
    /// <param name="mid">目标用户UID</param>
    /// <returns></returns>
    public async static Task<List<FavoritesMetaInfo>> GetAllCreatedFavorites(long mid)
    {
        var result = new List<FavoritesMetaInfo>();

        var i = 0;
        while (true)
        {
            i++;
            var ps = 50;

            var data = await GetCreatedFavorites(mid, i, ps);
            if (data.Count == 0)
            {
                break;
            }

            result.AddRange(data);
        }

        return result;
    }

    /// <summary>
    ///     查询用户收藏的视频收藏夹
    /// </summary>
    /// <param name="mid">目标用户UID</param>
    /// <param name="pn">页码</param>
    /// <param name="ps">每页项数</param>
    /// <returns></returns>
    public async static Task<List<FavoritesMetaInfo>> GetCollectedFavorites(long mid, int pn, int ps)
    {
        var url = $"https://api.bilibili.com/x/v3/fav/folder/collected/list?up_mid={mid}&pn={pn}&ps={ps}";
        const string referer = "https://www.bilibili.com";


        var favorites = await WebClient.RequestWebAsync<FavoritesListOrigin>(url, referer);
        return favorites.Data.List;

    }

    /// <summary>
    ///     查询所有的用户收藏的视频收藏夹
    /// </summary>
    /// <param name="mid">目标用户UID</param>
    /// <returns></returns>
    public async static Task<List<FavoritesMetaInfo>> GetAllCollectedFavorites(long mid)
    {
        var result = new List<FavoritesMetaInfo>();

        var i = 0;
        while (true)
        {
            i++;
            var ps = 50;

            var data = await GetCollectedFavorites(mid, i, ps);
            if (data.Count == 0)
            {
                break;
            }

            result.AddRange(data);
        }

        return result;
    }
}