
#nullable enable

namespace GitHub
{
    public partial class EnterpriseTeamMembershipsClient
    {
        partial void PrepareEnterpriseTeamMembershipsBulkRemoveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string enterprise,
            ref string enterpriseTeam,
            global::GitHub.EnterpriseTeamMembershipsBulkRemoveRequest request);
        partial void PrepareEnterpriseTeamMembershipsBulkRemoveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string enterprise,
            string enterpriseTeam,
            global::GitHub.EnterpriseTeamMembershipsBulkRemoveRequest request);
        partial void ProcessEnterpriseTeamMembershipsBulkRemoveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEnterpriseTeamMembershipsBulkRemoveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Bulk remove team members<br/>
        /// Remove multiple team members from an enterprise team.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.SimpleUser>> EnterpriseTeamMembershipsBulkRemoveAsync(
            string enterprise,
            string enterpriseTeam,
            global::GitHub.EnterpriseTeamMembershipsBulkRemoveRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEnterpriseTeamMembershipsBulkRemoveArguments(
                httpClient: HttpClient,
                enterprise: ref enterprise,
                enterpriseTeam: ref enterpriseTeam,
                request: request);

            var __pathBuilder = new global::GitHub.PathBuilder(
                path: $"/enterprises/{enterprise}/teams/{enterpriseTeam}/memberships/remove",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEnterpriseTeamMembershipsBulkRemoveRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                enterprise: enterprise,
                enterpriseTeam: enterpriseTeam,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEnterpriseTeamMembershipsBulkRemoveResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessEnterpriseTeamMembershipsBulkRemoveResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.SimpleUser>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.SimpleUser> ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::GitHub.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.SimpleUser>), JsonSerializerContext).ConfigureAwait(false) as global::System.Collections.Generic.IList<global::GitHub.SimpleUser> ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::GitHub.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Bulk remove team members<br/>
        /// Remove multiple team members from an enterprise team.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="enterpriseTeam"></param>
        /// <param name="usernames">
        /// The GitHub user handles to be removed from the team.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.SimpleUser>> EnterpriseTeamMembershipsBulkRemoveAsync(
            string enterprise,
            string enterpriseTeam,
            global::System.Collections.Generic.IList<string> usernames,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.EnterpriseTeamMembershipsBulkRemoveRequest
            {
                Usernames = usernames,
            };

            return await EnterpriseTeamMembershipsBulkRemoveAsync(
                enterprise: enterprise,
                enterpriseTeam: enterpriseTeam,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}