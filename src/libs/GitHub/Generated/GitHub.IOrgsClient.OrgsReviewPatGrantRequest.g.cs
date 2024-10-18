#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Review a request to access organization resources with a fine-grained personal access token<br/>
        /// Approves or denies a pending request to access organization resources via a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> OrgsReviewPatGrantRequestAsync(
            string org,
            int patRequestId,
            global::GitHub.OrgsReviewPatGrantRequestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Review a request to access organization resources with a fine-grained personal access token<br/>
        /// Approves or denies a pending request to access organization resources via a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="patRequestId"></param>
        /// <param name="action">
        /// Action to apply to the request.
        /// </param>
        /// <param name="reason">
        /// Reason for approving or denying the request. Max 1024 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> OrgsReviewPatGrantRequestAsync(
            string org,
            int patRequestId,
            global::GitHub.OrgsReviewPatGrantRequestRequestAction action,
            string? reason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}