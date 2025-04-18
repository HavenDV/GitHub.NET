
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryAdvisoryUpdateCredit
    {
        /// <summary>
        /// The username of the user credited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// The type of credit the user is receiving.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.SecurityAdvisoryCreditTypesJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SecurityAdvisoryCreditTypes Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdateCredit" /> class.
        /// </summary>
        /// <param name="login">
        /// The username of the user credited.
        /// </param>
        /// <param name="type">
        /// The type of credit the user is receiving.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryAdvisoryUpdateCredit(
            string login,
            global::GitHub.SecurityAdvisoryCreditTypes type)
        {
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisoryUpdateCredit" /> class.
        /// </summary>
        public RepositoryAdvisoryUpdateCredit()
        {
        }
    }
}