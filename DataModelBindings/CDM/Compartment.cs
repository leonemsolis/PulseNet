using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class CompartmentData
{
    public enum eType
    {
        Electrical = 0,
        Gas = 1,
        Liquid = 2,
        Thermal = 3,
        Tissue = 4
    }

    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Node")] List<string> Node { get; set; }
    [JsonProperty("Child")] List<string> Child { get; set; }
}

public class CompartmentLinkData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Path")] string Path { get; set; }
    [JsonProperty("SourceCompartment")] string SourceCompartment { get; set; }
    [JsonProperty("TargetCompartment")] string TargetCompartment { get; set; }
}

public class CompartmentGraphData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Compartment")] List<string> Compartment { get; set; }
    [JsonProperty("Link")] List<string> Link { get; set; }
}

public class FluidCompartmentData
{
    [JsonProperty("Compartment")] CompartmentData Compartment { get; set; }
    [JsonProperty("InFlow")] ScalarVolumePerTimeData InFlow { get; set; }
    [JsonProperty("AverageInFlow")] ScalarVolumePerTimeData AverageInFlow { get; set; }
    [JsonProperty("InFlowRunningAverage")] RunningAverageData InFlowRunningAverage { get; set; }
    [JsonProperty("OutFlow")] ScalarVolumePerTimeData OutFlow { get; set; }
    [JsonProperty("AverageOutFlow")] ScalarVolumePerTimeData AverageOutFlow { get; set; }

    [JsonProperty("OutFlowRunningAverage")]
    RunningAverageData OutFlowRunningAverage { get; set; }

    [JsonProperty("Pressure")] ScalarPressureData Pressure { get; set; }
    [JsonProperty("Volume")] ScalarVolumeData Volume { get; set; }
}

public class FluidCompartmentLinkData
{
    [JsonProperty("Link")] CompartmentLinkData Link { get; set; }
    [JsonProperty("Flow")] ScalarVolumePerTimeData Flow { get; set; }
}

public class FluidCompartmentGraphData
{
    [JsonProperty("Graph")] CompartmentGraphData Graph { get; set; }
}

public class GasCompartmentData
{
    [JsonProperty("FluidCompartment")] FluidCompartmentData FluidCompartment { get; set; }
    [JsonProperty("DiffusionSurfaceArea")] ScalarAreaData DiffusionSurfaceArea { get; set; }
    [JsonProperty("Ventilation")] ScalarVolumePerTimeData Ventilation { get; set; }

    [JsonProperty("VentilationPerfusionRatio")]
    ScalarData VentilationPerfusionRatio { get; set; }

    [JsonProperty("SubstanceQuantity")]
    List<GasSubstanceQuantityData> SubstanceQuantity { get; set; }
}

public class GasCompartmentLinkData
{
    [JsonProperty("FluidLink")] FluidCompartmentLinkData FluidLink { get; set; }
}

public class GasCompartmentGraphData
{
    [JsonProperty("FluidGraph")] FluidCompartmentGraphData FluidGraph { get; set; }
}

public class LiquidCompartmentData
{
    [JsonProperty("FluidCompartment")] FluidCompartmentData FluidCompartment { get; set; }
    [JsonProperty("Perfusion")] ScalarVolumePerTimeData Perfusion { get; set; }
    [JsonProperty("pH")] ScalarData pH { get; set; }
    [JsonProperty("WaterVolumeFraction")] Scalar0To1Data WaterVolumeFraction { get; set; }

    [JsonProperty("SubstanceQuantity")]
    List<LiquidSubstanceQuantityData> SubstanceQuantity { get; set; }
}

public class LiquidCompartmentLinkData
{
    [JsonProperty("FluidLink")] FluidCompartmentLinkData FluidLink { get; set; }
}

public class LiquidCompartmentGraphData
{
    [JsonProperty("FluidGraph")] FluidCompartmentGraphData FluidGraph { get; set; }
}

public class TissueCompartmentData
{
    [JsonProperty("Compartment")] CompartmentData Compartment { get; set; }

    [JsonProperty("AcidicPhospohlipidConcentration")]
    ScalarMassPerMassData AcidicPhospohlipidConcentration { get; set; }

