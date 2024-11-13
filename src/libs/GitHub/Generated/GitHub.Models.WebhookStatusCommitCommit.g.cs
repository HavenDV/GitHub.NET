
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusCommitCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AllOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.AllOf<global::GitHub.WebhookStatusCommitCommitAuthorVariant1, global::GitHub.WebhookStatusCommitCommitAuthorVariant2> Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommentCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AllOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.AllOf<global::GitHub.WebhookStatusCommitCommitCommitterVariant1, global::GitHub.WebhookStatusCommitCommitCommitterVariant2> Committer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookStatusCommitCommitTree Tree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookStatusCommitCommitVerification Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommit" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="commentCount"></param>
        /// <param name="committer"></param>
        /// <param name="message"></param>
        /// <param name="tree"></param>
        /// <param name="url"></param>
        /// <param name="verification"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookStatusCommitCommit(
            global::GitHub.AllOf<global::GitHub.WebhookStatusCommitCommitAuthorVariant1, global::GitHub.WebhookStatusCommitCommitAuthorVariant2> author,
            int commentCount,
            global::GitHub.AllOf<global::GitHub.WebhookStatusCommitCommitCommitterVariant1, global::GitHub.WebhookStatusCommitCommitCommitterVariant2> committer,
            string message,
            global::GitHub.WebhookStatusCommitCommitTree tree,
            string url,
            global::GitHub.WebhookStatusCommitCommitVerification verification)
        {
            this.Author = author;
            this.CommentCount = commentCount;
            this.Committer = committer;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tree = tree ?? throw new global::System.ArgumentNullException(nameof(tree));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Verification = verification ?? throw new global::System.ArgumentNullException(nameof(verification));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusCommitCommit" /> class.
        /// </summary>
        public WebhookStatusCommitCommit()
        {
        }
    }
}