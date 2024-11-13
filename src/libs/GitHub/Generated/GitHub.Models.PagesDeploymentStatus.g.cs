
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagesDeploymentStatus
    {
        /// <summary>
        /// The current status of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.PagesDeploymentStatusStatusJsonConverter))]
        public global::GitHub.PagesDeploymentStatusStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesDeploymentStatus" /> class.
        /// </summary>
        /// <param name="status">
        /// The current status of the deployment.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PagesDeploymentStatus(
            global::GitHub.PagesDeploymentStatusStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesDeploymentStatus" /> class.
        /// </summary>
        public PagesDeploymentStatus()
        {
        }
    }
}