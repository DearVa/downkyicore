﻿using System.Collections.Generic;
using Prism.Mvvm;

namespace DownKyi.ViewModels.PageViewModels;

public class VideoSection : BindableBase
{
    public long Id { get; set; }

    private string title;

    public required string Title
    {
        get => title;
        set => SetProperty(ref title, value);
    }

    private bool isSelected;

    public bool IsSelected
    {
        get => isSelected;
        set => SetProperty(ref isSelected, value);
    }

    private List<VideoPage> videoPages;

    public required List<VideoPage> VideoPages
    {
        get => videoPages;
        set => SetProperty(ref videoPages, value);
    }
}