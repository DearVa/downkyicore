using Avalonia.Media.Imaging;
using Prism.Mvvm;

namespace DownKyi.ViewModels.PageViewModels;

public class VideoInfoView : BindableBase
{
    public required string CoverUrl { get; set; }
    public long UpperMid { get; set; }
    public int TypeId { get; set; }

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

    private string videoZone;

    public required string VideoZone
    {
        get => videoZone;
        set => SetProperty(ref videoZone, value);
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

    private string danmakuNumber;

    public required string DanmakuNumber
    {
        get => danmakuNumber;
        set => SetProperty(ref danmakuNumber, value);
    }

    private string likeNumber;

    public required string LikeNumber
    {
        get => likeNumber;
        set => SetProperty(ref likeNumber, value);
    }

    private string coinNumber;

    public required string CoinNumber
    {
        get => coinNumber;
        set => SetProperty(ref coinNumber, value);
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

    private string replyNumber;

    public required string ReplyNumber
    {
        get => replyNumber;
        set => SetProperty(ref replyNumber, value);
    }

    private string description;

    public required string Description
    {
        get => description;
        set => SetProperty(ref description, value);
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
}