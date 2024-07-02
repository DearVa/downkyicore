using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaGetServers
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")]
    public required List<AriaGetServersResult> Result { get; set; }

    [JsonPropertyName("error")]
    public required AriaError Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaGetServersResult
{
    [JsonPropertyName("index")]
    public required string Index { get; set; }

    [JsonPropertyName("servers")]
    public required List<AriaResultServer> Servers { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaResultServer
{
    [JsonPropertyName("currentUri")]
    public required string CurrentUri { get; set; }

    [JsonPropertyName("downloadSpeed")]
    public required string DownloadSpeed { get; set; }

    [JsonPropertyName("uri")]
    public required string Uri { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}