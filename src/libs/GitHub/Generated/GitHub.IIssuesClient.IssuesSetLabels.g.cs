#nullable enable

namespace GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::GitHub.OneOf<global::GitHub.IssuesSetLabelsRequestVariant1, global::System.Collections.Generic.IList<string>, global::GitHub.IssuesSetLabelsRequestVariant3, global::System.Collections.Generic.IList<global::GitHub.IssuesSetLabelsRequestVariant4Item>, string> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set labels for an issue<br/>
        /// Removes any previous labels and sets the new labels for an issue.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="issueNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Label>> IssuesSetLabelsAsync(
            string owner,
            string repo,
            int issueNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}