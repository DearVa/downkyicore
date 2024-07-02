using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;
/*
     {
    "id": "qwer",
    "jsonrpc": "2.0",
    "result": {
        "downloadSpeed": "0",
        "numActive": "0",
        "numStopped": "0",
        "numStoppedTotal": "0",
        "numWaiting": "0",
        "uploadSpeed": "0"
    }
    }
     */

public class AriaGetGlobalStat
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")]
    public required AriaGetGlobalStatResult Result { get; set; }

    [JsonPropertyName("error")]
    public required AriaError Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaGetGlobalStatResult
{
    [JsonPropertyName("downloadSpeed")]
    public required string DownloadSpeed { get; set; }

    [JsonPropertyName("numActive")]
    public required string NumActive { get; set; }

    [JsonPropertyName("numStopped")]
    public required string NumStopped { get; set; }

    [JsonPropertyName("numStoppedTotal")]
    public required string NumStoppedTotal { get; set; }

    [JsonPropertyName("numWaiting")]
    public required string NumWaiting { get; set; }

    [JsonPropertyName("uploadSpeed")]
    public required string UploadSpeed { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}