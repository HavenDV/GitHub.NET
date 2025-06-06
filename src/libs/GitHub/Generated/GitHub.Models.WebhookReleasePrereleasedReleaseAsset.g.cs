
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Data related to a release.
    /// </summary>
    public sealed partial class WebhookReleasePrereleasedReleaseAsset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browser_download_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BrowserDownloadUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DownloadCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Label { get; set; }

        /// <summary>
        /// The file name of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Digest { get; set; }

        /// <summary>
        /// State of the release asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.WebhookReleasePrereleasedReleaseAssetStateJsonConverter))]
        public global::GitHub.WebhookReleasePrereleasedReleaseAssetState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploader")]
        public global::GitHub.WebhookReleasePrereleasedReleaseAssetUploader? Uploader { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleasePrereleasedReleaseAsset" /> class.
        /// </summary>
        /// <param name="browserDownloadUrl"></param>
        /// <param name="contentType"></param>
        /// <param name="createdAt"></param>
        /// <param name="downloadCount"></param>
        /// <param name="id"></param>
        /// <param name="label"></param>
        /// <param name="name">
        /// The file name of the asset.
        /// </param>
        /// <param name="nodeId"></param>
        /// <param name="size"></param>
        /// <param name="digest"></param>
        /// <param name="state">
        /// State of the release asset.
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="uploader"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookReleasePrereleasedReleaseAsset(
            string browserDownloadUrl,
            string contentType,
            global::System.DateTime createdAt,
            int downloadCount,
            int id,
            string? label,
            string name,
            string nodeId,
            int size,
            string? digest,
            global::System.DateTime updatedAt,
            string url,
            global::GitHub.WebhookReleasePrereleasedReleaseAssetState state,
            global::GitHub.WebhookReleasePrereleasedReleaseAssetUploader? uploader)
        {
            this.BrowserDownloadUrl = browserDownloadUrl ?? throw new global::System.ArgumentNullException(nameof(browserDownloadUrl));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.CreatedAt = createdAt;
            this.DownloadCount = downloadCount;
            this.Id = id;
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Size = size;
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.State = state;
            this.Uploader = uploader;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookReleasePrereleasedReleaseAsset" /> class.
        /// </summary>
        public WebhookReleasePrereleasedReleaseAsset()
        {
        }
    }
}