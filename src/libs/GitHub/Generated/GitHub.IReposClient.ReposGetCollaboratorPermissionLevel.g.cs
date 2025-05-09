#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get repository permissions for a user<br/>
        /// Checks the repository permission and role of a collaborator.<br/>
        /// The `permission` attribute provides the legacy base roles of `admin`, `write`, `read`, and `none`, where the<br/>
        /// `maintain` role is mapped to `write` and the `triage` role is mapped to `read`.<br/>
        /// The `role_name` attribute provides the name of the assigned role, including custom roles. The<br/>
        /// `permission` can also be used to determine which base level of access the collaborator has to the repository.<br/>
        /// The calculated permissions are the highest role assigned to the collaborator after considering all sources of grants, including: repo, teams, organization, and enterprise.<br/>
        /// There is presently not a way to differentiate between an organization level grant and a repository level grant from this endpoint response.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.RepositoryCollaboratorPermission> ReposGetCollaboratorPermissionLevelAsync(
            string owner,
            string repo,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}