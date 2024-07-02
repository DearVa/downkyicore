using System.Text.Json.Serialization;

namespace DownKyi.Core.BiliApi.Models.Json;

public class SubtitleJson : BaseModel
{
    [JsonPropertyName("font_size")] public float FontSize { get; set; }
    [JsonPropertyName("font_color")] public required string FontColor { get; set; }
    [JsonPropertyName("background_alpha")] public float BackgroundAlpha { get; set; }
    [JsonPropertyName("background_color")] public required string BackgroundColor { get; set; }
    [JsonPropertyName("Stroke")] public required string Stroke { get; set; }
    [JsonPropertyName("body")] public required List<Subtitle> Body { get; set; }

    /// <summary>
    ///     srt格式字幕
    /// </summary>
    /// <returns></returns>
    public string ToSubRip()
    {
        var subRip = string.Empty;
        for (var i = 0; i < Body.Count; i++)
        {
            subRip += $"{i + 1}\n";
            subRip += $"{Second2Hms(Body[i].From)} --> {Second2Hms(Body[i].To)}\n";
            subRip += $"{Body[i].Content}\n";
            subRip += "\n";
        }

        return subRip;
    }

    /// <summary>
    ///     秒数转 时:分:秒 格式
    /// </summary>
    /// <param name="seconds"></param>
    /// <returns></returns>
    private static string Second2Hms(float seconds)
    {
        if (seconds < 0)
        {
            return "00:00:00,000";
        }

        var i = (int)Math.Floor(seconds / 1.0);
        var dec = (int)(Math.Round(seconds % 1.0f, 2) * 100);
        if (dec >= 100)
        {
            dec = 99;
        }

        var min = (int)Math.Floor(i / 60.0);
        var second = (int)(i % 60.0f);

        var hour = (int)Math.Floor(min / 60.0);
        min = (int)Math.Floor(min % 60.0f);

        return $"{hour:D2}:{min:D2}:{second:D2},{dec:D3}";
    }
}