#nullable enable

namespace GitHub
{
    public partial interface IChecksClient
    {
        /// <summary>
        /// Rerequest a check suite<br/>
        /// Triggers GitHub to rerequest an existing check suite, without pushing new code to a repository. This endpoint will trigger the [`check_suite` webhook](https://docs.github.com/webhooks/event-payloads/#check_suite) event with the action `rerequested`. When a check suite is `rerequested`, its `status` is reset to `queued` and the `conclusion` is cleared.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="checkSuiteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EmptyObject> ChecksRerequestSuiteAsync(
            string owner,
            string repo,
            int checkSuiteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}