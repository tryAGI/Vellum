
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunRead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_suite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteRunTestSuite TestSuite { get; set; }

        /// <summary>
        /// The current state of this run<br/>
        /// * `QUEUED` - Queued<br/>
        /// * `RUNNING` - Running<br/>
        /// * `COMPLETE` - Complete<br/>
        /// * `FAILED` - Failed<br/>
        /// * `CANCELLED` - Cancelled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.TestSuiteRunStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vellum.TestSuiteRunState State { get; set; }

        /// <summary>
        /// Configuration that defines how the Test Suite should be run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exec_config")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vellum.JsonConverters.OneOfJsonConverter<global::Vellum.TestSuiteRunExecConfig?, object>))]
        public global::Vellum.OneOf<global::Vellum.TestSuiteRunExecConfig?, object>? ExecConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public global::Vellum.TestSuiteRunProgress? Progress { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunRead" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="created"></param>
        /// <param name="testSuite"></param>
        /// <param name="state">
        /// The current state of this run<br/>
        /// * `QUEUED` - Queued<br/>
        /// * `RUNNING` - Running<br/>
        /// * `COMPLETE` - Complete<br/>
        /// * `FAILED` - Failed<br/>
        /// * `CANCELLED` - Cancelled
        /// </param>
        /// <param name="execConfig">
        /// Configuration that defines how the Test Suite should be run
        /// </param>
        /// <param name="progress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunRead(
            global::System.Guid id,
            global::System.DateTime created,
            global::Vellum.TestSuiteRunTestSuite testSuite,
            global::Vellum.TestSuiteRunState state,
            global::Vellum.OneOf<global::Vellum.TestSuiteRunExecConfig?, object>? execConfig,
            global::Vellum.TestSuiteRunProgress? progress)
        {
            this.Id = id;
            this.Created = created;
            this.TestSuite = testSuite ?? throw new global::System.ArgumentNullException(nameof(testSuite));
            this.State = state;
            this.ExecConfig = execConfig;
            this.Progress = progress;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunRead" /> class.
        /// </summary>
        public TestSuiteRunRead()
        {
        }
    }
}