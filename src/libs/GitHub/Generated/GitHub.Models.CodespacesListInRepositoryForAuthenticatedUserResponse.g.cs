
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesListInRepositoryForAuthenticatedUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codespaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.Codespace> Codespaces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListInRepositoryForAuthenticatedUserResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="codespaces"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesListInRepositoryForAuthenticatedUserResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::GitHub.Codespace> codespaces)
        {
            this.TotalCount = totalCount;
            this.Codespaces = codespaces ?? throw new global::System.ArgumentNullException(nameof(codespaces));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesListInRepositoryForAuthenticatedUserResponse" /> class.
        /// </summary>
        public CodespacesListInRepositoryForAuthenticatedUserResponse()
        {
        }
    }
}