
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsHostedRunnerLimits
    {
        /// <summary>
        /// Provides details of static public IP limits for GitHub-hosted Hosted Runners
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_ips")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ActionsHostedRunnerLimitsPublicIps PublicIps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerLimits" /> class.
        /// </summary>
        /// <param name="publicIps">
        /// Provides details of static public IP limits for GitHub-hosted Hosted Runners
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsHostedRunnerLimits(
            global::GitHub.ActionsHostedRunnerLimitsPublicIps publicIps)
        {
            this.PublicIps = publicIps ?? throw new global::System.ArgumentNullException(nameof(publicIps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerLimits" /> class.
        /// </summary>
        public ActionsHostedRunnerLimits()
        {
        }
    }
}