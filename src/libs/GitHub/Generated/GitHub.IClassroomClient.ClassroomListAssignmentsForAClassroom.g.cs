#nullable enable

namespace GitHub
{
    public partial interface IClassroomClient
    {
        /// <summary>
        /// List assignments for a classroom<br/>
        /// Lists GitHub Classroom assignments for a classroom. Assignments will only be returned if the current user is an administrator of the GitHub Classroom.
        /// </summary>
        /// <param name="classroomId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.SimpleClassroomAssignment>> ClassroomListAssignmentsForAClassroomAsync(
            int classroomId,
            int? page = 1,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}