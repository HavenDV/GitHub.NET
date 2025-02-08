
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The total number of seats set to "pending cancellation" for the specified users.
    /// </summary>
    public sealed partial class CopilotCancelCopilotSeatAssignmentForUsersResponse
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
        /// Initializes a new instance of the <see cref="CopilotCancelCopilotSeatAssignmentForUsersResponse" /> class.
        /// </summary>
        /// <param name="seatsCancelled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotCancelCopilotSeatAssignmentForUsersResponse(
            int seatsCancelled)
        {
            this.SeatsCancelled = seatsCancelled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotCancelCopilotSeatAssignmentForUsersResponse" /> class.
        /// </summary>
        public CopilotCancelCopilotSeatAssignmentForUsersResponse()
        {
        }
    }
}