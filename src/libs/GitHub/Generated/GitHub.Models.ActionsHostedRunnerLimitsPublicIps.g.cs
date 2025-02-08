
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Provides details of static public IP limits for GitHub-hosted Hosted Runners
    /// </summary>
    public sealed partial class ActionsHostedRunnerLimitsPublicIps
    {
        /// <summary>
        /// The maximum number of static public IP addresses that can be used for Hosted Runners.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maximum")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Maximum { get; set; }

        /// <summary>
        /// The current number of static public IP addresses in use by Hosted Runners.<br/>
        /// Example: 17
        /// </summary>
        /// <example>17</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CurrentUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerLimitsPublicIps" /> class.
        /// </summary>
        /// <param name="maximum">
        /// The maximum number of static public IP addresses that can be used for Hosted Runners.<br/>
        /// Example: 50
        /// </param>
        /// <param name="currentUsage">
        /// The current number of static public IP addresses in use by Hosted Runners.<br/>
        /// Example: 17
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsHostedRunnerLimitsPublicIps(
            int maximum,
            int currentUsage)
        {
            this.Maximum = maximum;
            this.CurrentUsage = currentUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsHostedRunnerLimitsPublicIps" /> class.
        /// </summary>
        public ActionsHostedRunnerLimitsPublicIps()
        {
        }
    }
}