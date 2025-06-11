#nullable enable

namespace GitHub
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task UsersDeleteAttestationsBulkAsync(
            string username,
            global::GitHub.OneOf<global::GitHub.UsersDeleteAttestationsBulkRequestVariant1, global::GitHub.UsersDeleteAttestationsBulkRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete attestations in bulk<br/>
        /// Delete artifact attestations in bulk by either subject digests or unique ID.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UsersDeleteAttestationsBulkAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}