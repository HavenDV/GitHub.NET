
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGetHostedRunnersPartnerImagesForOrgResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.ActionsHostedRunnerImage> Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetHostedRunnersPartnerImagesForOrgResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="images"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsGetHostedRunnersPartnerImagesForOrgResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::GitHub.ActionsHostedRunnerImage> images)
        {
            this.TotalCount = totalCount;
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsGetHostedRunnersPartnerImagesForOrgResponse" /> class.
        /// </summary>
        public ActionsGetHostedRunnersPartnerImagesForOrgResponse()
        {
        }
    }
}