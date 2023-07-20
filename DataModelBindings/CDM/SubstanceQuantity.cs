using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class SubstanceQuantityData
{
    [JsonProperty("Substance")] string Substance { get; set; }
}

public class GasSubstanceQuantityData
{
    [JsonProperty("SubstanceQuantity")] SubstanceQuantityData SubstanceQuantity { get; set; }
    [JsonProperty("PartialPressure")] ScalarPressureData PartialPressure { get; set; }
    [JsonProperty("Volume")] ScalarVolumeData Volume { get; set; }
    [JsonProperty("VolumeFraction")] Scalar0To1Data VolumeFraction { get; set; }
}

public class LiquidSubstanceQuantityData
{
    [JsonProperty("SubstanceQuantity")] SubstanceQuantityData SubstanceQuantity { get; set; }
    [JsonProperty("Concentration")] ScalarMassPerVolumeData Concentration { get; set; }
    [JsonProperty("Mass")] ScalarMassData Mass { get; set; }
    [JsonProperty("MassCleared")] ScalarMassData MassCleared { get; set; }
    [JsonProperty("MassDeposited")] ScalarMassData MassDeposited { get; set; }
    [JsonProperty("MassExcreted")] ScalarMassData MassExcreted { get; set; }
    [JsonProperty("Molarity")] ScalarAmountPerVolumeData Molarity { get; set; }
    [JsonProperty("PartialPressure")] ScalarPressureData PartialPressure { get; set; }
    [JsonProperty("Saturation")] Scalar0To1Data Saturation { get; set; }
}

public class TissueSubstanceQuantityData
{
    [JsonProperty("SubstanceQuantity")] SubstanceQuantityData SubstanceQuantity { get; set; }
    [JsonProperty("TissueConcentration")] ScalarMassPerVolumeData TissueConcentration { get; set; }
    [JsonProperty("TissueMolarity")] ScalarAmountPerVolumeData TissueMolarity { get; set; }

    [JsonProperty("ExtravascularConcentration")]
    ScalarMassPerVolumeData ExtravascularConcentration { get; set; }

    [JsonProperty("ExtravascularMolarity")]
    ScalarAmountPerVolumeData ExtravascularMolarity { get; set; }

    [JsonProperty("ExtravascularPartialPressure")]
    ScalarPressureData ExtravascularPartialPressure { get; set; }

    [JsonProperty("ExtravascularSaturation")]
    Scalar0To1Data ExtravascularSaturation { get; set; }
}