#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Accept a repository invitation
        /// </summary>
        /// <param name="invitationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.BasicError> ReposAcceptInvitationForAuthenticatedUserAsync(
            int invitationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}