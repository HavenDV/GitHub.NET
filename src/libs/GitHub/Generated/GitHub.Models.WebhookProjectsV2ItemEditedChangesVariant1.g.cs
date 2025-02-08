
#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemEditedChangesVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.WebhookProjectsV2ItemEditedChangesVariant1FieldValue FieldValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEditedChangesVariant1" /> class.
        /// </summary>
        /// <param name="fieldValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookProjectsV2ItemEditedChangesVariant1(
            global::GitHub.WebhookProjectsV2ItemEditedChangesVariant1FieldValue fieldValue)
        {
            this.FieldValue = fieldValue ?? throw new global::System.ArgumentNullException(nameof(fieldValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEditedChangesVariant1" /> class.
        /// </summary>
        public WebhookProjectsV2ItemEditedChangesVariant1()
        {
        }
    }
}