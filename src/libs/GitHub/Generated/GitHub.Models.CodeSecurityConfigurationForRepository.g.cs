
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Code security configuration associated with a repository and attachment status
    /// </summary>
    public sealed partial class CodeSecurityConfigurationForRepository
    {
        /// <summary>
        /// The attachment status of the code security configuration on the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.CodeSecurityConfigurationForRepositoryStatusJsonConverter))]
        public global::GitHub.CodeSecurityConfigurationForRepositoryStatus? Status { get; set; }

        /// <summary>
        /// A code security configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::GitHub.CodeSecurityConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationForRepository" /> class.
        /// </summary>
        /// <param name="status">
        /// The attachment status of the code security configuration on the repository.
        /// </param>
        /// <param name="configuration">
        /// A code security configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeSecurityConfigurationForRepository(
            global::GitHub.CodeSecurityConfigurationForRepositoryStatus? status,
            global::GitHub.CodeSecurityConfiguration? configuration)
        {
            this.Status = status;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityConfigurationForRepository" /> class.
        /// </summary>
        public CodeSecurityConfigurationForRepository()
        {
        }
    }
}