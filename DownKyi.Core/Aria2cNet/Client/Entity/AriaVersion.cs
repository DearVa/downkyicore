using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaVersion
{
    [JsonPropertyName("id")] public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")] public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")] public required AriaVersionResult Result { get; set; }

    [JsonPropertyName("error")] public required AriaError Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaVersionResult
{
    [JsonPropertyName("enabledFeatures")] public required List<string> EnabledFeatures { get; set; }

    [JsonPropertyName("version")] public required string Version { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}