    [JsonProperty("MatrixVolume")] ScalarVolumeData MatrixVolume { get; set; }

    [JsonProperty("NeutralLipidsVolumeFraction")]
    Scalar0To1Data NeutralLipidsVolumeFraction { get; set; }

    [JsonProperty("NeutralPhospholipidsVolumeFraction")]
    Scalar0To1Data NeutralPhospholipidsVolumeFraction { get; set; }

    [JsonProperty("TissueToPlasmaAlbuminRatio")]
    ScalarData TissueToPlasmaAlbuminRatio { get; set; }

    [JsonProperty("TissueToPlasmaAlphaAcidGlycoproteinRatio")]
    ScalarData TissueToPlasmaAlphaAcidGlycoproteinRatio { get; set; }

    [JsonProperty("TissueToPlasmaLipoproteinRatio")]
    ScalarData TissueToPlasmaLipoproteinRatio { get; set; }

    [JsonProperty("TotalMass")] ScalarMassData TotalMass { get; set; }
}

public class ThermalCompartmentData
{
    [JsonProperty("Compartment")] CompartmentData Compartment { get; set; }
    [JsonProperty("HeatTransferRateIn")] ScalarPowerData HeatTransferRateIn { get; set; }
    [JsonProperty("HeatTransferRateOut")] ScalarPowerData HeatTransferRateOut { get; set; }
    [JsonProperty("Temperature")] ScalarTemperatureData Temperature { get; set; }
    [JsonProperty("Heat")] ScalarEnergyData Heat { get; set; }
}

public class ThermalCompartmentLinkData
{
    [JsonProperty("Link")] CompartmentLinkData Link { get; set; }
    [JsonProperty("HeatTransferRate")] ScalarPowerData HeatTransferRate { get; set; }
}

public class ElectricalCompartmentData
{
    [JsonProperty("Compartment")] CompartmentData Compartment { get; set; }
    [JsonProperty("CurrentIn")] ScalarElectricCurrentData CurrentIn { get; set; }
    [JsonProperty("CurrentOut")] ScalarElectricCurrentData CurrentOut { get; set; }
    [JsonProperty("Voltage")] ScalarElectricPotentialData Voltage { get; set; }
    [JsonProperty("Charge")] ScalarElectricChargeData Charge { get; set; }
}

public class ElectricalCompartmentLinkData
{
    [JsonProperty("Link")] CompartmentLinkData Link { get; set; }
    [JsonProperty("Current")] ScalarElectricCurrentData Current { get; set; }
}

public class CompartmentManagerData
{
    [JsonProperty("ElectricalCompartment")]
    List<ElectricalCompartmentData> ElectricalCompartment { get; set; }

    [JsonProperty("ElectricalLink")]
    List<ElectricalCompartmentLinkData> ElectricalLink { get; set; }

    [JsonProperty("LiquidCompartment")]
    List<LiquidCompartmentData> LiquidCompartment { get; set; }

    [JsonProperty("LiquidLink")]
    List<LiquidCompartmentLinkData> LiquidLink { get; set; }

    [JsonProperty("LiquidSubstance")] List<string> LiquidSubstance { get; set; }

    [JsonProperty("LiquidGraph")]
    List<LiquidCompartmentGraphData> LiquidGraph { get; set; }

    [JsonProperty("GasCompartment")] List<GasCompartmentData> GasCompartment { get; set; }

    [JsonProperty("GasLink")]
    List<GasCompartmentLinkData> GasLink { get; set; }

    [JsonProperty("GasSubstance")] List<string> GasSubstance { get; set; }

    [JsonProperty("GasGraph")]
    List<GasCompartmentGraphData> GasGraph { get; set; }

    [JsonProperty("ThermalCompartment")]
    List<ThermalCompartmentData> ThermalCompartment { get; set; }

    [JsonProperty("ThermalLink")]
    List<ThermalCompartmentLinkData> ThermalLink { get; set; }

    [JsonProperty("TissueCompartment")]
    List<TissueCompartmentData> TissueCompartment { get; set; }

    [JsonProperty("TissueSubstance")] List<string> TissueSubstance { get; set; }
}