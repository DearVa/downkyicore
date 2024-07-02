using DownKyi.Core.FileName;

namespace DownKyi.Core.Settings.Models;

/// <summary>
///     视频
/// </summary>
public class VideoSettings
{
    /// <summary>
    /// AVC or HEVC
    /// </summary>
    public int VideoCodecs { get; set; } = 7;
    
    /// <summary>
    /// 设置优先下载画质
    /// </summary>
    public int Quality { get; set; } = 120;
    
    /// <summary>
    /// 音质
    /// </summary>
    public int AudioQuality { get; set; } = 30280;
    
    /// <summary>
    /// 设置首选视频解析方式
    /// </summary>
    public int VideoParseType { get; set; } = 1;
    
    /// <summary>
    /// 是否将flv转为mp4
    /// </summary>
    public AllowStatus IsTranscodingFlvToMp4 { get; set; } = AllowStatus.No;
    
    /// <summary>
    /// 是否将aac转为mp3
    /// </summary>
    public AllowStatus IsTranscodingAacToMp3 { get; set; } = AllowStatus.No;
}