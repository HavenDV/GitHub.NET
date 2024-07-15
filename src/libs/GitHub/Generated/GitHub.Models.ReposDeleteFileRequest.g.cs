
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
    }
}