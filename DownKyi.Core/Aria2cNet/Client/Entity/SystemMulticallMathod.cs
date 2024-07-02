using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class SystemMulticallMathod
{
    [JsonPropertyName("method")] public required string Method { get; set; }

    [JsonPropertyName("params")] public required List<object> Params { get; set; }
}