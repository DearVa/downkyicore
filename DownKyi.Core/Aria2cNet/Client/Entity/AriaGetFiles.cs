using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaGetFiles
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")]
    public required List<AriaUri> Result { get; set; }

    [JsonPropertyName("error")]
    public required AriaError Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaGetFilesResult
{
    [JsonPropertyName("completedLength")]
    public required string CompletedLength { get; set; }

    [JsonPropertyName("index")]
    public required string Index { get; set; }

    [JsonPropertyName("length")]
    public required string Length { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("selected")]
    public required string Selected { get; set; }

    [JsonPropertyName("uris")]
    public required List<AriaUri> Uris { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}