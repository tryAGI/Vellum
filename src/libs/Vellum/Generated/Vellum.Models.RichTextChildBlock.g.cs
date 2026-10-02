#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct RichTextChildBlock : global::System.IEquatable<RichTextChildBlock>
    {
        /// <summary>
        /// A block that represents a variable in a prompt template.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VariablePromptBlock? VariablePromptBlock { get; init; }
#else
        public global::Vellum.VariablePromptBlock? VariablePromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VariablePromptBlock))]
#endif
        public bool IsVariablePromptBlock => VariablePromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVariablePromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.VariablePromptBlock? value)
        {
            value = VariablePromptBlock;
            return IsVariablePromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VariablePromptBlock PickVariablePromptBlock() => VariablePromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VariablePromptBlock' but the value was {ToString()}.");

        /// <summary>
        /// A block that holds a plain text string value.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.PlainTextPromptBlock? PlainTextPromptBlock { get; init; }
#else
        public global::Vellum.PlainTextPromptBlock? PlainTextPromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlainTextPromptBlock))]
#endif
        public bool IsPlainTextPromptBlock => PlainTextPromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPlainTextPromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.PlainTextPromptBlock? value)
        {
            value = PlainTextPromptBlock;
            return IsPlainTextPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.PlainTextPromptBlock PickPlainTextPromptBlock() => PlainTextPromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PlainTextPromptBlock' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RichTextChildBlock(global::Vellum.VariablePromptBlock value) => new RichTextChildBlock((global::Vellum.VariablePromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.VariablePromptBlock?(RichTextChildBlock @this) => @this.VariablePromptBlock;

        /// <summary>
        ///
        /// </summary>
        public RichTextChildBlock(global::Vellum.VariablePromptBlock? value)
        {
            VariablePromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RichTextChildBlock FromVariablePromptBlock(global::Vellum.VariablePromptBlock? value) => new RichTextChildBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator RichTextChildBlock(global::Vellum.PlainTextPromptBlock value) => new RichTextChildBlock((global::Vellum.PlainTextPromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.PlainTextPromptBlock?(RichTextChildBlock @this) => @this.PlainTextPromptBlock;

        /// <summary>
        ///
        /// </summary>
        public RichTextChildBlock(global::Vellum.PlainTextPromptBlock? value)
        {
            PlainTextPromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RichTextChildBlock FromPlainTextPromptBlock(global::Vellum.PlainTextPromptBlock? value) => new RichTextChildBlock(value);

        /// <summary>
        ///
        /// </summary>
        public RichTextChildBlock(
            global::Vellum.VariablePromptBlock? variablePromptBlock,
            global::Vellum.PlainTextPromptBlock? plainTextPromptBlock
            )
        {
            VariablePromptBlock = variablePromptBlock;
            PlainTextPromptBlock = plainTextPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PlainTextPromptBlock as object ??
            VariablePromptBlock as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            VariablePromptBlock?.ToString() ??
            PlainTextPromptBlock?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVariablePromptBlock && !IsPlainTextPromptBlock || !IsVariablePromptBlock && IsPlainTextPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.VariablePromptBlock, TResult>? variablePromptBlock = null,
            global::System.Func<global::Vellum.PlainTextPromptBlock, TResult>? plainTextPromptBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VariablePromptBlock is { } __value0 && variablePromptBlock != null)
            {
                return variablePromptBlock(__value0);
            }
            else if (PlainTextPromptBlock is { } __value1 && plainTextPromptBlock != null)
            {
                return plainTextPromptBlock(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.VariablePromptBlock>? variablePromptBlock = null,

            global::System.Action<global::Vellum.PlainTextPromptBlock>? plainTextPromptBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VariablePromptBlock is { } __value0)
            {
                variablePromptBlock?.Invoke(__value0);
            }
            else if (PlainTextPromptBlock is { } __value1)
            {
                plainTextPromptBlock?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vellum.VariablePromptBlock>? variablePromptBlock = null,
            global::System.Action<global::Vellum.PlainTextPromptBlock>? plainTextPromptBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (VariablePromptBlock is { } __value0)
            {
                variablePromptBlock?.Invoke(__value0);
            }
            else if (PlainTextPromptBlock is { } __value1)
            {
                plainTextPromptBlock?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VariablePromptBlock,
                typeof(global::Vellum.VariablePromptBlock),
                PlainTextPromptBlock,
                typeof(global::Vellum.PlainTextPromptBlock),
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
        public bool Equals(RichTextChildBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VariablePromptBlock?>.Default.Equals(VariablePromptBlock, other.VariablePromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.PlainTextPromptBlock?>.Default.Equals(PlainTextPromptBlock, other.PlainTextPromptBlock)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RichTextChildBlock obj1, RichTextChildBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RichTextChildBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RichTextChildBlock obj1, RichTextChildBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RichTextChildBlock o && Equals(o);
        }
    }
}
