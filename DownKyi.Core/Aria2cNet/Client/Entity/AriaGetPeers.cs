using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaGetPeers
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")]
    public required List<AriaPeer> Result { get; set; }

    [JsonPropertyName("error")]
    public required AriaError Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaPeer
{
    [JsonPropertyName("amChoking")]
    public required string AmChoking { get; set; }

    [JsonPropertyName("bitfield")]
    public required string Bitfield { get; set; }

    [JsonPropertyName("downloadSpeed")]
    public required string DownloadSpeed { get; set; }

    [JsonPropertyName("ip")]
    public required string Ip { get; set; }

    [JsonPropertyName("peerChoking")]
    public required string PeerChoking { get; set; }

    [JsonPropertyName("peerId")]
    public required string PeerId { get; set; }

    [JsonPropertyName("port")]
    public required string Port { get; set; }

    [JsonPropertyName("seeder")]
    public required string Seeder { get; set; }

    [JsonPropertyName("uploadSpeed")]
    public required string UploadSpeed { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}