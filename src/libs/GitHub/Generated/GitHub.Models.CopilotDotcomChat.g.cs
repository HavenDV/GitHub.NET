
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Usage metrics for Copilot Chat in GitHub.com
    /// </summary>
    public sealed partial class CopilotDotcomChat
    {
        /// <summary>
        /// Total number of users who prompted Copilot Chat on github.com at least once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// List of model metrics for a custom models and the default model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotDotcomChatModel>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomChat" /> class.
        /// </summary>
        /// <param name="totalEngagedUsers">
        /// Total number of users who prompted Copilot Chat on github.com at least once.
        /// </param>
        /// <param name="models">
        /// List of model metrics for a custom models and the default model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotDotcomChat(
            int? totalEngagedUsers,
            global::System.Collections.Generic.IList<global::GitHub.CopilotDotcomChatModel>? models)
        {
            this.TotalEngagedUsers = totalEngagedUsers;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotDotcomChat" /> class.
        /// </summary>
        public CopilotDotcomChat()
        {
        }
    }
}