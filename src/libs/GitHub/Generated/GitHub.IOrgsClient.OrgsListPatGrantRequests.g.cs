#nullable enable

namespace GitHub
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List requests to access organization resources with fine-grained personal access tokens<br/>
        /// Lists requests from organization members to access organization resources with a fine-grained personal access token.<br/>
        /// Only GitHub Apps can use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="sort">
        /// Default Value: created_at
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="owner">
        /// Example: owner[]=octocat1,owner[]=octocat2
        /// </param>
        /// <param name="repository">
        /// Example: Hello-World
        /// </param>
        /// <param name="permission">
        /// Example: issues_read
        /// </param>
        /// <param name="lastUsedBefore"></param>
        /// <param name="lastUsedAfter"></param>
        /// <param name="tokenId">
        /// Example: token_id[]=1,token_id[]=2
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.OrganizationProgrammaticAccessGrantRequest>> OrgsListPatGrantRequestsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::GitHub.OrgsListPatGrantRequestsSort? sort = default,
            global::GitHub.OrgsListPatGrantRequestsDirection? direction = default,
            global::System.Collections.Generic.IList<string>? owner = default,
            string? repository = default,
            string? permission = default,
            global::System.DateTime? lastUsedBefore = default,
            global::System.DateTime? lastUsedAfter = default,
            global::System.Collections.Generic.IList<string>? tokenId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}