
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposRemoveTeamAccessRestrictionsRequest2
    {
        /// <summary>
        /// The slug values for teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRemoveTeamAccessRestrictionsRequest2" /> class.
        /// </summary>
        /// <param name="teams">
        /// The slug values for teams
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposRemoveTeamAccessRestrictionsRequest2(
            global::System.Collections.Generic.IList<string> teams)
        {
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRemoveTeamAccessRestrictionsRequest2" /> class.
        /// </summary>
        public ReposRemoveTeamAccessRestrictionsRequest2()
        {
        }
    }
}