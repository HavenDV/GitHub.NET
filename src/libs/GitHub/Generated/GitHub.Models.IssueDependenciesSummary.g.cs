
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssueDependenciesSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BlockedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Blocking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_blocked_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalBlockedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_blocking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalBlocking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueDependenciesSummary" /> class.
        /// </summary>
        /// <param name="blockedBy"></param>
        /// <param name="blocking"></param>
        /// <param name="totalBlockedBy"></param>
        /// <param name="totalBlocking"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueDependenciesSummary(
            int blockedBy,
            int blocking,
            int totalBlockedBy,
            int totalBlocking)
        {
            this.BlockedBy = blockedBy;
            this.Blocking = blocking;
            this.TotalBlockedBy = totalBlockedBy;
            this.TotalBlocking = totalBlocking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueDependenciesSummary" /> class.
        /// </summary>
        public IssueDependenciesSummary()
        {
        }
    }
}