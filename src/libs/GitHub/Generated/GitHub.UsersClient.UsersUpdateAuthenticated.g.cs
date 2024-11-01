
#nullable enable

namespace GitHub
{
    public partial class UsersClient
    {
        partial void PrepareUsersUpdateAuthenticatedArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::GitHub.UsersUpdateAuthenticatedRequest request);
        partial void PrepareUsersUpdateAuthenticatedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::GitHub.UsersUpdateAuthenticatedRequest request);
        partial void ProcessUsersUpdateAuthenticatedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersUpdateAuthenticatedResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update the authenticated user<br/>
        /// **Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.PrivateUser> UsersUpdateAuthenticatedAsync(
            global::GitHub.UsersUpdateAuthenticatedRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUsersUpdateAuthenticatedArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/user",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareUsersUpdateAuthenticatedRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUsersUpdateAuthenticatedResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUsersUpdateAuthenticatedResponseContent(
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
                global::GitHub.PrivateUser.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update the authenticated user<br/>
        /// **Note:** If your email is set to private and you send an `email` parameter as part of this request to update your profile, your privacy settings are still enforced: the email address will not be displayed on your public profile or via the API.
        /// </summary>
        /// <param name="name">
        /// The new name of the user.<br/>
        /// Example: Omar Jahandar
        /// </param>
        /// <param name="email">
        /// The publicly visible email address of the user.<br/>
        /// Example: omar@example.com
        /// </param>
        /// <param name="blog">
        /// The new blog URL of the user.<br/>
        /// Example: blog.example.com
        /// </param>
        /// <param name="twitterUsername">
        /// The new Twitter username of the user.<br/>
        /// Example: therealomarj
        /// </param>
        /// <param name="company">
        /// The new company of the user.<br/>
        /// Example: Acme corporation
        /// </param>
        /// <param name="location">
        /// The new location of the user.<br/>
        /// Example: Berlin, Germany
        /// </param>
        /// <param name="hireable">
        /// The new hiring availability of the user.
        /// </param>
        /// <param name="bio">
        /// The new short biography of the user.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.PrivateUser> UsersUpdateAuthenticatedAsync(
            string? name = default,
            string? email = default,
            string? blog = default,
            string? twitterUsername = default,
            string? company = default,
            string? location = default,
            bool? hireable = default,
            string? bio = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::GitHub.UsersUpdateAuthenticatedRequest
            {
                Name = name,
                Email = email,
                Blog = blog,
                TwitterUsername = twitterUsername,
                Company = company,
                Location = location,
                Hireable = hireable,
                Bio = bio,
            };

            return await UsersUpdateAuthenticatedAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}