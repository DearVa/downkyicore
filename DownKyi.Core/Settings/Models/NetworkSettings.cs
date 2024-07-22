using System.Net;
using System.Text;

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
}