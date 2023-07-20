using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.Engine;

public class ScenarioData
{
    [JsonProperty("Scenario")] ScenarioData Scenario { get; set; }
    [JsonProperty("Configuration")] ConfigurationData Configuration { get; set; }
}

public class ScenarioExecData
{
    [JsonProperty("ScenarioExec")] ScenarioExecData ScenarioExec { get; set; }
    [JsonProperty("ModelType")] eModelType ModelType { get; set; }
}