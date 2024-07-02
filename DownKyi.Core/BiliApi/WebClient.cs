using System.Net;
using System.Text;
using System.Text.Json;
using DownKyi.Core.Settings;

namespace DownKyi.Core.BiliApi;

internal static class WebClient
{
    private readonly static HttpClient HttpClient = new(new HttpClientHandler
    {
        AutomaticDecompression = DecompressionMethods.All,
    })
    {
        Timeout = TimeSpan.FromSeconds(10),
    };

    private static string GetRandomBuvid3()
    {
        // 随机生成10位字符串
        const string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        var result = new StringBuilder();
        for (var i = 0; i < 10; i++)
        {
            result.Append(str[random.Next(str.Length)]);
        }

        return result.ToString();
    }

    /// <summary>
    ///     发送get或post请求
    /// </summary>
    /// <param name="url"></param>
    /// <param name="referer"></param>
    /// <param name="method"></param>
    /// <param name="parameters"></param>
    /// <param name="retry"></param>
    /// <param name="needRandomBvuid3"></param>
    /// <returns></returns>
    public async static Task<T> RequestWebAsync<T>(
        string url,
        string? referer = null,
        string method = "GET",
        Dictionary<string, string>? parameters = null,
        int retry = 3,
        bool needRandomBvuid3 = false)
    {
        // 重试次数
        if (retry <= 0)
        {
            throw new Exception("RequestWebAsync()重试次数已用完");
        }

        // post请求，发送参数
        if (method == "POST" && parameters != null)
        {
            var builder = new StringBuilder();
            var i = 0;
            foreach (var item in parameters)
            {
                if (i > 0)
                {
                    builder.Append('&');
                }

                builder.Append($"{item.Key}={item.Value}");
                i++;
            }

            url += "?" + builder;
        }

        try
        {
            var request = new HttpRequestMessage
            {
                RequestUri = new Uri(url),
                Method = new HttpMethod(method),
                Headers =
                {
                    { "User-Agent", SettingsManager.AppSettings.Network.UserAgent },
                    { "accept-language", "zh-CN,zh;q=0.9,en-US;q=0.8,en;q=0.7" },
                    { "accept-encoding", "gzip, deflate, br" },
                },
            };

            // referer
            if (referer != null)
            {
                request.Headers.Add("Referer", referer);
            }

            // 构造cookie
            if (!url.Contains("getLogin"))
            {
                request.Headers.Add("origin", "https://m.bilibili.com");

                var cookies = SettingsManager.AppSettings.Network.Cookies;
                if (cookies != null)
                {
                    request.Headers.Add("Cookie", string.Join(';', cookies));
                }
                else
                {
                    request.Headers.Add("Cookie", new Cookie("buvid3", GetRandomBuvid3(), "/", ".bilibili.com").ToString());
                }
            }

            using var response = await HttpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            await using var stream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(stream) ?? throw new Exception("RequestWebAsync()反序列化失败");
        }
        catch (WebException e)
        {
            Console.Error.WriteLine("RequestWebAsync()发生Web异常: {0}", e);
            return await RequestWebAsync<T>(url, referer, method, parameters, retry - 1);
        }
        catch (IOException e)
        {
            Console.Error.WriteLine("RequestWebAsync()发生IO异常: {0}", e);
            return await RequestWebAsync<T>(url, referer, method, parameters, retry - 1);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("RequestWebAsync()发生其他异常: {0}", e);
            return await RequestWebAsync<T>(url, referer, method, parameters, retry - 1);
        }
    }
}