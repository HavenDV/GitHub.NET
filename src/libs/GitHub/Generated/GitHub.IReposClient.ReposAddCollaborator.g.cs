#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Add a repository collaborator<br/>
        /// Add a user to a repository with a specified level of access. If the repository is owned by an organization, this API does not add the user to the organization - a user that has repository access without being an organization member is called an "outside collaborator" (if they are not an Enterprise Managed User) or a "repository collaborator" if they are an Enterprise Managed User. These users are exempt from some organization policies - see "[Adding outside collaborators to repositories](https://docs.github.com/organizations/managing-user-access-to-your-organizations-repositories/managing-outside-collaborators/adding-outside-collaborators-to-repositories-in-your-organization)" to learn more about these collaborator types.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications).<br/>
        /// Adding an outside collaborator may be restricted by enterprise and organization administrators. For more information, see "[Enforcing repository management policies in your enterprise](https://docs.github.com/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories)" and "[Setting permissions for adding outside collaborators](https://docs.github.com/organizations/managing-organization-settings/setting-permissions-for-adding-outside-collaborators)" for organization settings.<br/>
        /// For more information on permission levels, see "[Repository permission levels for an organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)". There are restrictions on which permissions can be granted to organization members when an organization base role is in place. In this case, the role being given must be equal to or higher than the org base permission. Otherwise, the request will fail with:<br/>
        /// ```<br/>
        /// Cannot assign {member} permission of {role name}<br/>
        /// ```<br/>
        /// Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."<br/>
        /// The invitee will receive a notification that they have been invited to the repository, which they must accept or decline. They may do this via the notifications page, the email they receive, or by using the [API](https://docs.github.com/rest/collaborators/invitations).<br/>
        /// For Enterprise Managed Users, this endpoint does not send invitations - these users are automatically added to organizations and repositories. Enterprise Managed Users can only be added to organizations and repositories within their enterprise.<br/>
        /// **Updating an existing collaborator's permission level**<br/>
        /// The endpoint can also be used to change the permissions of an existing collaborator without first removing and re-adding the collaborator. To change the permissions, use the same endpoint and pass a different `permission` parameter. The response will be a `204`, with no other indication that the permission level changed.<br/>
        /// **Rate limits**<br/>
        /// You are limited to sending 50 invitations to a repository per 24 hour period. Note there is no limit if you are inviting organization members to an organization repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="username"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.RepositoryInvitation> ReposAddCollaboratorAsync(
            string owner,
            string repo,
            string username,
            global::GitHub.ReposAddCollaboratorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a repository collaborator<br/>
        /// Add a user to a repository with a specified level of access. If the repository is owned by an organization, this API does not add the user to the organization - a user that has repository access without being an organization member is called an "outside collaborator" (if they are not an Enterprise Managed User) or a "repository collaborator" if they are an Enterprise Managed User. These users are exempt from some organization policies - see "[Adding outside collaborators to repositories](https://docs.github.com/organizations/managing-user-access-to-your-organizations-repositories/managing-outside-collaborators/adding-outside-collaborators-to-repositories-in-your-organization)" to learn more about these collaborator types.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications).<br/>
        /// Adding an outside collaborator may be restricted by enterprise and organization administrators. For more information, see "[Enforcing repository management policies in your enterprise](https://docs.github.com/admin/policies/enforcing-policies-for-your-enterprise/enforcing-repository-management-policies-in-your-enterprise#enforcing-a-policy-for-inviting-outside-collaborators-to-repositories)" and "[Setting permissions for adding outside collaborators](https://docs.github.com/organizations/managing-organization-settings/setting-permissions-for-adding-outside-collaborators)" for organization settings.<br/>
        /// For more information on permission levels, see "[Repository permission levels for an organization](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/repository-permission-levels-for-an-organization#permission-levels-for-repositories-owned-by-an-organization)". There are restrictions on which permissions can be granted to organization members when an organization base role is in place. In this case, the role being given must be equal to or higher than the org base permission. Otherwise, the request will fail with:<br/>
        /// ```<br/>
        /// Cannot assign {member} permission of {role name}<br/>
        /// ```<br/>
        /// Note that, if you choose not to pass any parameters, you'll need to set `Content-Length` to zero when calling out to this endpoint. For more information, see "[HTTP method](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#http-method)."<br/>
        /// The invitee will receive a notification that they have been invited to the repository, which they must accept or decline. They may do this via the notifications page, the email they receive, or by using the [API](https://docs.github.com/rest/collaborators/invitations).<br/>
        /// For Enterprise Managed Users, this endpoint does not send invitations - these users are automatically added to organizations and repositories. Enterprise Managed Users can only be added to organizations and repositories within their enterprise.<br/>
        /// **Updating an existing collaborator's permission level**<br/>
        /// The endpoint can also be used to change the permissions of an existing collaborator without first removing and re-adding the collaborator. To change the permissions, use the same endpoint and pass a different `permission` parameter. The response will be a `204`, with no other indication that the permission level changed.<br/>
        /// **Rate limits**<br/>
        /// You are limited to sending 50 invitations to a repository per 24 hour period. Note there is no limit if you are inviting organization members to an organization repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="username"></param>
        /// <param name="permission">
        /// The permission to grant the collaborator. **Only valid on organization-owned repositories.** We accept the following permissions to be set: `pull`, `triage`, `push`, `maintain`, `admin` and you can also specify a custom repository role name, if the owning organization has defined any.<br/>
        /// Default Value: push
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.RepositoryInvitation> ReposAddCollaboratorAsync(
            string owner,
            string repo,
            string username,
            string? permission = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}