using System.Net;
using DownKyi.Core.Aria2cNet.Server;

namespace DownKyi.Core.Settings.Models;

/// <summary>
///     网络
/// </summary>
public class NetworkSettings
{
    public CookieCollection? Cookies { get; set; }
    
    /// <summary>
    /// 是否开启解除地区限制
    /// </summary>
    public AllowStatus IsLiftingOfRegion { get; set; } = AllowStatus.Yes;

    /// <summary>
    /// 启用https
    /// </summary>
    public AllowStatus UseSsl { get; set; } = AllowStatus.No;

    /// <summary>
    /// UserAgent
    /// </summary>
    public string UserAgent { get; set; } =
        "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";

    /// <summary>
    /// 下载器
    /// </summary>
    public Downloader Downloader { get; set; } = Downloader.Aria;

    /// <summary>
    /// 最大同时下载数(任务数)
    /// </summary>
    public int MaxConcurrentDownloads { get; set; } = 3;

    #region built-in

    /// <summary>
    /// 单文件最大线程数
    /// </summary>
    public int Split { get; set; } = -1;

    /// <summary>
    /// HttpProxy代理
    /// </summary>
    public AllowStatus IsHttpProxy { get; set; } = AllowStatus.No;

    public string? HttpProxy { get; set; }
    public int HttpProxyListenPort { get; set; } = 0;

    #endregion

    #region Aria

    /// <summary>
    /// Aria服务器token
    /// </summary>
    public string? AriaToken { get; set; } = "downkyi";

    /// <summary>
    /// Aria服务器host
    /// </summary>
    public string? AriaHost { get; set; } = "http://localhost";

    /// <summary>
    /// Aria服务器端口号
    /// </summary>
    public int AriaListenPort { get; set; } = 6800;

    /// <summary>
    /// Aria日志等级
    /// </summary>
    public AriaConfigLogLevel AriaLogLevel { get; set; } = AriaConfigLogLevel.Info;
    
    /// <summary>
    /// Aria单文件最大线程数
    /// </summary>
    public int AriaSplit { get; set; } = 6;
    
    /// <summary>
    /// Aria下载速度限制
    /// </summary>
    public int AriaMaxOverallDownloadLimit { get; set; } = 0;
    
    /// <summary>
    /// Aria下载单文件速度限制
    /// </summary>
    public int AriaMaxDownloadLimit { get; set; } = 0;
    
    /// <summary>
    /// Aria文件预分配
    /// </summary>
    public AriaConfigFileAllocation AriaFileAllocation { get; set; } = AriaConfigFileAllocation.None;

    /// <summary>
    /// Aria HttpProxy代理
    /// </summary>
    public AllowStatus IsAriaHttpProxy { get; set; } = AllowStatus.No;
    
    public string? AriaHttpProxy { get; set; }
    
    public int AriaHttpProxyListenPort { get; set; } = 0;

    #endregion
}