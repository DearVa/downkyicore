using System.Text.Json;
using DownKyi.Core.Settings.Models;
using DownKyi.Core.Storage;

namespace DownKyi.Core.Settings;

public static class SettingsManager
{
#if DEBUG
    // 设置的配置文件
    private readonly static string SettingsFilePath = StorageManager.GetSettings() + "_debug.json";
#else
    // 设置的配置文件
    private readonly static string SettingsFilePath = Storage.StorageManager.GetSettings();
#endif

    private static AppSettings? appSettingsCache;
    private static readonly object SyncLock = new();

    public static AppSettings AppSettings
    {
        get
        {
            lock (SyncLock)
            {
                if (appSettingsCache != null) return appSettingsCache;
                try
                {
                    using var fs = File.OpenRead(SettingsFilePath);
                    return appSettingsCache = JsonSerializer.Deserialize<AppSettings>(fs) ?? new AppSettings();
                }
                catch
                {
                    return new AppSettings();
                }
            }
        }
        set
        {
            lock (SyncLock)
            {
                using var fs = new FileStream(SettingsFilePath, FileMode.Create, FileAccess.Write);
                JsonSerializer.SerializeAsync(fs, value);
                appSettingsCache = value;
            }
        }
    }
}