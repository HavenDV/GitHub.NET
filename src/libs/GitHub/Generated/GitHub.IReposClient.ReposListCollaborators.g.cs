#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List repository collaborators<br/>
        /// For organization-owned repositories, the list of collaborators includes outside collaborators, organization members that are direct collaborators, organization members with access through team memberships, organization members with access through default organization permissions, and organization owners.<br/>
        /// The `permissions` hash returned in the response contains the base role permissions of the collaborator. The `role_name` is the highest role assigned to the collaborator after considering all sources of grants, including: repo, teams, organization, and enterprise.<br/>
        /// There is presently not a way to differentiate between an organization level grant and a repository level grant from this endpoint response.<br/>
        /// Team members will include the members of child teams.<br/>
        /// The authenticated user must have write, maintain, or admin privileges on the repository to use this endpoint. For organization-owned repositories, the authenticated user needs to be a member of the organization.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:org` and `repo` scopes to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="affiliation">
        /// Default Value: all
        /// </param>
        /// <param name="permission"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.Collaborator>> ReposListCollaboratorsAsync(
            string owner,
            string repo,
            global::GitHub.ReposListCollaboratorsAffiliation? affiliation = default,
            global::GitHub.ReposListCollaboratorsPermission? permission = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}