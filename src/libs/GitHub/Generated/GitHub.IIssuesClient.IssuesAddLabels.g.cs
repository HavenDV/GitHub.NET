#nullable enable

namespace GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Add labels to an issue<br/>
        /// Adds labels to an issue. If you provide an empty array of labels, all labels are removed from the issue. 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Label>> IssuesAddLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::GitHub.OneOf<global::GitHub.IssuesAddLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::GitHub.IssuesAddLabelsRequestVariant3, global::System.Collections.Generic.IList<global::GitHub.IssuesAddLabelsRequestVariant4Item>, string> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add labels to an issue<br/>
        /// Adds labels to an issue. If you provide an empty array of labels, all labels are removed from the issue. 
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Label>> IssuesAddLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}