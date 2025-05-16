
#nullable enable

namespace GitHub
{
    /// <summary>
    /// The status of the code search index for this repository
    /// </summary>
    public sealed partial class RepositoryCodeSearchIndexStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lexical_search_ok")]
        public bool? LexicalSearchOk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lexical_commit_sha")]
        public string? LexicalCommitSha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryCodeSearchIndexStatus" /> class.
        /// </summary>
        /// <param name="lexicalSearchOk"></param>
        /// <param name="lexicalCommitSha"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryCodeSearchIndexStatus(
            bool? lexicalSearchOk,
            string? lexicalCommitSha)
        {
            this.LexicalSearchOk = lexicalSearchOk;
            this.LexicalCommitSha = lexicalCommitSha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryCodeSearchIndexStatus" /> class.
        /// </summary>
        public RepositoryCodeSearchIndexStatus()
        {
        }
    }
}