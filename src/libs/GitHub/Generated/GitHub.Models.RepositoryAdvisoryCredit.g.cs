
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A credit given to a user for a repository security advisory.
    /// </summary>
    public sealed partial class RepositoryAdvisoryCredit
    {
        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleUser User { get; set; }

        /// <summary>
        /// The type of credit the user is receiving.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.SecurityAdvisoryCreditTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SecurityAdvisoryCreditTypes Type { get; set; }

        /// <summary>
        /// The state of the user's acceptance of the credit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryAdvisoryCreditStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.RepositoryAdvisoryCreditState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}