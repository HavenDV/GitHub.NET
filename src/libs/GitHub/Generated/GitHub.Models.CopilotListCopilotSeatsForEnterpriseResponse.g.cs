
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CopilotListCopilotSeatsForEnterpriseResponse
    {
        /// <summary>
        /// The total number of Copilot seats the enterprise is being billed for. Users with access through multiple organizations or enterprise teams are only counted once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_seats")]
        public int TotalSeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seats")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotSeatDetails>? Seats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}