#nullable enable

namespace GitHub
{
    public partial interface IClassroomClient
    {
        /// <summary>
        /// Get assignment grades<br/>
        /// Gets grades for a GitHub Classroom assignment. Grades will only be returned if the current user is an administrator of the GitHub Classroom for the assignment.
        /// </summary>
        /// <param name="assignmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::GitHub.ClassroomAssignmentGrade>> ClassroomGetAssignmentGradesAsync(
            int assignmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}