
#nullable enable

namespace GitHub
{
    /// <summary>
    /// A GitHub Classroom accepted assignment
    /// </summary>
    public sealed partial class ClassroomAcceptedAssignment
    {
        /// <summary>
        /// Unique identifier of the repository.<br/>
        /// Example: 42
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Whether an accepted assignment has been submitted.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submitted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Submitted { get; set; }

        /// <summary>
        /// Whether a submission passed.<br/>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passing { get; set; }

        /// <summary>
        /// Count of student commits.<br/>
        /// Example: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommitCount { get; set; }

        /// <summary>
        /// Most recent grade.<br/>
        /// Example: 10/10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grade")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Grade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("students")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::GitHub.SimpleClassroomUser> Students { get; set; }

        /// <summary>
        /// A GitHub repository view for Classroom
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleClassroomRepository Repository { get; set; }

        /// <summary>
        /// A GitHub Classroom assignment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::GitHub.SimpleClassroomAssignment Assignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::GitHub.ClassroomAcceptedAssignment? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.ClassroomAcceptedAssignment),
                jsonSerializerContext) as global::GitHub.ClassroomAcceptedAssignment;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.ClassroomAcceptedAssignment? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.ClassroomAcceptedAssignment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::GitHub.ClassroomAcceptedAssignment?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::GitHub.ClassroomAcceptedAssignment),
                jsonSerializerContext).ConfigureAwait(false)) as global::GitHub.ClassroomAcceptedAssignment;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::GitHub.ClassroomAcceptedAssignment?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::GitHub.ClassroomAcceptedAssignment?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}