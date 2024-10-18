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


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ReposGetContentResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ReposGetContentResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.ReposGetContentResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>? collectionsGenericIList<global::GitHubDirectoryItem> = default;
            if (discriminator?.Type == global::GitHub.ReposGetContentResponseDiscriminatorType.)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.ContentFile? file = default;
            if (discriminator?.Type == global::GitHub.ReposGetContentResponseDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentFile> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.ContentFile)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.ContentSymlink? symlink = default;
            if (discriminator?.Type == global::GitHub.ReposGetContentResponseDiscriminatorType.Symlink)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentSymlink), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentSymlink> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.ContentSymlink)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::GitHub.ContentSubmodule? submodule = default;
            if (discriminator?.Type == global::GitHub.ReposGetContentResponseDiscriminatorType.Submodule)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::GitHub.ContentSubmodule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::GitHub.ContentSubmodule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::GitHub.ContentSubmodule)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::GitHub.ReposGetContentResponse(
                discriminator?.Type,
                collectionsGenericIList<global::GitHubDirectoryItem>,
                file,
                symlink,
                submodule
                );

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

            if (value.IsCollections.Generic.IList<global::GitHub.DirectoryItem>)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Collections.Generic.IList<global::GitHub.DirectoryItem>, typeInfo);
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