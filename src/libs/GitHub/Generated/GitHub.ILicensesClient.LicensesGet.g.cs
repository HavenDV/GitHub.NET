#nullable enable

namespace GitHub
{
    public partial interface ILicensesClient
    {
        /// <summary>
        /// Get a license<br/>
        /// Gets information about a specific license. For more information, see "[Licensing a repository ](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/customizing-your-repository/licensing-a-repository)."
        /// </summary>
        /// <param name="license"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.License> LicensesGetAsync(
            string license,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}