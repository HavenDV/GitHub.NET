
#nullable enable

namespace GitHub
{
    public partial class MigrationsClient
    {
        partial void PrepareMigrationsStartForOrgArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            global::GitHub.MigrationsStartForOrgRequest request);
        partial void PrepareMigrationsStartForOrgRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            global::GitHub.MigrationsStartForOrgRequest request);
        partial void ProcessMigrationsStartForOrgResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMigrationsStartForOrgResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Start an organization migration<br/>
        /// Initiates the generation of a migration archive.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.Migration> MigrationsStartForOrgAsync(
            string org,
            global::GitHub.MigrationsStartForOrgRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMigrationsStartForOrgArguments(
                httpClient: HttpClient,
                org: ref org,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/migrations",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMigrationsStartForOrgRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMigrationsStartForOrgResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessMigrationsStartForOrgResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::GitHub.Migration.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Start an organization migration<br/>
        /// Initiates the generation of a migration archive.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="repositories">
        /// A list of arrays indicating which repositories should be migrated.
        /// </param>
        /// <param name="lockRepositories">
        /// Indicates whether repositories should be locked (to prevent manipulation) while migrating data.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeMetadata">
        /// Indicates whether metadata should be excluded and only git source should be included for the migration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeGitData">
        /// Indicates whether the repository git data should be excluded from the migration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="excludeAttachments">
        /// Indicates whether attachments should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeReleases">
        /// Indicates whether releases should be excluded from the migration (to reduce migration archive file size).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="excludeOwnerProjects">
        /// Indicates whether projects owned by the organization or users should be excluded. from the migration.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="orgMetadataOnly">
        /// Indicates whether this should only include organization metadata (repositories array should be empty and will ignore other flags).<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="exclude">
        /// Exclude related items from being returned in the response in order to improve performance of the request.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.Migration> MigrationsStartForOrgAsync(
            string org,
            global::System.Collections.Generic.IList<string> repositories,
            bool? lockRepositories = default,
            bool? excludeMetadata = default,
            bool? excludeGitData = default,
            bool? excludeAttachments = default,
            bool? excludeReleases = default,
            bool? excludeOwnerProjects = default,
            bool? orgMetadataOnly = default,
            global::System.Collections.Generic.IList<global::GitHub.MigrationsStartForOrgRequestExcludeItem>? exclude = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.MigrationsStartForOrgRequest
            {
                Repositories = repositories,
                LockRepositories = lockRepositories,
                ExcludeMetadata = excludeMetadata,
                ExcludeGitData = excludeGitData,
                ExcludeAttachments = excludeAttachments,
                ExcludeReleases = excludeReleases,
                ExcludeOwnerProjects = excludeOwnerProjects,
                OrgMetadataOnly = orgMetadataOnly,
                Exclude = exclude,
            };

            return await MigrationsStartForOrgAsync(
                org: org,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}