using Avalonia.Media.Imaging;
using DownKyi.Images;
using DownKyi.Utils;
using Prism.Mvvm;

namespace DownKyi.ViewModels.PageViewModels;

public class Favorites : BindableBase
{
    public required string CoverUrl { get; set; }
    public long UpperMid { get; set; }

    private Bitmap cover;

    public Bitmap Cover
    {
        get => cover;
        set => SetProperty(ref cover, value);
    }

    private string title;

    public required string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    private string createTime;

    public required string CreateTime
    {
        get => createTime;
        set => SetProperty(ref createTime, value);
    }

    private string playNumber;

    public required string PlayNumber
    {
        get => playNumber;
        set => SetProperty(ref playNumber, value);
    }

    private string likeNumber;

    public required string LikeNumber
    {
        get => likeNumber;
        set => SetProperty(ref likeNumber, value);
    }

    private string favoriteNumber;

    public required string FavoriteNumber
    {
        get => favoriteNumber;
        set => SetProperty(ref favoriteNumber, value);
    }

    private string shareNumber;

    public required string ShareNumber
    {
        get => shareNumber;
        set => SetProperty(ref shareNumber, value);
    }

    private VectorImage play;

    public VectorImage Play
    {
        get => play;
        set => SetProperty(ref play, value);
    }

    private VectorImage like;

    public VectorImage Like
    {
        get => like;
        set => SetProperty(ref like, value);
    }

    private VectorImage favorite;

    public VectorImage Favorite
    {
        get => favorite;
        set => SetProperty(ref favorite, value);
    }

    private VectorImage share;

    public VectorImage Share
    {
        get => share;
        set => SetProperty(ref share, value);
    }

    private string description;

    public required string Description
    {
        get => description;
        set => SetProperty(ref description, value);
    }

    private int mediaCount;

    public int MediaCount
    {
        get => mediaCount;
        set => SetProperty(ref mediaCount, value);
    }

    private string upName;

    public required string UpName
    {
        get => upName;
        set => SetProperty(ref upName, value);
    }

    private Bitmap upHeader;

    public Bitmap UpHeader
    {
        get => upHeader;
        set => SetProperty(ref upHeader, value);
    }

    public Favorites()
    {
        #region 属性初始化

        Play = NormalIcon.Instance().Play;
        Play.Fill = DictionaryResource.GetColor("ColorTextGrey2");
        
        Like = NormalIcon.Instance().Like;
        Like.Fill = DictionaryResource.GetColor("ColorTextGrey2");
        
        Favorite = NormalIcon.Instance().Favorite;
        Favorite.Fill = DictionaryResource.GetColor("ColorTextGrey2");
        
        Share = NormalIcon.Instance().Share;
        Share.Fill = DictionaryResource.GetColor("ColorTextGrey2");

        #endregion
    }
}