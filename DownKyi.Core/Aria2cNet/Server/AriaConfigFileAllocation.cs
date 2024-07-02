namespace DownKyi.Core.Aria2cNet.Server;

/// <summary>
///     文件预分配
/// </summary>
public enum AriaConfigFileAllocation
{
    None, // 没有预分配
    Prealloc, // 预分配，默认
    Falloc, // NTFS建议使用
}