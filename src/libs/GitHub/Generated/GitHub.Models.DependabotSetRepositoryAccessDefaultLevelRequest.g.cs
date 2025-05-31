
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependabotSetRepositoryAccessDefaultLevelRequest
    {
        /// <summary>
        /// The default repository access level for Dependabot updates.<br/>
        /// Example: internal
        /// </summary>
        /// <example>internal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel DefaultLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotSetRepositoryAccessDefaultLevelRequest" /> class.
        /// </summary>
        /// <param name="defaultLevel">
        /// The default repository access level for Dependabot updates.<br/>
        /// Example: internal
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotSetRepositoryAccessDefaultLevelRequest(
            global::GitHub.DependabotSetRepositoryAccessDefaultLevelRequestDefaultLevel defaultLevel)
        {
            this.DefaultLevel = defaultLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotSetRepositoryAccessDefaultLevelRequest" /> class.
        /// </summary>
        public DependabotSetRepositoryAccessDefaultLevelRequest()
        {
        }
    }
}