#nullable enable

namespace GitHub
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List team members<br/>
        /// Team members will include the members of child teams.<br/>
        /// To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.SimpleUser>> TeamsListMembersInOrgAsync(
            string org,
            string teamSlug,
            global::GitHub.TeamsListMembersInOrgRole? role = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}