using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

//{
//"id": "downkyi",
//"jsonrpc": "2.0",
//"result": "1aac102a4875c8cd"
//}

public class AriaAddUri
{
    [JsonPropertyName("id")] public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")] public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")] public required string Result { get; set; }

    [JsonPropertyName("error")] public AriaError? Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}