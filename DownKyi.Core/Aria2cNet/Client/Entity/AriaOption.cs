using System.Text.Json;
using System.Text.Json.Serialization;

namespace DownKyi.Core.Aria2cNet.Client.Entity;

public class AriaOption
{
    [JsonPropertyName("all-proxy")]
    public required string AllProxy { get; set; }

    [JsonPropertyName("allow-overwrite")]
    public required string AllowOverwrite { get; set; }

    [JsonPropertyName("allow-piece-length-change")]
    public required string AllowPieceLengthChange { get; set; }

    [JsonPropertyName("always-resume")]
    public required string AlwaysResume { get; set; }

    [JsonPropertyName("async-dns")]
    public required string AsyncDns { get; set; }

    [JsonPropertyName("auto-file-renaming")]
    public required string AutoFileRenaming { get; set; }

    [JsonPropertyName("bt-enable-hook-after-hash-check")]
    public required string BtEnableHookAfterHashCheck { get; set; }

    [JsonPropertyName("bt-enable-lpd")]
    public required string BtEnableLpd { get; set; }

    [JsonPropertyName("bt-force-encryption")]
    public required string BtForceEncryption { get; set; }

    [JsonPropertyName("bt-hash-check-seed")]
    public required string BtHashCheckSeed { get; set; }

    [JsonPropertyName("bt-load-saved-metadata")]
    public required string BtLoadSavedMetadata { get; set; }

    [JsonPropertyName("bt-max-peers")]
    public required string BtMaxPeers { get; set; }

    [JsonPropertyName("bt-metadata-only")]
    public required string BtMetadataOnly { get; set; }

    [JsonPropertyName("bt-min-crypto-level")]
    public required string BtMinCryptoLevel { get; set; }

    [JsonPropertyName("bt-remove-unselected-file")]
    public required string BtRemoveUnselectedFile { get; set; }

    [JsonPropertyName("bt-request-peer-speed-limit")]
    public required string BtRequestPeerSpeedLimit { get; set; }

    [JsonPropertyName("bt-require-crypto")]
    public required string BtRequireCrypto { get; set; }

    [JsonPropertyName("bt-save-metadata")]
    public required string BtSaveMetadata { get; set; }

    [JsonPropertyName("bt-seed-unverified")]
    public required string BtSeedUnverified { get; set; }

    [JsonPropertyName("bt-stop-timeout")]
    public required string BtStopTimeout { get; set; }

    [JsonPropertyName("bt-tracker-connect-timeout")]
    public required string BtTrackerConnectTimeout { get; set; }

    [JsonPropertyName("bt-tracker-interval")]
    public required string BtTrackerInterval { get; set; }

    [JsonPropertyName("bt-tracker-timeout")]
    public required string BtTrackerTimeout { get; set; }

    [JsonPropertyName("check-integrity")]
    public required string CheckIntegrity { get; set; }

    [JsonPropertyName("conditional-get")]
    public required string ConditionalGet { get; set; }

    [JsonPropertyName("connect-timeout")]
    public required string ConnectTimeout { get; set; }

    [JsonPropertyName("content-disposition-default-utf8")]
    public required string ContentDispositionDefaultUtf8 { get; set; }

    [JsonPropertyName("continue")]
    public required string Continue { get; set; }

    [JsonPropertyName("dir")]
    public required string Dir { get; set; }

    [JsonPropertyName("dry-run")]
    public required string DryRun { get; set; }

    [JsonPropertyName("enable-http-keep-alive")]
    public required string EnableHttpKeepAlive { get; set; }

    [JsonPropertyName("enable-http-pipelining")]
    public required string EnableHttpPipelining { get; set; }

    [JsonPropertyName("enable-mmap")]
    public required string EnableMmap { get; set; }

    [JsonPropertyName("enable-peer-exchange")]
    public required string EnablePeerExchange { get; set; }

    [JsonPropertyName("file-allocation")]
    public required string FileAllocation { get; set; }

    [JsonPropertyName("follow-metalink")]
    public required string FollowMetalink { get; set; }

