#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Review requests to access organization resources with fine-grained personal access tokens<br/>
        /// Approves or denies multiple pending requests to access organization resources via a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> OrgsReviewPatGrantRequestsInBulkAsync(
            string org,
            global::GitHub.OrgsReviewPatGrantRequestsInBulkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Review requests to access organization resources with fine-grained personal access tokens<br/>
        /// Approves or denies multiple pending requests to access organization resources via a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestIds">
        /// Unique identifiers of the requests for access via fine-grained personal access token. Must be formed of between 1 and 100 `pat_request_id` values.
        /// </param>
        /// <param name="action">
        /// Action to apply to the requests.
        /// </param>
        /// <param name="reason">
        /// Reason for approving or denying the requests. Max 1024 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> OrgsReviewPatGrantRequestsInBulkAsync(
            string org,
            global::GitHub.OrgsReviewPatGrantRequestsInBulkRequestAction action,
            global::System.Collections.Generic.IList<int>? patRequestIds = default,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}