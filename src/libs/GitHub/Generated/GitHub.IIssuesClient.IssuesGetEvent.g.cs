#nullable enable

namespace GitHub
{
    public partial interface IIssuesClient
    {
        /// <summary>
        /// Get an issue event<br/>
        /// Gets a single event by the event id.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="eventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.IssueEvent> IssuesGetEventAsync(
            string owner,
            string repo,
            int eventId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}