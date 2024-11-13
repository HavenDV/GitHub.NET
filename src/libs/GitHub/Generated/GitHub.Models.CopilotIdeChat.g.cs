
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Usage metrics for Copilot Chat in the IDE.
    /// </summary>
    public sealed partial class CopilotIdeChat
    {
        /// <summary>
        /// Total number of users who prompted Copilot Chat in the IDE.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_engaged_users")]
        public int? TotalEngagedUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editors")]
        public global::System.Collections.Generic.IList<global::GitHub.CopilotIdeChatEditor>? Editors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeChat" /> class.
        /// </summary>
        /// <param name="totalEngagedUsers">
        /// Total number of users who prompted Copilot Chat in the IDE.
        /// </param>
        /// <param name="editors"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CopilotIdeChat(
            int? totalEngagedUsers,
            global::System.Collections.Generic.IList<global::GitHub.CopilotIdeChatEditor>? editors)
        {
            this.TotalEngagedUsers = totalEngagedUsers;
            this.Editors = editors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CopilotIdeChat" /> class.
        /// </summary>
        public CopilotIdeChat()
        {
        }
    }
}