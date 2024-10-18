#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Download a repository archive (tar)<br/>
        /// Gets a redirect URL to download a tar archive for a repository. If you omit `:ref`, the repository’s default branch (usually<br/>
        /// `main`) will be used. Please make sure your HTTP framework is configured to follow redirects or you will need to use<br/>
        /// the `Location` header to make a second `GET` request.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; For private repositories, these links are temporary and expire after five minutes.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ReposDownloadTarballArchiveAsync(
            string owner,
            string repo,
            string @ref,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}