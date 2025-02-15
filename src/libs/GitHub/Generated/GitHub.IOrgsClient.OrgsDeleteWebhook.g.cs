#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete an organization webhook<br/>
        /// Delete a webhook for an organization.<br/>
        /// The authenticated user must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit<br/>
        /// webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task OrgsDeleteWebhookAsync(
            string org,
            int hookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}