
#nullable enable

namespace GitHub
{
    public partial class TeamsClient
    {
        partial void PrepareTeamsDeleteInOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string teamSlug);
        partial void PrepareTeamsDeleteInOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string teamSlug);
        partial void ProcessTeamsDeleteInOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Delete a team<br/>
        /// To delete a team, the authenticated user must be an organization owner or team maintainer.<br/>
        /// If you are an organization owner, deleting a parent team will delete all of its child teams as well.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task TeamsDeleteInOrgAsync(
            string org,
            string teamSlug,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareTeamsDeleteInOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                teamSlug: ref teamSlug);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/teams/{teamSlug}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTeamsDeleteInOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                teamSlug: teamSlug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTeamsDeleteInOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}