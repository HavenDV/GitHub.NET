#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Disable Dependabot security updates<br/>
        /// Disables Dependabot security updates for a repository. The authenticated user must have admin access to the repository. For more information, see "[Configuring Dependabot security updates](https://docs.github.com/articles/configuring-automated-security-fixes)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task ReposDisableAutomatedSecurityFixesAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}