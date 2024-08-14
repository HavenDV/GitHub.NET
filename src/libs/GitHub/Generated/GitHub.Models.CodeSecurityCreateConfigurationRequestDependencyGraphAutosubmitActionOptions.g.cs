
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Feature options for Automatic dependency submission
    /// </summary>
    public sealed partial class CodeSecurityCreateConfigurationRequestDependencyGraphAutosubmitActionOptions
    {
        /// <summary>
        /// Whether to use runners labeled with 'dependency-submission' or standard GitHub runners.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labeled_runners")]
        public bool LabeledRunners { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}