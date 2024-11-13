#nullable enable

namespace GitHub
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get the Zen of GitHub<br/>
        /// Get a random sentence from the Zen of GitHub
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetaGetZenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}