#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExecutePromptEvent : global::System.IEquatable<ExecutePromptEvent>
    {
        /// <summary>
        /// The initial data returned indicating that the response from the model has returned and begun streaming.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.InitiatedExecutePromptEvent? InitiatedExecutePromptEvent { get; init; }
#else
        public global::Vellum.InitiatedExecutePromptEvent? InitiatedExecutePromptEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InitiatedExecutePromptEvent))]
#endif
        public bool IsInitiatedExecutePromptEvent => InitiatedExecutePromptEvent != null;

        /// <summary>
        /// The data returned for each delta during the prompt execution stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.StreamingExecutePromptEvent? StreamingExecutePromptEvent { get; init; }
#else
        public global::Vellum.StreamingExecutePromptEvent? StreamingExecutePromptEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StreamingExecutePromptEvent))]
#endif
        public bool IsStreamingExecutePromptEvent => StreamingExecutePromptEvent != null;

        /// <summary>
        /// The final data event returned indicating that the stream has ended and all final resolved values from the model can be found.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.FulfilledExecutePromptEvent? FulfilledExecutePromptEvent { get; init; }
#else
        public global::Vellum.FulfilledExecutePromptEvent? FulfilledExecutePromptEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FulfilledExecutePromptEvent))]
#endif
        public bool IsFulfilledExecutePromptEvent => FulfilledExecutePromptEvent != null;

        /// <summary>
        /// The final data returned indicating an error occurred during the stream.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vellum.RejectedExecutePromptEvent? RejectedExecutePromptEvent { get; init; }
#else
        public global::Vellum.RejectedExecutePromptEvent? RejectedExecutePromptEvent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RejectedExecutePromptEvent))]
