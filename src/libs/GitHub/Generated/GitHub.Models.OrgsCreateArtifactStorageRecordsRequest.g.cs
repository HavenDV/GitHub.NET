
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsCreateArtifactStorageRecordsRequest
    {
        /// <summary>
        /// The name of the artifact.<br/>
        /// Example: libfoo-1.2.3
        /// </summary>
        /// <example>libfoo-1.2.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The digest of the artifact (algorithm:hex-encoded-digest).<br/>
        /// Example: sha256:0ecbaa601dba202129058746c7d8e3f282d0efb5fff0...
        /// </summary>
        /// <example>sha256:0ecbaa601dba202129058746c7d8e3f282d0efb5fff0...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The URL where the artifact is stored.<br/>
        /// Example: https://reg.example.com/artifactory/bar/libfoo-1.2.3
        /// </summary>
        /// <example>https://reg.example.com/artifactory/bar/libfoo-1.2.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_url")]
        public string? ArtifactUrl { get; set; }

        /// <summary>
        /// The path of the artifact.<br/>
        /// Example: com/github/bar/libfoo-1.2.3
        /// </summary>
        /// <example>com/github/bar/libfoo-1.2.3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The base URL of the artifact registry.<br/>
        /// Example: https://reg.example.com/artifactory/
        /// </summary>
        /// <example>https://reg.example.com/artifactory/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RegistryUrl { get; set; }

        /// <summary>
        /// The repository name within the registry.<br/>
        /// Example: bar
        /// </summary>
        /// <example>bar</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        public string? Repository { get; set; }

        /// <summary>
        /// The status of the artifact (e.g., active, inactive).<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.OrgsCreateArtifactStorageRecordsRequestStatusJsonConverter))]
        public global::GitHub.OrgsCreateArtifactStorageRecordsRequestStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactStorageRecordsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the artifact.<br/>
        /// Example: libfoo-1.2.3
        /// </param>
        /// <param name="digest">
        /// The digest of the artifact (algorithm:hex-encoded-digest).<br/>
        /// Example: sha256:0ecbaa601dba202129058746c7d8e3f282d0efb5fff0...
        /// </param>
        /// <param name="artifactUrl">
        /// The URL where the artifact is stored.<br/>
        /// Example: https://reg.example.com/artifactory/bar/libfoo-1.2.3
        /// </param>
        /// <param name="path">
        /// The path of the artifact.<br/>
        /// Example: com/github/bar/libfoo-1.2.3
        /// </param>
        /// <param name="registryUrl">
        /// The base URL of the artifact registry.<br/>
        /// Example: https://reg.example.com/artifactory/
        /// </param>
        /// <param name="repository">
        /// The repository name within the registry.<br/>
        /// Example: bar
        /// </param>
        /// <param name="status">
        /// The status of the artifact (e.g., active, inactive).<br/>
        /// Default Value: active<br/>
        /// Example: active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsCreateArtifactStorageRecordsRequest(
            string name,
            string digest,
            string registryUrl,
            string? artifactUrl,
            string? path,
            string? repository,
            global::GitHub.OrgsCreateArtifactStorageRecordsRequestStatus? status)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.RegistryUrl = registryUrl ?? throw new global::System.ArgumentNullException(nameof(registryUrl));
            this.ArtifactUrl = artifactUrl;
            this.Path = path;
            this.Repository = repository;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsCreateArtifactStorageRecordsRequest" /> class.
        /// </summary>
        public OrgsCreateArtifactStorageRecordsRequest()
        {
        }
    }
}