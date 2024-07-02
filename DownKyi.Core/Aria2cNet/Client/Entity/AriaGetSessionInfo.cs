using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaGetSessionInfo
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")]
    public required AriaGetSessionInfoResult Result { get; set; }

    [JsonPropertyName("error")]
    public required AriaError Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaGetSessionInfoResult
{
    [JsonPropertyName("sessionId")]
    public required string SessionId { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}