﻿using Avalonia.Media.Imaging;
using DownKyi.Core.BiliApi.BiliUtils;
using DownKyi.Utils;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;

namespace DownKyi.ViewModels.PageViewModels;

public class ChannelMedia : BindableBase
{
    protected readonly IEventAggregator eventAggregator;

    public ChannelMedia(IEventAggregator eventAggregator)
    {
        this.eventAggregator = eventAggregator;
    }

    public long Avid { get; set; }
    public required string Bvid { get; set; }

    #region 页面属性申明

    private bool isSelected;

    public bool IsSelected
    {
        get => isSelected;
        set => SetProperty(ref isSelected, value);
    }

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

    private string duration;

    public required string Duration
    {
        get => duration;
        set => SetProperty(ref duration, value);
    }

    private string playNumber;

    public required string PlayNumber
    {
        get => playNumber;
        set => SetProperty(ref playNumber, value);
    }

    private string createTime;

    public required string CreateTime
    {
        get => createTime;
        set => SetProperty(ref createTime, value);
    }

    #endregion

    #region 命令申明

    // 视频标题点击事件
    private DelegateCommand<object> titleCommand;

    public DelegateCommand<object> TitleCommand =>
        titleCommand ?? (titleCommand = new DelegateCommand<object>(ExecuteTitleCommand));

    /// <summary>
    /// 视频标题点击事件
    /// </summary>
    /// <param name="parameter"></param>
    private void ExecuteTitleCommand(object parameter)
    {
        if (!(parameter is string tag))
        {
            return;
        }

        NavigateToView.NavigationView(eventAggregator, ViewVideoDetailViewModel.Tag, tag,
            $"{ParseEntrance.VideoUrl}{Bvid}");
        //string url = "https://www.bilibili.com/video/" + tag;
        //System.Diagnostics.Process.Start(url);
    }

    #endregion
}