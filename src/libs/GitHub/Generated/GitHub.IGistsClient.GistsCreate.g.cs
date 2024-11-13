#nullable enable

namespace GitHub
{
    public partial interface IGistsClient
    {
        /// <summary>
        /// Create a gist<br/>
        /// Allows you to add a new gist with one or more files.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Don't name your files "gistfile" with a numerical suffix. This is the format of the automatic naming scheme that Gist uses internally.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.GistSimple> GistsCreateAsync(
            global::GitHub.GistsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a gist<br/>
        /// Allows you to add a new gist with one or more files.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Don't name your files "gistfile" with a numerical suffix. This is the format of the automatic naming scheme that Gist uses internally.
        /// </summary>
        /// <param name="description">
        /// Description of the gist<br/>
        /// Example: Example Ruby script
        /// </param>
        /// <param name="files">
        /// Names and content for the files that make up the gist
        /// </param>
        /// <param name="public"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.GistSimple> GistsCreateAsync(
            global::System.Collections.Generic.Dictionary<string, global::GitHub.GistsCreateRequestFiles2> files,
            string? description = default,
            global::GitHub.OneOf<bool?, global::GitHub.GistsCreateRequestPublic?>? @public = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}