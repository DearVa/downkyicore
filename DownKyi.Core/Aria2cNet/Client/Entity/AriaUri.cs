using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaUri
{
    [JsonPropertyName("status")] public required string Status { get; set; }

    [JsonPropertyName("uri")] public required string Uri { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}