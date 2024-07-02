using DownKyi.Core.Settings;

namespace DownKyi.Models;

public class RepeatDownloadStrategyDisplay
{
    public required string Name { get; set; }
    public RepeatDownloadStrategy RepeatDownloadStrategy { get; set; }
}