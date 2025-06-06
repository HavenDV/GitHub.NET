
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamOrganizationPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("space")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Space { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PrivateRepos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filled_seats")]
        public int? FilledSeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seats")]
        public int? Seats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamOrganizationPlan" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="space"></param>
        /// <param name="privateRepos"></param>
        /// <param name="filledSeats"></param>
        /// <param name="seats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamOrganizationPlan(
            string name,
            int space,
            int privateRepos,
            int? filledSeats,
            int? seats)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Space = space;
            this.PrivateRepos = privateRepos;
            this.FilledSeats = filledSeats;
            this.Seats = seats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamOrganizationPlan" /> class.
        /// </summary>
        public TeamOrganizationPlan()
        {
        }
    }
}