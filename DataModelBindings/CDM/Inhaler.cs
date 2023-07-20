using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class InhalerData
{
    [JsonProperty("State")] eSwitch State { get; set; }
    [JsonProperty("Substance")] string Substance { get; set; }
    [JsonProperty("MeteredDose")] ScalarMassData MeteredDose { get; set; }
    [JsonProperty("NozzleLoss")] Scalar0To1Data NozzleLoss { get; set; }
    [JsonProperty("SpacerVolume")] ScalarVolumeData SpacerVolume { get; set; }
}