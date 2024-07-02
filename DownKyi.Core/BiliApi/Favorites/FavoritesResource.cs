using DownKyi.Core.BiliApi.Favorites.Models;

namespace DownKyi.Core.BiliApi.Favorites;

public static class FavoritesResource
{
    /// <summary>
    ///     获取收藏夹内容明细列表
    /// </summary>
    /// <param name="mediaId">收藏夹ID</param>
    /// <param name="pn">页码</param>
    /// <param name="ps">每页项数</param>
    /// <returns></returns>
    public async static Task<List<FavoritesMedia>?> GetFavoritesMedia(long mediaId, int pn, int ps)
    {
        var url =
            $"https://api.bilibili.com/x/v3/fav/resource/list?media_id={mediaId}&pn={pn}&ps={ps}&platform=web";
        const string referer = "https://www.bilibili.com";

        try
        {
            var resource = await WebClient.RequestWebAsync<FavoritesMediaResourceOrigin>(url, referer);
            return resource.Data.Medias;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("GetFavoritesMedia()发生异常: {0}", e);
            return null;
        }
    }

    /// <summary>
    ///     获取收藏夹内容明细列表（全部）
    /// </summary>
    /// <param name="mediaId">收藏夹ID</param>
    /// <returns></returns>
    public async static Task<List<FavoritesMedia>> GetAllFavoritesMedia(long mediaId)
    {
        var result = new List<FavoritesMedia>();

        var i = 0;
        while (true)
        {
            i++;
            var ps = 20;

            var data = await GetFavoritesMedia(mediaId, i, ps);
            if (data == null || data.Count == 0)
            {
                break;
            }

            result.AddRange(data);
        }

        return result;
    }

    /// <summary>
    ///     获取收藏夹全部内容id
    /// </summary>
    /// <param name="mediaId"></param>
    /// <returns></returns>
    public async static Task<List<FavoritesMediaId>?> GetFavoritesMediaId(long mediaId)
    {
        var url = $"https://api.bilibili.com/x/v3/fav/resource/ids?media_id={mediaId}";
        const string referer = "https://www.bilibili.com";

        try
        {
            var media = await WebClient.RequestWebAsync<FavoritesMediaIdOrigin>(url, referer);
            return media.Data;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("GetFavoritesMediaId()发生异常: {0}", e);
            return null;
        }
    }
}