
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposDeleteFileRequest
    {
        /// <summary>
        /// The commit message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The blob SHA of the file being deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// The branch name. Default: the repository’s default branch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// object containing information about the committer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("committer")]
        public global::GitHub.ReposDeleteFileRequestCommitter? Committer { get; set; }

        /// <summary>
        /// object containing information about the author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public global::GitHub.ReposDeleteFileRequestAuthor? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposDeleteFileRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// The commit message.
        /// </param>
        /// <param name="sha">
        /// The blob SHA of the file being deleted.
        /// </param>
        /// <param name="branch">
        /// The branch name. Default: the repository’s default branch
        /// </param>
        /// <param name="committer">
        /// object containing information about the committer.
        /// </param>
        /// <param name="author">
        /// object containing information about the author.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposDeleteFileRequest(
            string message,
            string sha,
            string? branch,
            global::GitHub.ReposDeleteFileRequestCommitter? committer,
            global::GitHub.ReposDeleteFileRequestAuthor? author)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Branch = branch;
            this.Committer = committer;
            this.Author = author;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposDeleteFileRequest" /> class.
        /// </summary>
        public ReposDeleteFileRequest()
        {
        }
    }
}