using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class SystemListMethods
{
    [JsonPropertyName("id")] public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")] public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")] public required List<string> Result { get; set; }

    [JsonPropertyName("error")] public required AriaError Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}