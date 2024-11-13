
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The total number of seats set to "pending cancellation" for members of the specified team(s).
    /// </summary>
    public sealed partial class CopilotCancelCopilotSeatAssignmentForTeamsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seats_cancelled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SeatsCancelled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCancelCopilotSeatAssignmentForTeamsResponse" /> class.
        /// </summary>
        /// <param name="seatsCancelled"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotCancelCopilotSeatAssignmentForTeamsResponse(
            int seatsCancelled)
        {
            this.SeatsCancelled = seatsCancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCancelCopilotSeatAssignmentForTeamsResponse" /> class.
        /// </summary>
        public CopilotCancelCopilotSeatAssignmentForTeamsResponse()
        {
        }
    }
}