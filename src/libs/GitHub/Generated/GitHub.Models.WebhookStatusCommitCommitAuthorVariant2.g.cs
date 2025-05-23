
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusCommitCommitAuthorVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommitAuthorVariant2" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="email"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookStatusCommitCommitAuthorVariant2(
            string date,
            string? email,
            string? name)
        {
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.Email = email;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommitAuthorVariant2" /> class.
        /// </summary>
        public WebhookStatusCommitCommitAuthorVariant2()
        {
        }
    }
}