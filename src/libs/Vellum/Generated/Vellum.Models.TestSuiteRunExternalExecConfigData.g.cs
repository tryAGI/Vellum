
#nullable enable

namespace Vellum
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestSuiteRunExternalExecConfigData
    {
        /// <summary>
        /// The executions of some callable external to Vellum whose outputs you would like to evaluate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vellum.ExternalTestCaseExecution> Executions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExternalExecConfigData" /> class.
        /// </summary>
        /// <param name="executions">
        /// The executions of some callable external to Vellum whose outputs you would like to evaluate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestSuiteRunExternalExecConfigData(
            global::System.Collections.Generic.IList<global::Vellum.ExternalTestCaseExecution> executions)
        {
            this.Executions = executions ?? throw new global::System.ArgumentNullException(nameof(executions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestSuiteRunExternalExecConfigData" /> class.
        /// </summary>
        public TestSuiteRunExternalExecConfigData()
        {
        }
    }
}