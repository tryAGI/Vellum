#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PromptBlock : global::System.IEquatable<PromptBlock>
    {
        /// <summary>
        /// A block of Jinja template code that is used to generate a prompt
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.JinjaPromptBlock? JinjaPromptBlock { get; init; }
#else
        public global::Vellum.JinjaPromptBlock? JinjaPromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JinjaPromptBlock))]
#endif
        public bool IsJinjaPromptBlock => JinjaPromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickJinjaPromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.JinjaPromptBlock? value)
        {
            value = JinjaPromptBlock;
            return IsJinjaPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.JinjaPromptBlock PickJinjaPromptBlock() => JinjaPromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'JinjaPromptBlock' but the value was {ToString()}.");

        /// <summary>
        /// A block that represents a chat message in a prompt template.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ChatMessagePromptBlock? ChatMessagePromptBlock { get; init; }
#else
        public global::Vellum.ChatMessagePromptBlock? ChatMessagePromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessagePromptBlock))]
#endif
        public bool IsChatMessagePromptBlock => ChatMessagePromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickChatMessagePromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.ChatMessagePromptBlock? value)
        {
            value = ChatMessagePromptBlock;
            return IsChatMessagePromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ChatMessagePromptBlock PickChatMessagePromptBlock() => ChatMessagePromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ChatMessagePromptBlock' but the value was {ToString()}.");

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
        /// A block that includes a combination of plain text and variable blocks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.RichTextPromptBlock? RichTextPromptBlock { get; init; }
#else
        public global::Vellum.RichTextPromptBlock? RichTextPromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RichTextPromptBlock))]
#endif
        public bool IsRichTextPromptBlock => RichTextPromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRichTextPromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.RichTextPromptBlock? value)
        {
            value = RichTextPromptBlock;
            return IsRichTextPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.RichTextPromptBlock PickRichTextPromptBlock() => RichTextPromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RichTextPromptBlock' but the value was {ToString()}.");

        /// <summary>
        /// A block that represents a function call in a prompt template.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FunctionCallPromptBlock? FunctionCallPromptBlock { get; init; }
#else
        public global::Vellum.FunctionCallPromptBlock? FunctionCallPromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCallPromptBlock))]
#endif
        public bool IsFunctionCallPromptBlock => FunctionCallPromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFunctionCallPromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.FunctionCallPromptBlock? value)
        {
            value = FunctionCallPromptBlock;
            return IsFunctionCallPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.FunctionCallPromptBlock PickFunctionCallPromptBlock() => FunctionCallPromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FunctionCallPromptBlock' but the value was {ToString()}.");

        /// <summary>
        /// A block that represents an audio file in a prompt template.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.AudioPromptBlock? AudioPromptBlock { get; init; }
#else
        public global::Vellum.AudioPromptBlock? AudioPromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioPromptBlock))]
#endif
        public bool IsAudioPromptBlock => AudioPromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioPromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.AudioPromptBlock? value)
        {
            value = AudioPromptBlock;
            return IsAudioPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.AudioPromptBlock PickAudioPromptBlock() => AudioPromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioPromptBlock' but the value was {ToString()}.");

        /// <summary>
        /// A block that represents an video file in a prompt template.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.VideoPromptBlock? VideoPromptBlock { get; init; }
#else
        public global::Vellum.VideoPromptBlock? VideoPromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoPromptBlock))]
#endif
        public bool IsVideoPromptBlock => VideoPromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideoPromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.VideoPromptBlock? value)
        {
            value = VideoPromptBlock;
            return IsVideoPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.VideoPromptBlock PickVideoPromptBlock() => VideoPromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoPromptBlock' but the value was {ToString()}.");

        /// <summary>
        /// A block that represents an image in a prompt template.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.ImagePromptBlock? ImagePromptBlock { get; init; }
#else
        public global::Vellum.ImagePromptBlock? ImagePromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImagePromptBlock))]
