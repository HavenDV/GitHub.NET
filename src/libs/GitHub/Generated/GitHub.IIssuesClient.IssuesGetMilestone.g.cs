#nullable enable

namespace GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Get a milestone<br/>
        /// Gets a milestone using the given milestone number.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestoneNumber"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Milestone> IssuesGetMilestoneAsync(
            string owner,
            string repo,
            int milestoneNumber,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}