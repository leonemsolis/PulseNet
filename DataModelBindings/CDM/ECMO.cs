using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public enum eECMOCannulationLocation
{
    NullCannulationLocation = 0,
    InternalJugular = 1,
    RightFemoralVein = 2,
    LeftFemoralVein = 3,
    RightSubclavianVein = 4,
    LeftSubclavianVein = 5
}

public class ECMOSettingsData
{
    [JsonProperty("InflowLocation")] eECMOCannulationLocation InflowLocation { get; set; }
    [JsonProperty("OutflowLocation")] eECMOCannulationLocation OutflowLocation { get; set; }
    [JsonProperty("OxygenatorVolume")] ScalarVolumeData OxygenatorVolume { get; set; }
    [JsonProperty("TransfusionFlow")] ScalarVolumePerTimeData TransfusionFlow { get; set; }

    [JsonProperty("SubstanceCompound")] string SubstanceCompound { get; set; }

    [JsonProperty("SubstanceConcentrations")]
    List<SubstanceConcentrationData> SubstanceConcentrations { get; set; }
}

public class ECMOData
{
    [JsonProperty("Settings")] ECMOSettingsData Settings { get; set; }
}