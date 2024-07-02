using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaTellStatus
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")]
    public required AriaTellStatusResult Result { get; set; }

    [JsonPropertyName("error")]
    public AriaError? Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaTellStatusList
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("jsonrpc")]
    public required string Jsonrpc { get; set; }

    [JsonPropertyName("result")]
    public List<AriaTellStatusResult>? Result { get; set; }

    [JsonPropertyName("error")]
    public AriaError? Error { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaTellStatusResult
{
    [JsonPropertyName("bitfield")]
    public string? Bitfield { get; set; }

    [JsonPropertyName("completedLength")]
    public required string CompletedLength { get; set; }

    [JsonPropertyName("connections")]
    public string? Connections { get; set; }

    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    [JsonPropertyName("downloadSpeed")]
    public required string DownloadSpeed { get; set; }

    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("files")]
    public List<AriaTellStatusResultFile>? Files { get; set; }

    [JsonPropertyName("gid")]
    public string? Gid { get; set; }

    [JsonPropertyName("numPieces")]
    public required string NumPieces { get; set; }

    [JsonPropertyName("pieceLength")]
    public required string PieceLength { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("totalLength")]
    public required string TotalLength { get; set; }

    [JsonPropertyName("uploadLength")]
    public string? UploadLength { get; set; }

    [JsonPropertyName("uploadSpeed")]
    public string? UploadSpeed { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}

public class AriaTellStatusResultFile
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