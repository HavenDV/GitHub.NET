
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeScanningAutofixCommitsResponse
    {
        /// <summary>
        /// The Git reference of target branch for the commit. For more information, see "[Git References](https://git-scm.com/book/en/v2/Git-Internals-Git-References)" in the Git documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_ref")]
        public string? TargetRef { get; set; }

        /// <summary>
        /// SHA of commit with autofix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAutofixCommitsResponse" /> class.
        /// </summary>
        /// <param name="targetRef">
        /// The Git reference of target branch for the commit. For more information, see "[Git References](https://git-scm.com/book/en/v2/Git-Internals-Git-References)" in the Git documentation.
        /// </param>
        /// <param name="sha">
        /// SHA of commit with autofix.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodeScanningAutofixCommitsResponse(
            string? targetRef,
            string? sha)
        {
            this.TargetRef = targetRef;
            this.Sha = sha;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAutofixCommitsResponse" /> class.
        /// </summary>
        public CodeScanningAutofixCommitsResponse()
        {
        }
    }
}