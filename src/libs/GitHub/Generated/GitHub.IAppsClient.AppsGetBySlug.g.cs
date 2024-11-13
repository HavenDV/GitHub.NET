#nullable enable

namespace GitHub
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Get an app<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; The `:app_slug` is just the URL-friendly name of your GitHub App. You can find this on the settings page for your GitHub App (e.g., `https://github.com/settings/apps/:app_slug`).
        /// </summary>
        /// <param name="appSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Integration> AppsGetBySlugAsync(
            string appSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}