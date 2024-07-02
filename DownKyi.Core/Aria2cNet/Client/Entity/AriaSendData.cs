using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaSendData
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public required string Jsonrpc { get; set; }

    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("params")]
    public List<object> Params { get; set; } = [];

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaSendOption
{
    [JsonPropertyName("all-proxy")]
    public string? HttpProxy { get; set; }

    [JsonPropertyName("out")]
    public required string Out { get; set; }

    [JsonPropertyName("dir")]
    public required string Dir { get; set; }

    //[JsonPropertyName("header")]
    //public required string Header { get; set; }

    //[JsonPropertyName("use-head")]
    //public required string UseHead { get; set; }

    [JsonPropertyName("user-agent")]
    public required string UserAgent { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}