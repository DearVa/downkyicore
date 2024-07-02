using DownKyi.Core.Settings;

namespace DownKyi.Models;

public class OrderFormatDisplay
{
    public required string Name { get; set; }
    public OrderFormat OrderFormat { get; set; }
}