#nullable enable

namespace GitHub
{
    public partial interface IClassroomClient
    {
        /// <summary>
        /// Get a classroom<br/>
        /// Gets a GitHub Classroom classroom for the current user. Classroom will only be returned if the current user is an administrator of the GitHub Classroom.
        /// </summary>
        /// <param name="classroomId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.Classroom> ClassroomGetAClassroomAsync(
            int classroomId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}