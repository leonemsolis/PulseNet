using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class AnyEnvironmentConditionData
{
    [JsonProperty("InitialEnvironmentalConditions")]
    InitialEnvironmentalConditionsData InitialEnvironmentalConditions { get; set; }
}

public class EnvironmentConditionData
{
    [JsonProperty("Condition")] ConditionData Condition { get; set; }
}

public class InitialEnvironmentalConditionsData
{
    [JsonProperty("EnvironmentCondition")] EnvironmentConditionData EnvironmentCondition { get; set; }

    [JsonProperty("EnvironmentalConditions")]
    EnvironmentalConditionsData EnvironmentalConditions { get; set; }

    [JsonProperty("EnvironmentalConditionsFile")]
    string EnvironmentalConditionsFile { get; set; }
}