#endif
        public bool IsImagePromptBlock => ImagePromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImagePromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.ImagePromptBlock? value)
        {
            value = ImagePromptBlock;
            return IsImagePromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.ImagePromptBlock PickImagePromptBlock() => ImagePromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImagePromptBlock' but the value was {ToString()}.");

        /// <summary>
        /// A block that represents a document in a prompt template.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.DocumentPromptBlock? DocumentPromptBlock { get; init; }
#else
        public global::Vellum.DocumentPromptBlock? DocumentPromptBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DocumentPromptBlock))]
#endif
        public bool IsDocumentPromptBlock => DocumentPromptBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDocumentPromptBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vellum.DocumentPromptBlock? value)
        {
            value = DocumentPromptBlock;
            return IsDocumentPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vellum.DocumentPromptBlock PickDocumentPromptBlock() => DocumentPromptBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DocumentPromptBlock' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.JinjaPromptBlock value) => new PromptBlock((global::Vellum.JinjaPromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.JinjaPromptBlock?(PromptBlock @this) => @this.JinjaPromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.JinjaPromptBlock? value)
        {
            JinjaPromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromJinjaPromptBlock(global::Vellum.JinjaPromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.ChatMessagePromptBlock value) => new PromptBlock((global::Vellum.ChatMessagePromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.ChatMessagePromptBlock?(PromptBlock @this) => @this.ChatMessagePromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.ChatMessagePromptBlock? value)
        {
            ChatMessagePromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromChatMessagePromptBlock(global::Vellum.ChatMessagePromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.VariablePromptBlock value) => new PromptBlock((global::Vellum.VariablePromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.VariablePromptBlock?(PromptBlock @this) => @this.VariablePromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.VariablePromptBlock? value)
        {
            VariablePromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromVariablePromptBlock(global::Vellum.VariablePromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.RichTextPromptBlock value) => new PromptBlock((global::Vellum.RichTextPromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.RichTextPromptBlock?(PromptBlock @this) => @this.RichTextPromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.RichTextPromptBlock? value)
        {
            RichTextPromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromRichTextPromptBlock(global::Vellum.RichTextPromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.FunctionCallPromptBlock value) => new PromptBlock((global::Vellum.FunctionCallPromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.FunctionCallPromptBlock?(PromptBlock @this) => @this.FunctionCallPromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.FunctionCallPromptBlock? value)
        {
            FunctionCallPromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromFunctionCallPromptBlock(global::Vellum.FunctionCallPromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.AudioPromptBlock value) => new PromptBlock((global::Vellum.AudioPromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.AudioPromptBlock?(PromptBlock @this) => @this.AudioPromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.AudioPromptBlock? value)
        {
            AudioPromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromAudioPromptBlock(global::Vellum.AudioPromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.VideoPromptBlock value) => new PromptBlock((global::Vellum.VideoPromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.VideoPromptBlock?(PromptBlock @this) => @this.VideoPromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.VideoPromptBlock? value)
        {
            VideoPromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromVideoPromptBlock(global::Vellum.VideoPromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.ImagePromptBlock value) => new PromptBlock((global::Vellum.ImagePromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.ImagePromptBlock?(PromptBlock @this) => @this.ImagePromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.ImagePromptBlock? value)
        {
            ImagePromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromImagePromptBlock(global::Vellum.ImagePromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PromptBlock(global::Vellum.DocumentPromptBlock value) => new PromptBlock((global::Vellum.DocumentPromptBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vellum.DocumentPromptBlock?(PromptBlock @this) => @this.DocumentPromptBlock;

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(global::Vellum.DocumentPromptBlock? value)
        {
            DocumentPromptBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PromptBlock FromDocumentPromptBlock(global::Vellum.DocumentPromptBlock? value) => new PromptBlock(value);

        /// <summary>
        ///
        /// </summary>
        public PromptBlock(
            global::Vellum.JinjaPromptBlock? jinjaPromptBlock,
            global::Vellum.ChatMessagePromptBlock? chatMessagePromptBlock,
            global::Vellum.VariablePromptBlock? variablePromptBlock,
            global::Vellum.RichTextPromptBlock? richTextPromptBlock,
            global::Vellum.FunctionCallPromptBlock? functionCallPromptBlock,
            global::Vellum.AudioPromptBlock? audioPromptBlock,
            global::Vellum.VideoPromptBlock? videoPromptBlock,
            global::Vellum.ImagePromptBlock? imagePromptBlock,
            global::Vellum.DocumentPromptBlock? documentPromptBlock
            )
        {
            JinjaPromptBlock = jinjaPromptBlock;
            ChatMessagePromptBlock = chatMessagePromptBlock;
            VariablePromptBlock = variablePromptBlock;
            RichTextPromptBlock = richTextPromptBlock;
            FunctionCallPromptBlock = functionCallPromptBlock;
            AudioPromptBlock = audioPromptBlock;
            VideoPromptBlock = videoPromptBlock;
            ImagePromptBlock = imagePromptBlock;
            DocumentPromptBlock = documentPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DocumentPromptBlock as object ??
            ImagePromptBlock as object ??
            VideoPromptBlock as object ??
            AudioPromptBlock as object ??
            FunctionCallPromptBlock as object ??
            RichTextPromptBlock as object ??
            VariablePromptBlock as object ??
            ChatMessagePromptBlock as object ??
            JinjaPromptBlock as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            JinjaPromptBlock?.ToString() ??
            ChatMessagePromptBlock?.ToString() ??
            VariablePromptBlock?.ToString() ??
            RichTextPromptBlock?.ToString() ??
            FunctionCallPromptBlock?.ToString() ??
            AudioPromptBlock?.ToString() ??
            VideoPromptBlock?.ToString() ??
            ImagePromptBlock?.ToString() ??
            DocumentPromptBlock?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsJinjaPromptBlock && !IsChatMessagePromptBlock && !IsVariablePromptBlock && !IsRichTextPromptBlock && !IsFunctionCallPromptBlock && !IsAudioPromptBlock && !IsVideoPromptBlock && !IsImagePromptBlock && !IsDocumentPromptBlock || !IsJinjaPromptBlock && IsChatMessagePromptBlock && !IsVariablePromptBlock && !IsRichTextPromptBlock && !IsFunctionCallPromptBlock && !IsAudioPromptBlock && !IsVideoPromptBlock && !IsImagePromptBlock && !IsDocumentPromptBlock || !IsJinjaPromptBlock && !IsChatMessagePromptBlock && IsVariablePromptBlock && !IsRichTextPromptBlock && !IsFunctionCallPromptBlock && !IsAudioPromptBlock && !IsVideoPromptBlock && !IsImagePromptBlock && !IsDocumentPromptBlock || !IsJinjaPromptBlock && !IsChatMessagePromptBlock && !IsVariablePromptBlock && IsRichTextPromptBlock && !IsFunctionCallPromptBlock && !IsAudioPromptBlock && !IsVideoPromptBlock && !IsImagePromptBlock && !IsDocumentPromptBlock || !IsJinjaPromptBlock && !IsChatMessagePromptBlock && !IsVariablePromptBlock && !IsRichTextPromptBlock && IsFunctionCallPromptBlock && !IsAudioPromptBlock && !IsVideoPromptBlock && !IsImagePromptBlock && !IsDocumentPromptBlock || !IsJinjaPromptBlock && !IsChatMessagePromptBlock && !IsVariablePromptBlock && !IsRichTextPromptBlock && !IsFunctionCallPromptBlock && IsAudioPromptBlock && !IsVideoPromptBlock && !IsImagePromptBlock && !IsDocumentPromptBlock || !IsJinjaPromptBlock && !IsChatMessagePromptBlock && !IsVariablePromptBlock && !IsRichTextPromptBlock && !IsFunctionCallPromptBlock && !IsAudioPromptBlock && IsVideoPromptBlock && !IsImagePromptBlock && !IsDocumentPromptBlock || !IsJinjaPromptBlock && !IsChatMessagePromptBlock && !IsVariablePromptBlock && !IsRichTextPromptBlock && !IsFunctionCallPromptBlock && !IsAudioPromptBlock && !IsVideoPromptBlock && IsImagePromptBlock && !IsDocumentPromptBlock || !IsJinjaPromptBlock && !IsChatMessagePromptBlock && !IsVariablePromptBlock && !IsRichTextPromptBlock && !IsFunctionCallPromptBlock && !IsAudioPromptBlock && !IsVideoPromptBlock && !IsImagePromptBlock && IsDocumentPromptBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.JinjaPromptBlock, TResult>? jinjaPromptBlock = null,
            global::System.Func<global::Vellum.ChatMessagePromptBlock, TResult>? chatMessagePromptBlock = null,
            global::System.Func<global::Vellum.VariablePromptBlock, TResult>? variablePromptBlock = null,
            global::System.Func<global::Vellum.RichTextPromptBlock, TResult>? richTextPromptBlock = null,
            global::System.Func<global::Vellum.FunctionCallPromptBlock, TResult>? functionCallPromptBlock = null,
            global::System.Func<global::Vellum.AudioPromptBlock, TResult>? audioPromptBlock = null,
            global::System.Func<global::Vellum.VideoPromptBlock, TResult>? videoPromptBlock = null,
            global::System.Func<global::Vellum.ImagePromptBlock, TResult>? imagePromptBlock = null,
            global::System.Func<global::Vellum.DocumentPromptBlock, TResult>? documentPromptBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JinjaPromptBlock is { } __value0 && jinjaPromptBlock != null)
            {
                return jinjaPromptBlock(__value0);
            }
            else if (ChatMessagePromptBlock is { } __value1 && chatMessagePromptBlock != null)
            {
                return chatMessagePromptBlock(__value1);
            }
            else if (VariablePromptBlock is { } __value2 && variablePromptBlock != null)
            {
                return variablePromptBlock(__value2);
            }
            else if (RichTextPromptBlock is { } __value3 && richTextPromptBlock != null)
            {
                return richTextPromptBlock(__value3);
            }
            else if (FunctionCallPromptBlock is { } __value4 && functionCallPromptBlock != null)
            {
                return functionCallPromptBlock(__value4);
            }
            else if (AudioPromptBlock is { } __value5 && audioPromptBlock != null)
            {
                return audioPromptBlock(__value5);
            }
            else if (VideoPromptBlock is { } __value6 && videoPromptBlock != null)
            {
                return videoPromptBlock(__value6);
            }
            else if (ImagePromptBlock is { } __value7 && imagePromptBlock != null)
            {
                return imagePromptBlock(__value7);
            }
            else if (DocumentPromptBlock is { } __value8 && documentPromptBlock != null)
            {
                return documentPromptBlock(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.JinjaPromptBlock>? jinjaPromptBlock = null,

            global::System.Action<global::Vellum.ChatMessagePromptBlock>? chatMessagePromptBlock = null,

            global::System.Action<global::Vellum.VariablePromptBlock>? variablePromptBlock = null,

            global::System.Action<global::Vellum.RichTextPromptBlock>? richTextPromptBlock = null,

            global::System.Action<global::Vellum.FunctionCallPromptBlock>? functionCallPromptBlock = null,

            global::System.Action<global::Vellum.AudioPromptBlock>? audioPromptBlock = null,

            global::System.Action<global::Vellum.VideoPromptBlock>? videoPromptBlock = null,

            global::System.Action<global::Vellum.ImagePromptBlock>? imagePromptBlock = null,

            global::System.Action<global::Vellum.DocumentPromptBlock>? documentPromptBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JinjaPromptBlock is { } __value0)
            {
                jinjaPromptBlock?.Invoke(__value0);
            }
            else if (ChatMessagePromptBlock is { } __value1)
            {
                chatMessagePromptBlock?.Invoke(__value1);
            }
            else if (VariablePromptBlock is { } __value2)
            {
                variablePromptBlock?.Invoke(__value2);
            }
            else if (RichTextPromptBlock is { } __value3)
            {
                richTextPromptBlock?.Invoke(__value3);
            }
            else if (FunctionCallPromptBlock is { } __value4)
            {
                functionCallPromptBlock?.Invoke(__value4);
            }
            else if (AudioPromptBlock is { } __value5)
            {
                audioPromptBlock?.Invoke(__value5);
            }
            else if (VideoPromptBlock is { } __value6)
            {
                videoPromptBlock?.Invoke(__value6);
            }
            else if (ImagePromptBlock is { } __value7)
            {
                imagePromptBlock?.Invoke(__value7);
            }
            else if (DocumentPromptBlock is { } __value8)
            {
                documentPromptBlock?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vellum.JinjaPromptBlock>? jinjaPromptBlock = null,
            global::System.Action<global::Vellum.ChatMessagePromptBlock>? chatMessagePromptBlock = null,
            global::System.Action<global::Vellum.VariablePromptBlock>? variablePromptBlock = null,
            global::System.Action<global::Vellum.RichTextPromptBlock>? richTextPromptBlock = null,
            global::System.Action<global::Vellum.FunctionCallPromptBlock>? functionCallPromptBlock = null,
            global::System.Action<global::Vellum.AudioPromptBlock>? audioPromptBlock = null,
            global::System.Action<global::Vellum.VideoPromptBlock>? videoPromptBlock = null,
            global::System.Action<global::Vellum.ImagePromptBlock>? imagePromptBlock = null,
            global::System.Action<global::Vellum.DocumentPromptBlock>? documentPromptBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (JinjaPromptBlock is { } __value0)
            {
                jinjaPromptBlock?.Invoke(__value0);
            }
            else if (ChatMessagePromptBlock is { } __value1)
            {
                chatMessagePromptBlock?.Invoke(__value1);
            }
            else if (VariablePromptBlock is { } __value2)
            {
                variablePromptBlock?.Invoke(__value2);
            }
            else if (RichTextPromptBlock is { } __value3)
            {
                richTextPromptBlock?.Invoke(__value3);
            }
            else if (FunctionCallPromptBlock is { } __value4)
            {
                functionCallPromptBlock?.Invoke(__value4);
            }
            else if (AudioPromptBlock is { } __value5)
            {
                audioPromptBlock?.Invoke(__value5);
            }
            else if (VideoPromptBlock is { } __value6)
            {
                videoPromptBlock?.Invoke(__value6);
            }
            else if (ImagePromptBlock is { } __value7)
            {
                imagePromptBlock?.Invoke(__value7);
            }
            else if (DocumentPromptBlock is { } __value8)
            {
                documentPromptBlock?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                JinjaPromptBlock,
                typeof(global::Vellum.JinjaPromptBlock),
                ChatMessagePromptBlock,
                typeof(global::Vellum.ChatMessagePromptBlock),
                VariablePromptBlock,
                typeof(global::Vellum.VariablePromptBlock),
                RichTextPromptBlock,
                typeof(global::Vellum.RichTextPromptBlock),
                FunctionCallPromptBlock,
                typeof(global::Vellum.FunctionCallPromptBlock),
                AudioPromptBlock,
                typeof(global::Vellum.AudioPromptBlock),
                VideoPromptBlock,
                typeof(global::Vellum.VideoPromptBlock),
                ImagePromptBlock,
                typeof(global::Vellum.ImagePromptBlock),
                DocumentPromptBlock,
                typeof(global::Vellum.DocumentPromptBlock),
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
        public bool Equals(PromptBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.JinjaPromptBlock?>.Default.Equals(JinjaPromptBlock, other.JinjaPromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ChatMessagePromptBlock?>.Default.Equals(ChatMessagePromptBlock, other.ChatMessagePromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VariablePromptBlock?>.Default.Equals(VariablePromptBlock, other.VariablePromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.RichTextPromptBlock?>.Default.Equals(RichTextPromptBlock, other.RichTextPromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FunctionCallPromptBlock?>.Default.Equals(FunctionCallPromptBlock, other.FunctionCallPromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.AudioPromptBlock?>.Default.Equals(AudioPromptBlock, other.AudioPromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.VideoPromptBlock?>.Default.Equals(VideoPromptBlock, other.VideoPromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.ImagePromptBlock?>.Default.Equals(ImagePromptBlock, other.ImagePromptBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.DocumentPromptBlock?>.Default.Equals(DocumentPromptBlock, other.DocumentPromptBlock)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PromptBlock obj1, PromptBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PromptBlock obj1, PromptBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptBlock o && Equals(o);
        }
    }
}
