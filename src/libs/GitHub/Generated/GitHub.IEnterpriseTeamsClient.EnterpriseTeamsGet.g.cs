#nullable enable

namespace GitHub
{
    public partial interface IEnterpriseTeamsClient
    {
        /// <summary>
        /// Get an enterprise team<br/>
        /// Gets a team using the team's slug. To create the slug, GitHub replaces special characters in the name string, changes all words to lowercase, and replaces spaces with a `-` separator and adds the "ent:" prefix. For example, "My TEam Näme" would become `ent:my-team-name`.
        /// </summary>
        /// <param name="enterprise"></param>
        /// <param name="teamSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::GitHub.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::GitHub.EnterpriseTeam> EnterpriseTeamsGetAsync(
            string enterprise,
            string teamSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}