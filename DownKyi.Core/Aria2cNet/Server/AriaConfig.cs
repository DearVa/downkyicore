namespace DownKyi.Core.Aria2cNet.Server;

/// <summary>
///     Aria服务器的启动配置
/// </summary>
public class AriaConfig
{
    public int ListenPort { get; set; } // 服务器端口号，取值：1024-65535
    public required string Token { get; set; } // 连接服务器的token
    public AriaConfigLogLevel LogLevel { get; set; } = AriaConfigLogLevel.Info; // 日志等级，debug info notice warn error
    public int MaxConcurrentDownloads { get; set; } = 32; // 最大同时下载数(任务数)，取值：1-*
    public int MaxConnectionPerServer { get; set; } = 16; // 同服务器连接数，取值：1-16

    public int Split { get; set; } // 单文件最大线程数，取值：1-*

    public int MinSplitSize { get; set; } = 1; // 最小文件分片大小, 下载线程数上限取决于能分出多少片, 对于小文件重要，单位MB
    public long MaxOverallDownloadLimit { get; set; } // 下载速度限制，取值：1-*
    public long MaxDownloadLimit { get; set; } // 下载单文件速度限制，取值：1-*
    public long MaxOverallUploadLimit { get; set; } // 上传速度限制，取值：1-*
    public long MaxUploadLimit { get; set; } // 上传单文件速度限制，取值：1-*
    public bool ContinueDownload { get; set; } // 断点续传
    public AriaConfigFileAllocation FileAllocation { get; set; } = AriaConfigFileAllocation.Falloc; // 文件预分配, none prealloc

    public List<string>? Headers { get; set; }
}