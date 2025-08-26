
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SelfHostedRunnersSettings
    {
        /// <summary>
        /// The policy that controls whether self-hosted runners can be used by repositories in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_repositories")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SelfHostedRunnersSettingsEnabledRepositoriesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SelfHostedRunnersSettingsEnabledRepositories EnabledRepositories { get; set; }

        /// <summary>
        /// The URL to the endpoint for managing selected repositories for self-hosted runners in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_repositories_url")]
        public string? SelectedRepositoriesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfHostedRunnersSettings" /> class.
        /// </summary>
        /// <param name="enabledRepositories">
        /// The policy that controls whether self-hosted runners can be used by repositories in the organization
        /// </param>
        /// <param name="selectedRepositoriesUrl">
        /// The URL to the endpoint for managing selected repositories for self-hosted runners in the organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SelfHostedRunnersSettings(
            global::GitHub.SelfHostedRunnersSettingsEnabledRepositories enabledRepositories,
            string? selectedRepositoriesUrl)
        {
            this.EnabledRepositories = enabledRepositories;
            this.SelectedRepositoriesUrl = selectedRepositoriesUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelfHostedRunnersSettings" /> class.
        /// </summary>
        public SelfHostedRunnersSettings()
        {
        }
    }
}