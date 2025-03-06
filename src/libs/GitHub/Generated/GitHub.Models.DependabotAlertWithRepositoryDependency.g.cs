
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Details for the vulnerable dependency.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertWithRepositoryDependency
    {
        /// <summary>
        /// Details for the vulnerable package.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package")]
        public global::GitHub.DependabotAlertPackage? Package { get; set; }

        /// <summary>
        /// The full path to the dependency manifest file, relative to the root of the repository.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_path")]
        public string? ManifestPath { get; set; }

        /// <summary>
        /// The execution scope of the vulnerable dependency.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.DependabotAlertWithRepositoryDependencyScopeJsonConverter))]
        public global::GitHub.DependabotAlertWithRepositoryDependencyScope? Scope { get; set; }

        /// <summary>
        /// The vulnerable dependency's relationship to your project.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; We are rolling out support for dependency relationship across ecosystems. This value will be "unknown" for all dependencies in unsupported ecosystems.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relationship")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.DependabotAlertWithRepositoryDependencyRelationshipJsonConverter))]
        public global::GitHub.DependabotAlertWithRepositoryDependencyRelationship? Relationship { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertWithRepositoryDependency" /> class.
        /// </summary>
        /// <param name="package">
        /// Details for the vulnerable package.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="manifestPath">
        /// The full path to the dependency manifest file, relative to the root of the repository.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="scope">
        /// The execution scope of the vulnerable dependency.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="relationship">
        /// The vulnerable dependency's relationship to your project.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; We are rolling out support for dependency relationship across ecosystems. This value will be "unknown" for all dependencies in unsupported ecosystems.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependabotAlertWithRepositoryDependency(
            global::GitHub.DependabotAlertPackage? package,
            string? manifestPath,
            global::GitHub.DependabotAlertWithRepositoryDependencyScope? scope,
            global::GitHub.DependabotAlertWithRepositoryDependencyRelationship? relationship)
        {
            this.Package = package;
            this.ManifestPath = manifestPath;
            this.Scope = scope;
            this.Relationship = relationship;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertWithRepositoryDependency" /> class.
        /// </summary>
        public DependabotAlertWithRepositoryDependency()
        {
        }
    }
}