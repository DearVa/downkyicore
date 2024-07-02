using System.Net;
using System.Text.Json;

namespace DownKyi.Core.Utils;

public static class ObjectHelper
{
    /// <summary>
    ///     解析二维码登录返回的url，用于设置cookie
    /// </summary>
    /// <param name="url"></param>
    /// <returns></returns>
    public static CookieContainer ParseCookie(string url)
    {
        var cookieContainer = new CookieContainer();

        if (string.IsNullOrWhiteSpace(url))
        {
            return cookieContainer;
        }

        var strList = url.Split('?');
        if (strList.Length < 2)
        {
            return cookieContainer;
        }

        var strList2 = strList[1].Split('&');
        if (strList2.Length == 0)
        {
            return cookieContainer;
        }

        // 获取expires
        var expires = strList2.FirstOrDefault(it => it.Contains("expires", StringComparison.OrdinalIgnoreCase))?.Split('=')[1];
        DateTime dateTime;
        if (expires == null)
        {
            dateTime = DateTime.MaxValue;
        }
        else
        {
            dateTime = DateTime.Now.AddSeconds(int.Parse(expires));
        }

        foreach (var item in strList2)
        {
            var strList3 = item.Split('=');
            if (strList3.Length < 2)
            {
                continue;
            }

            var name = strList3[0];
            var value = strList3[1];

            // 不需要
            if (name.Equals("expires", StringComparison.OrdinalIgnoreCase) || name.Equals("gourl", StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            // 添加cookie
            cookieContainer.Add(new Cookie(name, value.Replace(",", "%2c"), "/", ".bilibili.com") { Expires = dateTime });
        }

        return cookieContainer;
    }

    /// <summary>
    ///     写入cookies到磁盘
    /// </summary>
    /// <param name="file"></param>
    /// <param name="cookieJar"></param>
    /// <returns></returns>
    public static bool WriteCookiesToDisk(string file, CookieContainer cookieJar)
    {
        return WriteObjectToDisk(file, cookieJar);
    }

    /// <summary>
    ///     从磁盘读取cookie
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public static CookieContainer ReadCookiesFromDisk(string file)
    {
        return ReadObjectFromDisk<CookieContainer>(file);
    }

    /// <summary>
    ///     写入序列化对象到磁盘
    /// </summary>
    /// <param name="file"></param>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static bool WriteObjectToDisk<T>(string file, T obj)
    {
        try
        {
            using Stream stream = File.Create(file);
            Console.Error.WriteLine("Writing object to disk... ");
            JsonSerializer.Serialize(stream, obj);

            Console.Error.WriteLine("Done.");
            return true;
        }
        catch (IOException e)
        {
            Console.Error.WriteLine("WriteObjectToDisk()发生IO异常: {0}", e);
                        return false;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("WriteObjectToDisk()发生异常: {0}", e);
                        return false;
        }
    }

    /// <summary>
    ///     从磁盘读取序列化对象
    /// </summary>
    /// <param name="file"></param>
    /// <returns></returns>
    public static T? ReadObjectFromDisk<T>(string file) where T : class
    {
        try
        {
            using Stream stream = File.Open(file, FileMode.Open);
            Console.Error.WriteLine("Reading object from disk... ");
            return JsonSerializer.Deserialize<T>(stream);
        }
        catch (IOException e)
        {
            Console.Error.WriteLine("ReadObjectFromDisk()发生IO异常: {0}", e);
                        return null;
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("ReadObjectFromDisk()发生异常: {0}", e);
                        return null;
        }
    }
}