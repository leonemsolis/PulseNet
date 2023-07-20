using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class AnyEnvironmentActionData
{
    [JsonProperty("ChangeEnvironmentalConditions")]
    ChangeEnvironmentalConditionsData ChangeEnvironmentalConditions { get; set; }

    [JsonProperty("ThermalApplication")] ThermalApplicationData ThermalApplication { get; set; }
}

public class EnvironmentActionData
{
    [JsonProperty("Action")] ActionData Action { get; set; }
}

/** @brief The environment conditions to change. */
public class ChangeEnvironmentalConditionsData
{
    [JsonProperty("EnvironmentAction")] EnvironmentActionData EnvironmentAction { get; set; }

    [JsonProperty("EnvironmentalConditions")]
    EnvironmentalConditionsData EnvironmentalConditions { get; set; }

    [JsonProperty("EnvironmentalConditionsFile")]
    string EnvironmentalConditionsFile { get; set; }

    [JsonProperty("MergeType")] eMergeType MergeType { get; set; }
}

/** @brief Create an external heat source. */
public class ThermalApplicationData
{
    [JsonProperty("EnvironmentAction")] EnvironmentActionData EnvironmentAction { get; set; }
    [JsonProperty("ActiveHeating")] ActiveConditioningData ActiveHeating { get; set; }
    [JsonProperty("ActiveCooling")] ActiveConditioningData ActiveCooling { get; set; }
    [JsonProperty("AppliedTemperature")] AppliedTemperatureData AppliedTemperature { get; set; }
    [JsonProperty("AppendToPrevious")] bool AppendToPrevious { get; set; }
}