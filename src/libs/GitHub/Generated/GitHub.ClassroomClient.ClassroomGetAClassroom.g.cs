
#nullable enable

namespace GitHub
{
    public partial class ClassroomClient
    {
        partial void PrepareClassroomGetAClassroomArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int classroomId);
        partial void PrepareClassroomGetAClassroomRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int classroomId);
        partial void ProcessClassroomGetAClassroomResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessClassroomGetAClassroomResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get a classroom<br/>
        /// Gets a GitHub Classroom classroom for the current user. Classroom will only be returned if the current user is an administrator of the GitHub Classroom.
        /// </summary>
        /// <param name="classroomId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::GitHub.Classroom> ClassroomGetAClassroomAsync(
            int classroomId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareClassroomGetAClassroomArguments(
                httpClient: HttpClient,
                classroomId: ref classroomId);

            var __pathBuilder = new PathBuilder(
                path: $"/classrooms/{classroomId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareClassroomGetAClassroomRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                classroomId: classroomId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessClassroomGetAClassroomResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessClassroomGetAClassroomResponseContent(
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
                global::GitHub.Classroom.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}