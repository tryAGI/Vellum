#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FolderEntity : global::System.IEquatable<FolderEntity>
    {
        /// <summary>
        /// A slim representation of a Folder, as it exists within another Folder.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FolderEntityFolder? FolderEntityFolder { get; init; }
#else
        public global::Vellum.FolderEntityFolder? FolderEntityFolder { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FolderEntityFolder))]
#endif
        public bool IsFolderEntityFolder => FolderEntityFolder != null;

        /// <summary>
        /// A slim representation of a Prompt Sandbox, as it exists within a Folder.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FolderEntityPromptSandbox? FolderEntityPromptSandbox { get; init; }
#else
        public global::Vellum.FolderEntityPromptSandbox? FolderEntityPromptSandbox { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FolderEntityPromptSandbox))]
#endif
        public bool IsFolderEntityPromptSandbox => FolderEntityPromptSandbox != null;

        /// <summary>
        /// A slim representation of a Workflow Sandbox, as it exists within a Folder.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FolderEntityWorkflowSandbox? FolderEntityWorkflowSandbox { get; init; }
#else
        public global::Vellum.FolderEntityWorkflowSandbox? FolderEntityWorkflowSandbox { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FolderEntityWorkflowSandbox))]
#endif
        public bool IsFolderEntityWorkflowSandbox => FolderEntityWorkflowSandbox != null;

        /// <summary>
        /// A slim representation of a Document Index, as it exists within a Folder.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FolderEntityDocumentIndex? FolderEntityDocumentIndex { get; init; }
#else
        public global::Vellum.FolderEntityDocumentIndex? FolderEntityDocumentIndex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FolderEntityDocumentIndex))]
#endif
        public bool IsFolderEntityDocumentIndex => FolderEntityDocumentIndex != null;

        /// <summary>
        /// A slim representation of a Test Suite, as it exists within a Folder.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FolderEntityTestSuite? FolderEntityTestSuite { get; init; }
#else
        public global::Vellum.FolderEntityTestSuite? FolderEntityTestSuite { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FolderEntityTestSuite))]
#endif
        public bool IsFolderEntityTestSuite => FolderEntityTestSuite != null;

        /// <summary>
        /// A slim representation of a Dataset, as it exists within a Folder.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FolderEntityDataset? FolderEntityDataset { get; init; }
#else
        public global::Vellum.FolderEntityDataset? FolderEntityDataset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FolderEntityDataset))]
