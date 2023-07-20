using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class BagValveMaskActionData
{
    [JsonProperty("EquipmentAction")] EquipmentActionData EquipmentAction { get; set; }
}

public class BagValveMaskConfigurationData
{
    [JsonProperty("BagValveMaskAction")] BagValveMaskActionData BagValveMaskAction { get; set; }
    [JsonProperty("Configuration")] BagValveMaskData Configuration { get; set; }
    [JsonProperty("ConfigurationFile")] string ConfigurationFile { get; set; }
    [JsonProperty("MergeType")] eMergeType MergeType { get; set; }
}

public class BagValveMaskAutomatedData
{
    [JsonProperty("BagValveMaskAction")] BagValveMaskActionData BagValveMaskAction { get; set; }

    [JsonProperty("BreathFrequency")] ScalarFrequencyData BreathFrequency { get; set; }

    [JsonProperty("InspiratoryExpiratoryRatio")]
    ScalarData InspiratoryExpiratoryRatio { get; set; }

    [JsonProperty("SqueezePressure")] ScalarPressureData SqueezePressure { get; set; }
    [JsonProperty("SqueezeVolume")] ScalarVolumeData SqueezeVolume { get; set; }
}

public class BagValveMaskSqueezeData
{
    [JsonProperty("BagValveMaskAction")] BagValveMaskActionData BagValveMaskAction { get; set; }
    [JsonProperty("SqueezePressure")] ScalarPressureData SqueezePressure { get; set; }
    [JsonProperty("SqueezeVolume")] ScalarVolumeData SqueezeVolume { get; set; }
    [JsonProperty("ExpiratoryPeriod")] ScalarTimeData ExpiratoryPeriod { get; set; }
    [JsonProperty("InspiratoryPeriod")] ScalarTimeData InspiratoryPeriod { get; set; }
}

public class BagValveMaskInstantaneousData
{
    [JsonProperty("BagValveMaskAction")] BagValveMaskActionData BagValveMaskAction { get; set; }
    [JsonProperty("Pressure")] ScalarPressureData Pressure { get; set; }
    [JsonProperty("Flow")] ScalarVolumePerTimeData Flow { get; set; }
}