
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsForkPrContributorApproval
    {
        /// <summary>
        /// The policy that controls when fork PR workflows require approval from a maintainer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.ActionsForkPrContributorApprovalApprovalPolicyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.ActionsForkPrContributorApprovalApprovalPolicy ApprovalPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsForkPrContributorApproval" /> class.
        /// </summary>
        /// <param name="approvalPolicy">
        /// The policy that controls when fork PR workflows require approval from a maintainer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionsForkPrContributorApproval(
            global::GitHub.ActionsForkPrContributorApprovalApprovalPolicy approvalPolicy)
        {
            this.ApprovalPolicy = approvalPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsForkPrContributorApproval" /> class.
        /// </summary>
        public ActionsForkPrContributorApproval()
        {
        }
    }
}