#endif
        public bool IsRejectedExecutePromptEvent => RejectedExecutePromptEvent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutePromptEvent(global::Vellum.InitiatedExecutePromptEvent value) => new ExecutePromptEvent((global::Vellum.InitiatedExecutePromptEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.InitiatedExecutePromptEvent?(ExecutePromptEvent @this) => @this.InitiatedExecutePromptEvent;

        /// <summary>
        /// 
        /// </summary>
        public ExecutePromptEvent(global::Vellum.InitiatedExecutePromptEvent? value)
        {
            InitiatedExecutePromptEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutePromptEvent(global::Vellum.StreamingExecutePromptEvent value) => new ExecutePromptEvent((global::Vellum.StreamingExecutePromptEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.StreamingExecutePromptEvent?(ExecutePromptEvent @this) => @this.StreamingExecutePromptEvent;

        /// <summary>
        /// 
        /// </summary>
        public ExecutePromptEvent(global::Vellum.StreamingExecutePromptEvent? value)
        {
            StreamingExecutePromptEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutePromptEvent(global::Vellum.FulfilledExecutePromptEvent value) => new ExecutePromptEvent((global::Vellum.FulfilledExecutePromptEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.FulfilledExecutePromptEvent?(ExecutePromptEvent @this) => @this.FulfilledExecutePromptEvent;

        /// <summary>
        /// 
        /// </summary>
        public ExecutePromptEvent(global::Vellum.FulfilledExecutePromptEvent? value)
        {
            FulfilledExecutePromptEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExecutePromptEvent(global::Vellum.RejectedExecutePromptEvent value) => new ExecutePromptEvent((global::Vellum.RejectedExecutePromptEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vellum.RejectedExecutePromptEvent?(ExecutePromptEvent @this) => @this.RejectedExecutePromptEvent;

        /// <summary>
        /// 
        /// </summary>
        public ExecutePromptEvent(global::Vellum.RejectedExecutePromptEvent? value)
        {
            RejectedExecutePromptEvent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExecutePromptEvent(
            global::Vellum.InitiatedExecutePromptEvent? initiatedExecutePromptEvent,
            global::Vellum.StreamingExecutePromptEvent? streamingExecutePromptEvent,
            global::Vellum.FulfilledExecutePromptEvent? fulfilledExecutePromptEvent,
            global::Vellum.RejectedExecutePromptEvent? rejectedExecutePromptEvent
            )
        {
            InitiatedExecutePromptEvent = initiatedExecutePromptEvent;
            StreamingExecutePromptEvent = streamingExecutePromptEvent;
            FulfilledExecutePromptEvent = fulfilledExecutePromptEvent;
            RejectedExecutePromptEvent = rejectedExecutePromptEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            RejectedExecutePromptEvent as object ??
            FulfilledExecutePromptEvent as object ??
            StreamingExecutePromptEvent as object ??
            InitiatedExecutePromptEvent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InitiatedExecutePromptEvent?.ToString() ??
            StreamingExecutePromptEvent?.ToString() ??
            FulfilledExecutePromptEvent?.ToString() ??
            RejectedExecutePromptEvent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInitiatedExecutePromptEvent && !IsStreamingExecutePromptEvent && !IsFulfilledExecutePromptEvent && !IsRejectedExecutePromptEvent || !IsInitiatedExecutePromptEvent && IsStreamingExecutePromptEvent && !IsFulfilledExecutePromptEvent && !IsRejectedExecutePromptEvent || !IsInitiatedExecutePromptEvent && !IsStreamingExecutePromptEvent && IsFulfilledExecutePromptEvent && !IsRejectedExecutePromptEvent || !IsInitiatedExecutePromptEvent && !IsStreamingExecutePromptEvent && !IsFulfilledExecutePromptEvent && IsRejectedExecutePromptEvent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vellum.InitiatedExecutePromptEvent?, TResult>? initiatedExecutePromptEvent = null,
            global::System.Func<global::Vellum.StreamingExecutePromptEvent?, TResult>? streamingExecutePromptEvent = null,
            global::System.Func<global::Vellum.FulfilledExecutePromptEvent?, TResult>? fulfilledExecutePromptEvent = null,
            global::System.Func<global::Vellum.RejectedExecutePromptEvent?, TResult>? rejectedExecutePromptEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInitiatedExecutePromptEvent && initiatedExecutePromptEvent != null)
            {
                return initiatedExecutePromptEvent(InitiatedExecutePromptEvent!);
            }
            else if (IsStreamingExecutePromptEvent && streamingExecutePromptEvent != null)
            {
                return streamingExecutePromptEvent(StreamingExecutePromptEvent!);
            }
            else if (IsFulfilledExecutePromptEvent && fulfilledExecutePromptEvent != null)
            {
                return fulfilledExecutePromptEvent(FulfilledExecutePromptEvent!);
            }
            else if (IsRejectedExecutePromptEvent && rejectedExecutePromptEvent != null)
            {
                return rejectedExecutePromptEvent(RejectedExecutePromptEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vellum.InitiatedExecutePromptEvent?>? initiatedExecutePromptEvent = null,
            global::System.Action<global::Vellum.StreamingExecutePromptEvent?>? streamingExecutePromptEvent = null,
            global::System.Action<global::Vellum.FulfilledExecutePromptEvent?>? fulfilledExecutePromptEvent = null,
            global::System.Action<global::Vellum.RejectedExecutePromptEvent?>? rejectedExecutePromptEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInitiatedExecutePromptEvent)
            {
                initiatedExecutePromptEvent?.Invoke(InitiatedExecutePromptEvent!);
            }
            else if (IsStreamingExecutePromptEvent)
            {
                streamingExecutePromptEvent?.Invoke(StreamingExecutePromptEvent!);
            }
            else if (IsFulfilledExecutePromptEvent)
            {
                fulfilledExecutePromptEvent?.Invoke(FulfilledExecutePromptEvent!);
            }
            else if (IsRejectedExecutePromptEvent)
            {
                rejectedExecutePromptEvent?.Invoke(RejectedExecutePromptEvent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InitiatedExecutePromptEvent,
                typeof(global::Vellum.InitiatedExecutePromptEvent),
                StreamingExecutePromptEvent,
                typeof(global::Vellum.StreamingExecutePromptEvent),
                FulfilledExecutePromptEvent,
                typeof(global::Vellum.FulfilledExecutePromptEvent),
                RejectedExecutePromptEvent,
                typeof(global::Vellum.RejectedExecutePromptEvent),
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
        public bool Equals(ExecutePromptEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vellum.InitiatedExecutePromptEvent?>.Default.Equals(InitiatedExecutePromptEvent, other.InitiatedExecutePromptEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.StreamingExecutePromptEvent?>.Default.Equals(StreamingExecutePromptEvent, other.StreamingExecutePromptEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.FulfilledExecutePromptEvent?>.Default.Equals(FulfilledExecutePromptEvent, other.FulfilledExecutePromptEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Vellum.RejectedExecutePromptEvent?>.Default.Equals(RejectedExecutePromptEvent, other.RejectedExecutePromptEvent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExecutePromptEvent obj1, ExecutePromptEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExecutePromptEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExecutePromptEvent obj1, ExecutePromptEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExecutePromptEvent o && Equals(o);
        }
    }
}
