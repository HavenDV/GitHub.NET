
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivateRegistriesListOrgPrivateRegistriesResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("configurations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.OrgPrivateRegistryConfiguration> Configurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRegistriesListOrgPrivateRegistriesResponse" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="configurations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateRegistriesListOrgPrivateRegistriesResponse(
            int totalCount,
            global::System.Collections.Generic.IList<global::GitHub.OrgPrivateRegistryConfiguration> configurations)
        {
            this.TotalCount = totalCount;
            this.Configurations = configurations ?? throw new global::System.ArgumentNullException(nameof(configurations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateRegistriesListOrgPrivateRegistriesResponse" /> class.
        /// </summary>
        public PrivateRegistriesListOrgPrivateRegistriesResponse()
        {
        }
    }
}