    [JsonPropertyName("follow-torrent")]
    public required string FollowTorrent { get; set; }

    [JsonPropertyName("force-save")]
    public required string ForceSave { get; set; }

    [JsonPropertyName("ftp-pasv")]
    public required string FtpPasv { get; set; }

    [JsonPropertyName("ftp-reuse-connection")]
    public required string FtpReuseConnection { get; set; }

    [JsonPropertyName("ftp-type")]
    public required string FtpType { get; set; }

    [JsonPropertyName("hash-check-only")]
    public required string HashCheckOnly { get; set; }

    [JsonPropertyName("http-accept-gzip")]
    public required string HttpAcceptGzip { get; set; }

    [JsonPropertyName("http-auth-challenge")]
    public required string HttpAuthChallenge { get; set; }

    [JsonPropertyName("http-no-cache")]
    public required string HttpNoCache { get; set; }

    [JsonPropertyName("lowest-speed-limit")]
    public required string LowestSpeedLimit { get; set; }

    [JsonPropertyName("max-connection-per-server")]
    public required string MaxConnectionPerServer { get; set; }

    [JsonPropertyName("max-download-limit")]
    public required string MaxDownloadLimit { get; set; }

    [JsonPropertyName("max-file-not-found")]
    public required string MaxFileNotFound { get; set; }

    [JsonPropertyName("max-mmap-limit")]
    public required string MaxMmapLimit { get; set; }

    [JsonPropertyName("max-resume-failure-tries")]
    public required string MaxResumeFailureTries { get; set; }

    [JsonPropertyName("max-tries")]
    public required string MaxTries { get; set; }

    [JsonPropertyName("max-upload-limit")]
    public required string MaxUploadLimit { get; set; }

    [JsonPropertyName("metalink-enable-unique-protocol")]
    public required string MetalinkEnableUniqueProtocol { get; set; }

    [JsonPropertyName("metalink-preferred-protocol")]
    public required string MetalinkPreferredProtocol { get; set; }

    [JsonPropertyName("min-split-size")]
    public required string MinSplitSize { get; set; }

    [JsonPropertyName("no-file-allocation-limit")]
    public required string NoFileAllocationLimit { get; set; }

    [JsonPropertyName("no-netrc")]
    public required string NoNetrc { get; set; }

    [JsonPropertyName("out")]
    public required string Out { get; set; }

    [JsonPropertyName("parameterized-uri")]
    public required string ParameterizedUri { get; set; }

    [JsonPropertyName("pause-metadata")]
    public required string PauseMetadata { get; set; }

    [JsonPropertyName("piece-length")]
    public required string PieceLength { get; set; }

    [JsonPropertyName("proxy-method")]
    public required string ProxyMethod { get; set; }

    [JsonPropertyName("realtime-chunk-checksum")]
    public required string RealtimeChunkChecksum { get; set; }

    [JsonPropertyName("remote-time")]
    public required string RemoteTime { get; set; }

    [JsonPropertyName("remove-control-file")]
    public required string RemoveControlFile { get; set; }

    [JsonPropertyName("retry-wait")]
    public required string RetryWait { get; set; }

    [JsonPropertyName("reuse-uri")]
    public required string ReuseUri { get; set; }

    [JsonPropertyName("rpc-save-upload-metadata")]
    public required string RpcSaveUploadMetadata { get; set; }

    [JsonPropertyName("save-not-found")]
    public required string SaveNotFound { get; set; }

    [JsonPropertyName("seed-ratio")]
    public required string SeedRatio { get; set; }

    [JsonPropertyName("split")]
    public required string Split { get; set; }

    [JsonPropertyName("stream-piece-selector")]
    public required string StreamPieceSelector { get; set; }

    [JsonPropertyName("timeout")]
    public required string Timeout { get; set; }

    [JsonPropertyName("uri-selector")]
    public required string UriSelector { get; set; }

    [JsonPropertyName("use-head")]
    public required string UseHead { get; set; }

    [JsonPropertyName("user-agent")]
    public required string UserAgent { get; set; }

    public override string ToString()
    {
        return JsonSerializer.Serialize(this);
    }
}