using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class InhalerActionData
{
    [JsonProperty("EquipmentAction")] EquipmentActionData EquipmentAction { get; set; }
}

public class InhalerConfigurationData
{
    [JsonProperty("InhalerAction")] InhalerActionData InhalerAction { get; set; }
    [JsonProperty("Configuration")] InhalerData Configuration { get; set; }
    [JsonProperty("ConfigurationFile")] string ConfigurationFile { get; set; }
    [JsonProperty("MergeType")] eMergeType MergeType { get; set; }
}