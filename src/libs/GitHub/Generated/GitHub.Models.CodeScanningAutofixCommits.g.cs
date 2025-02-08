
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Commit an autofix for a code scanning alert
    /// </summary>
    public sealed partial class CodeScanningAutofixCommits
    {
        /// <summary>
        /// The Git reference of target branch for the commit. Branch needs to already exist.  For more information, see "[Git References](https://git-scm.com/book/en/v2/Git-Internals-Git-References)" in the Git documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_ref")]
        public string? TargetRef { get; set; }

        /// <summary>
        /// Commit message to be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAutofixCommits" /> class.
        /// </summary>
        /// <param name="targetRef">
        /// The Git reference of target branch for the commit. Branch needs to already exist.  For more information, see "[Git References](https://git-scm.com/book/en/v2/Git-Internals-Git-References)" in the Git documentation.
        /// </param>
        /// <param name="message">
        /// Commit message to be used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeScanningAutofixCommits(
            string? targetRef,
            string? message)
        {
            this.TargetRef = targetRef;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeScanningAutofixCommits" /> class.
        /// </summary>
        public CodeScanningAutofixCommits()
        {
        }
    }
}