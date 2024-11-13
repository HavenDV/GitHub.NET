
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitOverviewResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("core")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RateLimit Core { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("graphql")]
        public global::GitHub.RateLimit? Graphql { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RateLimit Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_search")]
        public global::GitHub.RateLimit? CodeSearch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_import")]
        public global::GitHub.RateLimit? SourceImport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_manifest")]
        public global::GitHub.RateLimit? IntegrationManifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_scanning_upload")]
        public global::GitHub.RateLimit? CodeScanningUpload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions_runner_registration")]
        public global::GitHub.RateLimit? ActionsRunnerRegistration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim")]
        public global::GitHub.RateLimit? Scim { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_snapshots")]
        public global::GitHub.RateLimit? DependencySnapshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverviewResources" /> class.
        /// </summary>
        /// <param name="core"></param>
        /// <param name="graphql"></param>
        /// <param name="search"></param>
        /// <param name="codeSearch"></param>
        /// <param name="sourceImport"></param>
        /// <param name="integrationManifest"></param>
        /// <param name="codeScanningUpload"></param>
        /// <param name="actionsRunnerRegistration"></param>
        /// <param name="scim"></param>
        /// <param name="dependencySnapshots"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RateLimitOverviewResources(
            global::GitHub.RateLimit core,
            global::GitHub.RateLimit search,
            global::GitHub.RateLimit? graphql,
            global::GitHub.RateLimit? codeSearch,
            global::GitHub.RateLimit? sourceImport,
            global::GitHub.RateLimit? integrationManifest,
            global::GitHub.RateLimit? codeScanningUpload,
            global::GitHub.RateLimit? actionsRunnerRegistration,
            global::GitHub.RateLimit? scim,
            global::GitHub.RateLimit? dependencySnapshots)
        {
            this.Core = core ?? throw new global::System.ArgumentNullException(nameof(core));
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.Graphql = graphql;
            this.CodeSearch = codeSearch;
            this.SourceImport = sourceImport;
            this.IntegrationManifest = integrationManifest;
            this.CodeScanningUpload = codeScanningUpload;
            this.ActionsRunnerRegistration = actionsRunnerRegistration;
            this.Scim = scim;
            this.DependencySnapshots = dependencySnapshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverviewResources" /> class.
        /// </summary>
        public RateLimitOverviewResources()
        {
        }
    }
}