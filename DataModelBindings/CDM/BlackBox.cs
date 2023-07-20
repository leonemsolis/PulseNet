using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class BlackBoxPropertyData
{
    public enum eType
    {
        None = 0,
        Imposed = 1,
        Provided = 2,
    }

    [JsonProperty("Type")] eType Type { get; set; }
}

// Fluid Properties
public class BlackBoxVolumePerTimeData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarVolumePerTimeData Property { get; set; }
}

public class BlackBoxPressureData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarPressureData Property { get; set; }
}

public class BlackBoxVolumeData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarVolumeData Property { get; set; }
}

public class BlackBoxMassPerVolumeData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarMassPerVolumeData Property { get; set; }
}

// Electric Properties
public class BlackBoxElectricCurrentData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarElectricCurrentData Property { get; set; }
}

public class BlackBoxElectricPotentialData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarElectricPotentialData Property { get; set; }
}

public class BlackBoxElectricChargeData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarElectricChargeData Property { get; set; }
}

// Thermal Properties
public class BlackBoxPowerData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarPowerData Property { get; set; }
}

public class BlackBoxTemperatureData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarTemperatureData Property { get; set; }
}

public class BlackBoxEnergyData
{
    [JsonProperty("Base")] BlackBoxPropertyData Base { get; set; }
    [JsonProperty("Property")] ScalarEnergyData Property { get; set; }
}

public class BlackBoxSubstanceData
{
    [JsonProperty("Name")] string Name { get; set; }
}

public class GasBlackBoxSubstanceData
{
    [JsonProperty("Base")] BlackBoxSubstanceData Base { get; set; }
    [JsonProperty("PartialPressure")] BlackBoxPressureData PartialPressure { get; set; }
}

public class LiquidBlackBoxSubstanceData
{
    [JsonProperty("Base")] BlackBoxSubstanceData Base { get; set; }
    [JsonProperty("Concentration")] BlackBoxMassPerVolumeData Concentration { get; set; }
}

public class BlackBoxData
{
    [JsonProperty("Name")] string Name { get; set; }
}

public class FluidBlackBoxData
{
    [JsonProperty("Base")] BlackBoxData Base { get; set; }
    [JsonProperty("SourceFlow")] BlackBoxVolumePerTimeData SourceFlow { get; set; }
    [JsonProperty("TargetFlow")] BlackBoxVolumePerTimeData TargetFlow { get; set; }
    [JsonProperty("SourcePressure")] BlackBoxPressureData SourcePressure { get; set; }
    [JsonProperty("TargetPressure")] BlackBoxPressureData TargetPressure { get; set; }
    [JsonProperty("Pressure")] BlackBoxPressureData Pressure { get; set; }
    [JsonProperty("Volume")] BlackBoxVolumeData Volume { get; set; }
}

public class ElectricBlackBoxData
{
    [JsonProperty("Base")] BlackBoxData Base { get; set; }
    [JsonProperty("SourceCurrent")] BlackBoxElectricCurrentData SourceCurrent { get; set; }
    [JsonProperty("TargetCurrent")] BlackBoxElectricCurrentData TargetCurrent { get; set; }
    [JsonProperty("SourceVoltage")] BlackBoxElectricPotentialData SourceVoltage { get; set; }
    [JsonProperty("TargetVoltage")] BlackBoxElectricPotentialData TargetVoltage { get; set; }
    [JsonProperty("Voltage")] BlackBoxElectricPotentialData Voltage { get; set; }
    [JsonProperty("Charge")] BlackBoxElectricChargeData Charge { get; set; }
}

public class ThermalBlackBoxData
{
    [JsonProperty("Base")] BlackBoxData Base { get; set; }

    [JsonProperty("SourceHeatTransferRate")]
    BlackBoxPowerData SourceHeatTransferRate { get; set; }

    [JsonProperty("TargetHeatTransferRate")]
    BlackBoxPowerData TargetHeatTransferRate { get; set; }

    [JsonProperty("SourceTemperature")] BlackBoxTemperatureData SourceTemperature { get; set; }
    [JsonProperty("TargetTemperature")] BlackBoxTemperatureData TargetTemperature { get; set; }
    [JsonProperty("Temperature")] BlackBoxTemperatureData Temperature { get; set; }
    [JsonProperty("Heat")] BlackBoxEnergyData Heat { get; set; }
}

public class GasBlackBoxData
{
    [JsonProperty("Base")] FluidBlackBoxData Base { get; set; }
    [JsonProperty("SubstanceQuantity")] List<GasBlackBoxSubstanceData> SubstanceQuantity { get; set; }
}

public class LiquidBlackBoxData
{
    [JsonProperty("Base")] FluidBlackBoxData Base { get; set; }
    [JsonProperty("SubstanceQuantity")] List<LiquidBlackBoxSubstanceData> SubstanceQuantity { get; set; }
}

public class BlackBoxesData
{
    [JsonProperty("GasBox")] List<GasBlackBoxData> GasBox { get; set; }
    [JsonProperty("LiquidBox")] List<LiquidBlackBoxData> LiquidBox { get; set; }
}