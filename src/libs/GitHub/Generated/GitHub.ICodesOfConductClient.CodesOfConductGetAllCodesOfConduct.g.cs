#nullable enable

namespace GitHub
{
    public partial interface ICodesOfConductClient
    {
        /// <summary>
        /// Get all codes of conduct<br/>
        /// Returns array of all GitHub's codes of conduct.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CodeOfConduct>> CodesOfConductGetAllCodesOfConductAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}