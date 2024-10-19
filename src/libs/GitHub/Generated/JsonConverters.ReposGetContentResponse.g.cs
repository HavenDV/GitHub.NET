#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace GitHub.JsonConverters
{
    /// <inheritdoc />
    public class ReposGetContentResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::GitHub.ReposGetContentResponse>
    {
        /// <inheritdoc />
        public override global::GitHub.ReposGetContentResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ContentFile? file = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentFile).Name}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ContentSymlink? symlink = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentSymlink> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentSymlink).Name}");
                symlink = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::GitHub.ContentSubmodule? submodule = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentSubmodule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentSubmodule).Name}");
                submodule = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::GitHub.ReposGetContentResponse(
                value1,
                file,
                symlink,
                submodule
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (file != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentFile).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (symlink != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentSymlink> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentSymlink).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (submodule != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentSubmodule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentSubmodule).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::GitHub.ReposGetContentResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
            else if (value.IsSymlink)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentSymlink?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentSymlink).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Symlink, typeInfo);
            }
            else if (value.IsSubmodule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentSubmodule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::GitHub.ContentSubmodule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Submodule, typeInfo);
            }
        }
    }
}