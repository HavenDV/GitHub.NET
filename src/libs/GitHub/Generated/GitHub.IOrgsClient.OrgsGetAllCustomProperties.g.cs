#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get all custom properties for an organization<br/>
        /// Gets all custom properties defined for an organization.<br/>
        /// Organization members can read these properties.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.CustomProperty>> OrgsGetAllCustomPropertiesAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}