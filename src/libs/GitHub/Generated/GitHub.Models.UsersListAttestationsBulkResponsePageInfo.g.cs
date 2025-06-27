
#nullable enable

namespace GitHub
{
    /// <summary>
    /// Information about the current page.
    /// </summary>
    public sealed partial class UsersListAttestationsBulkResponsePageInfo
    {
        /// <summary>
        /// Indicates whether there is a next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next")]
        public bool? HasNext { get; set; }

        /// <summary>
        /// Indicates whether there is a previous page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_previous")]
        public bool? HasPrevious { get; set; }

        /// <summary>
        /// The cursor to the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The cursor to the previous page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsBulkResponsePageInfo" /> class.
        /// </summary>
        /// <param name="hasNext">
        /// Indicates whether there is a next page.
        /// </param>
        /// <param name="hasPrevious">
        /// Indicates whether there is a previous page.
        /// </param>
        /// <param name="next">
        /// The cursor to the next page.
        /// </param>
        /// <param name="previous">
        /// The cursor to the previous page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersListAttestationsBulkResponsePageInfo(
            bool? hasNext,
            bool? hasPrevious,
            string? next,
            string? previous)
        {
            this.HasNext = hasNext;
            this.HasPrevious = hasPrevious;
            this.Next = next;
            this.Previous = previous;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersListAttestationsBulkResponsePageInfo" /> class.
        /// </summary>
        public UsersListAttestationsBulkResponsePageInfo()
        {
        }
    }
}