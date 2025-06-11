
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Information about repositories that Dependabot is able to access in an organization
    /// </summary>
    public sealed partial class DependabotRepositoryAccessDetails
    {
        /// <summary>
        /// The default repository access level for Dependabot updates.<br/>
        /// Example: internal
        /// </summary>
        /// <example>internal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.DependabotRepositoryAccessDetailsDefaultLevelJsonConverter))]
        public global::GitHub.DependabotRepositoryAccessDetailsDefaultLevel? DefaultLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessible_repositories")]
        public global::System.Collections.Generic.IList<global::GitHub.NullableSimpleRepository>? AccessibleRepositories { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotRepositoryAccessDetails" /> class.
        /// </summary>
        /// <param name="defaultLevel">
        /// The default repository access level for Dependabot updates.<br/>
        /// Example: internal
        /// </param>
        /// <param name="accessibleRepositories"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotRepositoryAccessDetails(
            global::GitHub.DependabotRepositoryAccessDetailsDefaultLevel? defaultLevel,
            global::System.Collections.Generic.IList<global::GitHub.NullableSimpleRepository>? accessibleRepositories)
        {
            this.DefaultLevel = defaultLevel;
            this.AccessibleRepositories = accessibleRepositories;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotRepositoryAccessDetails" /> class.
        /// </summary>
        public DependabotRepositoryAccessDetails()
        {
        }
    }
}