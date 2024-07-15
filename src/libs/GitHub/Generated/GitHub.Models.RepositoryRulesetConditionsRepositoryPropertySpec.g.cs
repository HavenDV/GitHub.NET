
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Parameters for a targeting a repository property
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryPropertySpec
    {
        /// <summary>
        /// The name of the repository property to target
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The values to match for the repository property
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PropertyValues { get; set; }

        /// <summary>
        /// The source of the repository property. Defaults to 'custom' if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRulesetConditionsRepositoryPropertySpecSourceJsonConverter))]
        public global::GitHub.RepositoryRulesetConditionsRepositoryPropertySpecSource? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}