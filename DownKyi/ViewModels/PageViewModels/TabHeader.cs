using DownKyi.Images;
using Prism.Mvvm;

namespace DownKyi.ViewModels.PageViewModels;

public class TabHeader : BindableBase
{
    private long id;

    public long Id
    {
        get => id;
        set => SetProperty(ref id, value);
    }

    private VectorImage image;

    public VectorImage Image
    {
        get => image;
        set => SetProperty(ref image, value);
    }

    private string title;

    public required string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    private string subTitle;

    public required string SubTitle
    {
        get => subTitle;
        set => SetProperty(ref subTitle, value);
    }
}