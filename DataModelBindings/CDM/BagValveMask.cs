using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class BagValveMaskData
{
    [JsonProperty("BreathState")] eBreathState BreathState { get; set; }
    [JsonProperty("Connection")] eSwitch Connection { get; set; }

    [JsonProperty("BagResistance")] ScalarPressureTimePerVolumeData BagResistance { get; set; }
    [JsonProperty("ConnectionVolume")] ScalarVolumeData ConnectionVolume { get; set; }
    [JsonProperty("FilterResistance")] ScalarPressureTimePerVolumeData FilterResistance { get; set; }
    [JsonProperty("FilterVolume")] ScalarVolumeData FilterVolume { get; set; }
    [JsonProperty("SealResistance")] ScalarPressureTimePerVolumeData SealResistance { get; set; }

    [JsonProperty("ValvePositiveEndExpiredPressure")]
    ScalarPressureData ValvePositiveEndExpiredPressure { get; set; }

    [JsonProperty("ValveResistance")] ScalarPressureTimePerVolumeData ValveResistance { get; set; }
    [JsonProperty("ValveVolume")] ScalarVolumeData ValveVolume { get; set; }

    [JsonProperty("FractionInspiredGas")]
    List<SubstanceFractionData> FractionInspiredGas { get; set; }

    [JsonProperty("ConcentrationInspiredAerosol")]
    List<SubstanceConcentrationData> ConcentrationInspiredAerosol { get; set; }
}