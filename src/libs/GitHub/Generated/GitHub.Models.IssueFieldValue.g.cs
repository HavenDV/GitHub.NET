
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// A value assigned to an issue field
    /// </summary>
    public sealed partial class IssueFieldValue
    {
        /// <summary>
        /// Unique identifier for the issue field.<br/>
        /// Example: 1L
        /// </summary>
        /// <example>1L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_field_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long IssueFieldId { get; set; }

        /// <summary>
        /// Example: IFT_GDKND
        /// </summary>
        /// <example>IFT_GDKND</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The data type of the issue field<br/>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.IssueFieldValueDataTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.IssueFieldValueDataType DataType { get; set; }

        /// <summary>
        /// The value of the issue field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::GitHub.JsonConverters.AnyOfJsonConverter<string, double?, int?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.AnyOf<string, double?, int?>? Value { get; set; }

        /// <summary>
        /// Details about the selected option (only present for single_select fields)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("single_select_option")]
        public global::GitHub.IssueFieldValueSingleSelectOption? SingleSelectOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueFieldValue" /> class.
        /// </summary>
        /// <param name="issueFieldId">
        /// Unique identifier for the issue field.<br/>
        /// Example: 1L
        /// </param>
        /// <param name="nodeId">
        /// Example: IFT_GDKND
        /// </param>
        /// <param name="dataType">
        /// The data type of the issue field<br/>
        /// Example: text
        /// </param>
        /// <param name="value">
        /// The value of the issue field
        /// </param>
        /// <param name="singleSelectOption">
        /// Details about the selected option (only present for single_select fields)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueFieldValue(
            long issueFieldId,
            string nodeId,
            global::GitHub.IssueFieldValueDataType dataType,
            global::GitHub.AnyOf<string, double?, int?>? value,
            global::GitHub.IssueFieldValueSingleSelectOption? singleSelectOption)
        {
            this.IssueFieldId = issueFieldId;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.DataType = dataType;
            this.Value = value;
            this.SingleSelectOption = singleSelectOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueFieldValue" /> class.
        /// </summary>
        public IssueFieldValue()
        {
        }
    }
}