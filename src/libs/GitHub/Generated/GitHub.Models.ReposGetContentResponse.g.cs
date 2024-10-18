using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace GitHub
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ReposGetContentResponse : global::System.IEquatable<ReposGetContentResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::GitHub.ReposGetContentResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// A list of directory items
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>? Collections.Generic.IList<global::GitHub.DirectoryItem> { get; init; }
#else
        public global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>? Collections.Generic.IList<global::GitHub.DirectoryItem> { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Collections.Generic.IList<global::GitHub.DirectoryItem>))]
#endif
        public bool IsCollections.Generic.IList<global::GitHub.DirectoryItem> => Collections.Generic.IList<global::GitHub.DirectoryItem> != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem> value) => new ReposGetContentResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>?(ReposGetContentResponse @this) => @this.Collections.Generic.IList<global::GitHub.DirectoryItem>;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>? value)
        {
            Collections.Generic.IList<global::GitHub.DirectoryItem> = value;
        }

        /// <summary>
        /// Content File
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ContentFile? File { get; init; }
#else
        public global::GitHub.ContentFile? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::GitHub.ContentFile value) => new ReposGetContentResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ContentFile?(ReposGetContentResponse @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::GitHub.ContentFile? value)
        {
            File = value;
        }

        /// <summary>
        /// An object describing a symlink
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ContentSymlink? Symlink { get; init; }
#else
        public global::GitHub.ContentSymlink? Symlink { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Symlink))]
#endif
        public bool IsSymlink => Symlink != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::GitHub.ContentSymlink value) => new ReposGetContentResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ContentSymlink?(ReposGetContentResponse @this) => @this.Symlink;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::GitHub.ContentSymlink? value)
        {
            Symlink = value;
        }

        /// <summary>
        /// An object describing a submodule
        /// </summary>
#if NET6_0_OR_GREATER
        public global::GitHub.ContentSubmodule? Submodule { get; init; }
#else
        public global::GitHub.ContentSubmodule? Submodule { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Submodule))]
#endif
        public bool IsSubmodule => Submodule != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ReposGetContentResponse(global::GitHub.ContentSubmodule value) => new ReposGetContentResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::GitHub.ContentSubmodule?(ReposGetContentResponse @this) => @this.Submodule;

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(global::GitHub.ContentSubmodule? value)
        {
            Submodule = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ReposGetContentResponse(
            global::GitHub.ReposGetContentResponseDiscriminatorType? type,
            global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>? collectionsGenericIList<global::GitHubDirectoryItem>,
            global::GitHub.ContentFile? file,
            global::GitHub.ContentSymlink? symlink,
            global::GitHub.ContentSubmodule? submodule
            )
        {
            Type = type;

            Collections.Generic.IList<global::GitHub.DirectoryItem> = collectionsGenericIList<global::GitHubDirectoryItem>;
            File = file;
            Symlink = symlink;
            Submodule = submodule;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Submodule as object ??
            Symlink as object ??
            File as object ??
            Collections.Generic.IList<global::GitHub.DirectoryItem> as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCollections.Generic.IList<global::GitHub.DirectoryItem> && !IsFile && !IsSymlink && !IsSubmodule || !IsCollections.Generic.IList<global::GitHub.DirectoryItem> && IsFile && !IsSymlink && !IsSubmodule || !IsCollections.Generic.IList<global::GitHub.DirectoryItem> && !IsFile && IsSymlink && !IsSubmodule || !IsCollections.Generic.IList<global::GitHub.DirectoryItem> && !IsFile && !IsSymlink && IsSubmodule;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>?, TResult>? collectionsGenericIList<global::GitHubDirectoryItem> = null,
            global::System.Func<global::GitHub.ContentFile?, TResult>? file = null,
            global::System.Func<global::GitHub.ContentSymlink?, TResult>? symlink = null,
            global::System.Func<global::GitHub.ContentSubmodule?, TResult>? submodule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollections.Generic.IList<global::GitHub.DirectoryItem> && collectionsGenericIList<global::GitHubDirectoryItem> != null)
            {
                return collectionsGenericIList<global::GitHubDirectoryItem>(Collections.Generic.IList<global::GitHub.DirectoryItem>!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsSymlink && symlink != null)
            {
                return symlink(Symlink!);
            }
            else if (IsSubmodule && submodule != null)
            {
                return submodule(Submodule!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>?>? collectionsGenericIList<global::GitHubDirectoryItem> = null,
            global::System.Action<global::GitHub.ContentFile?>? file = null,
            global::System.Action<global::GitHub.ContentSymlink?>? symlink = null,
            global::System.Action<global::GitHub.ContentSubmodule?>? submodule = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCollections.Generic.IList<global::GitHub.DirectoryItem>)
            {
                collectionsGenericIList<global::GitHubDirectoryItem>?.Invoke(Collections.Generic.IList<global::GitHub.DirectoryItem>!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsSymlink)
            {
                symlink?.Invoke(Symlink!);
            }
            else if (IsSubmodule)
            {
                submodule?.Invoke(Submodule!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Collections.Generic.IList<global::GitHub.DirectoryItem>,
                typeof(global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>),
                File,
                typeof(global::GitHub.ContentFile),
                Symlink,
                typeof(global::GitHub.ContentSymlink),
                Submodule,
                typeof(global::GitHub.ContentSubmodule),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ReposGetContentResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::GitHub.ContentDirectoryItem>?>.Default.Equals(Collections.Generic.IList<global::GitHub.DirectoryItem>, other.Collections.Generic.IList<global::GitHub.DirectoryItem>) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ContentFile?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ContentSymlink?>.Default.Equals(Symlink, other.Symlink) &&
                global::System.Collections.Generic.EqualityComparer<global::GitHub.ContentSubmodule?>.Default.Equals(Submodule, other.Submodule) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ReposGetContentResponse obj1, ReposGetContentResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ReposGetContentResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ReposGetContentResponse obj1, ReposGetContentResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReposGetContentResponse o && Equals(o);
        }


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
        public static global::GitHub.ReposGetContentResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::GitHub.ReposGetContentResponse),
                jsonSerializerContext) as global::GitHub.ReposGetContentResponse?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::GitHub.ReposGetContentResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::GitHub.ReposGetContentResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
