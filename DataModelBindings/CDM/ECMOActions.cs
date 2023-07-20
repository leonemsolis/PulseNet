using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class ECMOActionData
{
    [JsonProperty("EquipmentAction")] EquipmentActionData EquipmentAction { get; set; }
}

public class ECMOConfigurationData
{
    [JsonProperty("ECMOAction")] ECMOActionData ECMOAction { get; set; }
    [JsonProperty("Settings")] ECMOSettingsData Settings { get; set; }
    [JsonProperty("SettingsFile")] string SettingsFile { get; set; }
    [JsonProperty("MergeType")] eMergeType MergeType { get; set; }
}