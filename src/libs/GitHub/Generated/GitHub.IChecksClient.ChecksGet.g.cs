#nullable enable

namespace GitHub
{
    public partial interface IChecksClient
    {
        /// <summary>
        /// Get a check run<br/>
        /// Gets a single check run using its `id`.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The Checks API only looks for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkRunId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.CheckRun> ChecksGetAsync(
            string owner,
            string repo,
            int checkRunId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}