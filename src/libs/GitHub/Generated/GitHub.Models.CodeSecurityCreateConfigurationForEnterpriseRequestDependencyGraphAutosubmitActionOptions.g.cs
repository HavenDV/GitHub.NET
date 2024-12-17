
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Feature options for Automatic dependency submission
    /// </summary>
    public sealed partial class CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionOptions
    {
        /// <summary>
        /// Whether to use runners labeled with 'dependency-submission' or standard GitHub runners.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labeled_runners")]
        public bool? LabeledRunners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionOptions" /> class.
        /// </summary>
        /// <param name="labeledRunners">
        /// Whether to use runners labeled with 'dependency-submission' or standard GitHub runners.<br/>
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionOptions(
            bool? labeledRunners)
        {
            this.LabeledRunners = labeledRunners;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionOptions" /> class.
        /// </summary>
        public CodeSecurityCreateConfigurationForEnterpriseRequestDependencyGraphAutosubmitActionOptions()
        {
        }
    }
}