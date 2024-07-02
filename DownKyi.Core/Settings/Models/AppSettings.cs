namespace DownKyi.Core.Settings.Models;

public class AppSettings
{
    public NetworkSettings Network { get; set; } = new();
    public VideoSettings Video { get; set; } = new();
    public UserInfoSettings UserInfo { get; set; } = new();
}