#endif
        public bool IsFolderEntityDataset => FolderEntityDataset != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FolderEntity(global::Vellum.FolderEntityFolder value) => new FolderEntity((global::Vellum.FolderEntityFolder?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FolderEntityFolder?(FolderEntity @this) => @this.FolderEntityFolder;

        /// <summary>
        /// 
        /// </summary>
        public FolderEntity(global::Vellum.FolderEntityFolder? value)
        {
            FolderEntityFolder = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FolderEntity(global::Vellum.FolderEntityPromptSandbox value) => new FolderEntity((global::Vellum.FolderEntityPromptSandbox?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FolderEntityPromptSandbox?(FolderEntity @this) => @this.FolderEntityPromptSandbox;

        /// <summary>
        /// 
        /// </summary>
        public FolderEntity(global::Vellum.FolderEntityPromptSandbox? value)
        {
            FolderEntityPromptSandbox = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FolderEntity(global::Vellum.FolderEntityWorkflowSandbox value) => new FolderEntity((global::Vellum.FolderEntityWorkflowSandbox?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FolderEntityWorkflowSandbox?(FolderEntity @this) => @this.FolderEntityWorkflowSandbox;

        /// <summary>
        /// 
        /// </summary>
        public FolderEntity(global::Vellum.FolderEntityWorkflowSandbox? value)
        {
            FolderEntityWorkflowSandbox = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FolderEntity(global::Vellum.FolderEntityDocumentIndex value) => new FolderEntity((global::Vellum.FolderEntityDocumentIndex?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FolderEntityDocumentIndex?(FolderEntity @this) => @this.FolderEntityDocumentIndex;

        /// <summary>
        /// 
        /// </summary>
        public FolderEntity(global::Vellum.FolderEntityDocumentIndex? value)
        {
            FolderEntityDocumentIndex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FolderEntity(global::Vellum.FolderEntityTestSuite value) => new FolderEntity((global::Vellum.FolderEntityTestSuite?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FolderEntityTestSuite?(FolderEntity @this) => @this.FolderEntityTestSuite;

        /// <summary>
        /// 
        /// </summary>
        public FolderEntity(global::Vellum.FolderEntityTestSuite? value)
        {
            FolderEntityTestSuite = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FolderEntity(global::Vellum.FolderEntityDataset value) => new FolderEntity((global::Vellum.FolderEntityDataset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FolderEntityDataset?(FolderEntity @this) => @this.FolderEntityDataset;

        /// <summary>
        /// 
        /// </summary>
        public FolderEntity(global::Vellum.FolderEntityDataset? value)
        {
            FolderEntityDataset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FolderEntity(
            global::Vellum.FolderEntityFolder? folderEntityFolder,
            global::Vellum.FolderEntityPromptSandbox? folderEntityPromptSandbox,
            global::Vellum.FolderEntityWorkflowSandbox? folderEntityWorkflowSandbox,
            global::Vellum.FolderEntityDocumentIndex? folderEntityDocumentIndex,
            global::Vellum.FolderEntityTestSuite? folderEntityTestSuite,
            global::Vellum.FolderEntityDataset? folderEntityDataset
            )
        {
            FolderEntityFolder = folderEntityFolder;
            FolderEntityPromptSandbox = folderEntityPromptSandbox;
            FolderEntityWorkflowSandbox = folderEntityWorkflowSandbox;
            FolderEntityDocumentIndex = folderEntityDocumentIndex;
            FolderEntityTestSuite = folderEntityTestSuite;
            FolderEntityDataset = folderEntityDataset;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FolderEntityDataset as object ??
            FolderEntityTestSuite as object ??
            FolderEntityDocumentIndex as object ??
            FolderEntityWorkflowSandbox as object ??
            FolderEntityPromptSandbox as object ??
            FolderEntityFolder as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FolderEntityFolder?.ToString() ??
            FolderEntityPromptSandbox?.ToString() ??
            FolderEntityWorkflowSandbox?.ToString() ??
            FolderEntityDocumentIndex?.ToString() ??
            FolderEntityTestSuite?.ToString() ??
            FolderEntityDataset?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFolderEntityFolder && !IsFolderEntityPromptSandbox && !IsFolderEntityWorkflowSandbox && !IsFolderEntityDocumentIndex && !IsFolderEntityTestSuite && !IsFolderEntityDataset || !IsFolderEntityFolder && IsFolderEntityPromptSandbox && !IsFolderEntityWorkflowSandbox && !IsFolderEntityDocumentIndex && !IsFolderEntityTestSuite && !IsFolderEntityDataset || !IsFolderEntityFolder && !IsFolderEntityPromptSandbox && IsFolderEntityWorkflowSandbox && !IsFolderEntityDocumentIndex && !IsFolderEntityTestSuite && !IsFolderEntityDataset || !IsFolderEntityFolder && !IsFolderEntityPromptSandbox && !IsFolderEntityWorkflowSandbox && IsFolderEntityDocumentIndex && !IsFolderEntityTestSuite && !IsFolderEntityDataset || !IsFolderEntityFolder && !IsFolderEntityPromptSandbox && !IsFolderEntityWorkflowSandbox && !IsFolderEntityDocumentIndex && IsFolderEntityTestSuite && !IsFolderEntityDataset || !IsFolderEntityFolder && !IsFolderEntityPromptSandbox && !IsFolderEntityWorkflowSandbox && !IsFolderEntityDocumentIndex && !IsFolderEntityTestSuite && IsFolderEntityDataset;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.FolderEntityFolder?, TResult>? folderEntityFolder = null,
            global::System.Func<global::Vellum.FolderEntityPromptSandbox?, TResult>? folderEntityPromptSandbox = null,
            global::System.Func<global::Vellum.FolderEntityWorkflowSandbox?, TResult>? folderEntityWorkflowSandbox = null,
            global::System.Func<global::Vellum.FolderEntityDocumentIndex?, TResult>? folderEntityDocumentIndex = null,
            global::System.Func<global::Vellum.FolderEntityTestSuite?, TResult>? folderEntityTestSuite = null,
            global::System.Func<global::Vellum.FolderEntityDataset?, TResult>? folderEntityDataset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFolderEntityFolder && folderEntityFolder != null)
            {
                return folderEntityFolder(FolderEntityFolder!);
            }
            else if (IsFolderEntityPromptSandbox && folderEntityPromptSandbox != null)
            {
                return folderEntityPromptSandbox(FolderEntityPromptSandbox!);
            }
            else if (IsFolderEntityWorkflowSandbox && folderEntityWorkflowSandbox != null)
            {
                return folderEntityWorkflowSandbox(FolderEntityWorkflowSandbox!);
            }
            else if (IsFolderEntityDocumentIndex && folderEntityDocumentIndex != null)
            {
                return folderEntityDocumentIndex(FolderEntityDocumentIndex!);
            }
            else if (IsFolderEntityTestSuite && folderEntityTestSuite != null)
            {
                return folderEntityTestSuite(FolderEntityTestSuite!);
            }
            else if (IsFolderEntityDataset && folderEntityDataset != null)
            {
                return folderEntityDataset(FolderEntityDataset!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.FolderEntityFolder?>? folderEntityFolder = null,
            global::System.Action<global::Vellum.FolderEntityPromptSandbox?>? folderEntityPromptSandbox = null,
            global::System.Action<global::Vellum.FolderEntityWorkflowSandbox?>? folderEntityWorkflowSandbox = null,
            global::System.Action<global::Vellum.FolderEntityDocumentIndex?>? folderEntityDocumentIndex = null,
            global::System.Action<global::Vellum.FolderEntityTestSuite?>? folderEntityTestSuite = null,
            global::System.Action<global::Vellum.FolderEntityDataset?>? folderEntityDataset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFolderEntityFolder)
            {
                folderEntityFolder?.Invoke(FolderEntityFolder!);
            }
            else if (IsFolderEntityPromptSandbox)
            {
                folderEntityPromptSandbox?.Invoke(FolderEntityPromptSandbox!);
            }
            else if (IsFolderEntityWorkflowSandbox)
            {
                folderEntityWorkflowSandbox?.Invoke(FolderEntityWorkflowSandbox!);
            }
            else if (IsFolderEntityDocumentIndex)
            {
                folderEntityDocumentIndex?.Invoke(FolderEntityDocumentIndex!);
            }
            else if (IsFolderEntityTestSuite)
            {
                folderEntityTestSuite?.Invoke(FolderEntityTestSuite!);
            }
            else if (IsFolderEntityDataset)
            {
                folderEntityDataset?.Invoke(FolderEntityDataset!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FolderEntityFolder,
                typeof(global::Vellum.FolderEntityFolder),
                FolderEntityPromptSandbox,
                typeof(global::Vellum.FolderEntityPromptSandbox),
                FolderEntityWorkflowSandbox,
                typeof(global::Vellum.FolderEntityWorkflowSandbox),
                FolderEntityDocumentIndex,
                typeof(global::Vellum.FolderEntityDocumentIndex),
                FolderEntityTestSuite,
                typeof(global::Vellum.FolderEntityTestSuite),
                FolderEntityDataset,
                typeof(global::Vellum.FolderEntityDataset),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(FolderEntity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FolderEntityFolder?>.Default.Equals(FolderEntityFolder, other.FolderEntityFolder) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FolderEntityPromptSandbox?>.Default.Equals(FolderEntityPromptSandbox, other.FolderEntityPromptSandbox) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FolderEntityWorkflowSandbox?>.Default.Equals(FolderEntityWorkflowSandbox, other.FolderEntityWorkflowSandbox) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FolderEntityDocumentIndex?>.Default.Equals(FolderEntityDocumentIndex, other.FolderEntityDocumentIndex) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FolderEntityTestSuite?>.Default.Equals(FolderEntityTestSuite, other.FolderEntityTestSuite) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FolderEntityDataset?>.Default.Equals(FolderEntityDataset, other.FolderEntityDataset) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FolderEntity obj1, FolderEntity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FolderEntity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FolderEntity obj1, FolderEntity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FolderEntity o && Equals(o);
        }
    }
}
