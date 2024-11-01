
#nullable enable

namespace GitHub
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListWebhookDeliveriesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int hookId,
            ref int? perPage,
            ref string? cursor);
        partial void PrepareOrgsListWebhookDeliveriesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int hookId,
            int? perPage,
            string? cursor);
        partial void ProcessOrgsListWebhookDeliveriesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListWebhookDeliveriesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List deliveries for an organization webhook<br/>
        /// Returns a list of webhook deliveries for a webhook configured in an organization.<br/>
        /// You must be an organization owner to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need `admin:org_hook` scope. OAuth apps cannot list, view, or edit<br/>
        /// webhooks that they did not create and users cannot list, view, or edit webhooks that were created by OAuth apps.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="hookId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.HookDeliveryItem>> OrgsListWebhookDeliveriesAsync(
            string org,
            int hookId,
            int? perPage = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsListWebhookDeliveriesArguments(
                httpClient: HttpClient,
                org: ref org,
                hookId: ref hookId,
                perPage: ref perPage,
                cursor: ref cursor);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/hooks/{hookId}/deliveries",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("cursor", cursor) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsListWebhookDeliveriesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                hookId: hookId,
                perPage: perPage,
                cursor: cursor);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsListWebhookDeliveriesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsListWebhookDeliveriesResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::GitHub.HookDeliveryItem>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::GitHub.HookDeliveryItem> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}