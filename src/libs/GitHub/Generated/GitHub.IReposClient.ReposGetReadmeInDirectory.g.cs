#nullable enable

namespace GitHub
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Get a repository README for a directory<br/>
        /// Gets the README from a repository directory.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw file contents. This is the default if you do not specify a media type.<br/>
        /// - **`application/vnd.github.html+json`**: Returns the README in HTML. Markup languages are rendered to HTML using GitHub's open-source [Markup library](https://github.com/github/markup).
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="dir"></param>
        /// <param name="ref"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.ContentFile> ReposGetReadmeInDirectoryAsync(
            string owner,
            string repo,
            string dir,
            string? @ref = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}