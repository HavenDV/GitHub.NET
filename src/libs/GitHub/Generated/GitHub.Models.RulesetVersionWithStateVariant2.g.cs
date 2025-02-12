
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RulesetVersionWithStateVariant2
    {
        /// <summary>
        /// The state of the ruleset version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesetVersionWithStateVariant2" /> class.
        /// </summary>
        /// <param name="state">
        /// The state of the ruleset version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RulesetVersionWithStateVariant2(
            object state)
        {
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesetVersionWithStateVariant2" /> class.
        /// </summary>
        public RulesetVersionWithStateVariant2()
        {
        }
    }
}