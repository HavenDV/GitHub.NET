
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The total number of seats created for the specified user(s).
    /// </summary>
    public sealed partial class CopilotAddCopilotSeatsForUsersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seats_created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SeatsCreated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForUsersResponse" /> class.
        /// </summary>
        /// <param name="seatsCreated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CopilotAddCopilotSeatsForUsersResponse(
            int seatsCreated)
        {
            this.SeatsCreated = seatsCreated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotAddCopilotSeatsForUsersResponse" /> class.
        /// </summary>
        public CopilotAddCopilotSeatsForUsersResponse()
        {
        }
    }
}