using System.Collections.Generic;
using Newtonsoft.Json;
using PulseNet.DataModelBindings.CDM;

namespace PulseNet.DataModelBindings.Engine;

public class ConfigurationData
{
    public class BloodChemistryConfigurationData
    {
        [JsonProperty("MeanCorpuscularHemoglobin")]
        ScalarMassPerAmountData MeanCorpuscularHemoglobin { get; set; }

        [JsonProperty("MeanCorpuscularVolume")]
        ScalarVolumeData MeanCorpuscularVolume { get; set; }

        [JsonProperty("StandardDiffusionDistance")]
        ScalarLengthData StandardDiffusionDistance { get; set; }

        [JsonProperty("StandardOxygenDiffusionCoefficient")]
        ScalarAreaPerTimePressureData StandardOxygenDiffusionCoefficient { get; set; }
    }

    public class CardiovascularConfigurationData
    {
        [JsonProperty("LeftHeartElastanceMaximum")]
        ScalarPressurePerVolumeData LeftHeartElastanceMaximum { get; set; }

        [JsonProperty("LeftHeartElastanceMinimum")]
        ScalarPressurePerVolumeData LeftHeartElastanceMinimum { get; set; }

        [JsonProperty("MinimumBloodVolumeFraction")]
        Scalar0To1Data MinimumBloodVolumeFraction { get; set; }

        [JsonProperty("RightHeartElastanceMaximum")]
        ScalarPressurePerVolumeData RightHeartElastanceMaximum { get; set; }

        [JsonProperty("RightHeartElastanceMinimum")]
        ScalarPressurePerVolumeData RightHeartElastanceMinimum { get; set; }

        [JsonProperty("StandardPulmonaryCapillaryCoverage")]
        ScalarData StandardPulmonaryCapillaryCoverage { get; set; }

        [JsonProperty("UseExpandedVasculature")]
        eSwitch UseExpandedVasculature { get; set; }

        [JsonProperty("TuneCardiovascularCircuit")]
        eSwitch TuneCardiovascularCircuit { get; set; }

        [JsonProperty("CardiovascularTuningFile")]
        string CardiovascularTuningFile { get; set; }
    }

    public class CircuitConfigurationData
    {
        [JsonProperty("CardiovascularOpenResistance")]
        ScalarPressureTimePerVolumeData CardiovascularOpenResistance { get; set; }

        [JsonProperty("DefaultClosedElectricResistance")]
        ScalarElectricResistanceData DefaultClosedElectricResistance { get; set; }

        [JsonProperty("DefaultOpenElectricResistance")]
        ScalarElectricResistanceData DefaultOpenElectricResistance { get; set; }

        [JsonProperty("DefaultClosedFlowResistance")]
        ScalarPressureTimePerVolumeData DefaultClosedFlowResistance { get; set; }

        [JsonProperty("DefaultOpenFlowResistance")]
        ScalarPressureTimePerVolumeData DefaultOpenFlowResistance { get; set; }

        [JsonProperty("DefaultClosedHeatResistance")]
        ScalarHeatResistanceData DefaultClosedHeatResistance { get; set; }

        [JsonProperty("DefaultOpenHeatResistance")]
        ScalarHeatResistanceData DefaultOpenHeatResistance { get; set; }

        [JsonProperty("MachineClosedResistance")]
        ScalarPressureTimePerVolumeData MachineClosedResistance { get; set; }

        [JsonProperty("MachineOpenResistance")]
        ScalarPressureTimePerVolumeData MachineOpenResistance { get; set; }

        [JsonProperty("RespiratoryClosedResistance")]
        ScalarPressureTimePerVolumeData RespiratoryClosedResistance { get; set; }

        [JsonProperty("RespiratoryOpenResistance")]
        ScalarPressureTimePerVolumeData RespiratoryOpenResistance { get; set; }
    }

    public class ConstantsConfigurationData
    {
        [JsonProperty("OxygenMetabolicConstant")]
        ScalarData OxygenMetabolicConstant { get; set; }

        [JsonProperty("StefanBoltzmann")] ScalarPowerPerAreaTemperatureToTheFourthData StefanBoltzmann { get; set; }
        [JsonProperty("UniversalGasConstant")] ScalarHeatCapacitancePerAmountData UniversalGasConstant { get; set; }
    }

    public class DrugsConfigurationData
    {
        [JsonProperty("PDModel")] eSwitch PDModel { get; set; }
    }

    public class ECGConfigurationData
    {
        [JsonProperty("AvailableWaveforms")] ElectroCardioGramData AvailableWaveforms { get; set; }

        [JsonProperty("AvailableWaveformsFile")]
        string AvailableWaveformsFile { get; set; }
    }

    public class EnergyConfigurationData
    {
        [JsonProperty("BodySpecificHeat")] ScalarHeatCapacitancePerMassData BodySpecificHeat { get; set; }

        [JsonProperty("CarbonDioxideProductionFromOxygenConsumptionConstant")]
        ScalarData CarbonDioxideProductionFromOxygenConsumptionConstant { get; set; }

        [JsonProperty("CoreTemperatureLow")] ScalarTemperatureData CoreTemperatureLow { get; set; }
        [JsonProperty("CoreTemperatureHigh")] ScalarTemperatureData CoreTemperatureHigh { get; set; }

        [JsonProperty("DeltaCoreTemperatureLow")]
        ScalarTemperatureData DeltaCoreTemperatureLow { get; set; }

        [JsonProperty("EnergyPerATP")] ScalarEnergyPerAmountData EnergyPerATP { get; set; }
        [JsonProperty("SweatHeatTransfer")] ScalarHeatConductanceData SweatHeatTransfer { get; set; }
        [JsonProperty("VaporizationEnergy")] ScalarEnergyPerMassData VaporizationEnergy { get; set; }
        [JsonProperty("VaporSpecificHeat")] ScalarHeatCapacitancePerMassData VaporSpecificHeat { get; set; }
    }

    public class EnvironmentConfigurationData
    {
        [JsonProperty("InitialConditions")] EnvironmentalConditionsData InitialConditions { get; set; }

        [JsonProperty("InitialConditionsFile")]
        string InitialConditionsFile { get; set; }

        [JsonProperty("AirDensity")] ScalarMassPerVolumeData AirDensity { get; set; }
        [JsonProperty("AirSpecificHeat")] ScalarHeatCapacitancePerMassData AirSpecificHeat { get; set; }
        [JsonProperty("MolarMassOfDryAir")] ScalarMassPerAmountData MolarMassOfDryAir { get; set; }

        [JsonProperty("MolarMassOfWaterVapor")]
        ScalarMassPerAmountData MolarMassOfWaterVapor { get; set; }

        [JsonProperty("WaterDensity")] ScalarMassPerVolumeData WaterDensity { get; set; }
    }

    public class GastrointestinalConfigurationData
    {
        [JsonProperty("InitialStomachContents")]
        NutritionData InitialStomachContents { get; set; }

        [JsonProperty("InitialStomachContentsFile")]
        string InitialStomachContentsFile { get; set; }

        [JsonProperty("CalciumAbsorptionFraction")]
        Scalar0To1Data CalciumAbsorptionFraction { get; set; }

        [JsonProperty("CalciumDigestionRate")] ScalarMassPerTimeData CalciumDigestionRate { get; set; }

        [JsonProperty("CarbohydrateAbsorptionFraction")]
        Scalar0To1Data CarbohydrateAbsorptionFraction { get; set; }

        [JsonProperty("DefaultCarbohydrateDigestionRate")]
        ScalarMassPerTimeData DefaultCarbohydrateDigestionRate { get; set; }

        [JsonProperty("DefaultFatDigestionRate")]
        ScalarMassPerTimeData DefaultFatDigestionRate { get; set; }

        [JsonProperty("DefaultProteinDigestionRate")]
        ScalarMassPerTimeData DefaultProteinDigestionRate { get; set; }

        [JsonProperty("FatAbsorptionFraction")]
        Scalar0To1Data FatAbsorptionFraction { get; set; }

        [JsonProperty("ProteinToUreaFraction")]
        Scalar0To1Data ProteinToUreaFraction { get; set; }

        [JsonProperty("WaterDigestionRate")] ScalarVolumePerTimeData WaterDigestionRate { get; set; }
    }

    public class NervousConfigurationData
    {
        [JsonProperty("EnableCerebrospinalFluid")]
        eSwitch EnableCerebrospinalFluid { get; set; }

        [JsonProperty("ChemoreceptorFeedback")]
        eSwitch ChemoreceptorFeedback { get; set; }

        [JsonProperty("BaroreceptorFeedback")] eSwitch BaroreceptorFeedback { get; set; }

        [JsonProperty("HeartElastanceDistributedTimeDelay")]
        ScalarTimeData HeartElastanceDistributedTimeDelay { get; set; }

        [JsonProperty("HeartRateDistributedTimeDelay")]
        ScalarTimeData HeartRateDistributedTimeDelay { get; set; }

        [JsonProperty("NormalizedHeartRateIntercept")]
        ScalarData NormalizedHeartRateIntercept { get; set; }

        [JsonProperty("NormalizedHeartRateSympatheticSlope")]
        ScalarData NormalizedHeartRateSympatheticSlope { get; set; }

        [JsonProperty("NormalizedHeartRateParasympatheticSlope")]
        ScalarData NormalizedHeartRateParasympatheticSlope { get; set; }

        [JsonProperty("NormalizedHeartElastanceIntercept")]
        ScalarData NormalizedHeartElastanceIntercept { get; set; }

        [JsonProperty("NormalizedHeartElastanceSympatheticSlope")]
        ScalarData NormalizedHeartElastanceSympatheticSlope { get; set; }

        [JsonProperty("NormalizedResistanceIntercept")]
        ScalarData NormalizedResistanceIntercept { get; set; }

        [JsonProperty("NormalizedResistanceSympatheticSlope")]
        ScalarData NormalizedResistanceSympatheticSlope { get; set; }

        [JsonProperty("NormalizedComplianceIntercept")]
        ScalarData NormalizedComplianceIntercept { get; set; }

        [JsonProperty("NormalizedComplianceParasympatheticSlope")]
        ScalarData NormalizedComplianceParasympatheticSlope { get; set; }

        [JsonProperty("PupilDiameterBaseline")]
        ScalarLengthData PupilDiameterBaseline { get; set; }

        [JsonProperty("ResponseSlope")] ScalarData ResponseSlope { get; set; }

        [JsonProperty("SystemicResistanceDistributedTimeDelay")]
        ScalarTimeData SystemicResistanceDistributedTimeDelay { get; set; }

        [JsonProperty("VenousComplianceDistributedTimeDelay")]
        ScalarTimeData VenousComplianceDistributedTimeDelay { get; set; }
    }

    public class RenalConfigurationData
    {
        [JsonProperty("EnableRenal")] eSwitch EnableRenal { get; set; }

        [JsonProperty("PlasmaSodiumConcentrationSetPoint")]
        ScalarMassPerVolumeData PlasmaSodiumConcentrationSetPoint { get; set; }

        [JsonProperty("PeritubularPotassiumConcentrationSetPoint")]
        ScalarMassPerVolumeData PeritubularPotassiumConcentrationSetPoint { get; set; }

        [JsonProperty("LeftGlomerularFilteringSurfaceAreaBaseline")]
        ScalarAreaData LeftGlomerularFilteringSurfaceAreaBaseline { get; set; }

        [JsonProperty("LeftGlomerularFluidPermeabilityBaseline")]
        ScalarVolumePerTimePressureAreaData LeftGlomerularFluidPermeabilityBaseline { get; set; }

        [JsonProperty("LeftTubularReabsorptionFilteringSurfaceAreaBaseline")]
        ScalarAreaData LeftTubularReabsorptionFilteringSurfaceAreaBaseline { get; set; }

        [JsonProperty("LeftTubularReabsorptionFluidPermeabilityBaseline")]
        ScalarVolumePerTimePressureAreaData LeftTubularReabsorptionFluidPermeabilityBaseline { get; set; }

        [JsonProperty("MaximumAfferentResistance")]
        ScalarPressureTimePerVolumeData MaximumAfferentResistance { get; set; }

        [JsonProperty("MinimumAfferentResistance")]
        ScalarPressureTimePerVolumeData MinimumAfferentResistance { get; set; }

        [JsonProperty("RightGlomerularFilteringSurfaceAreaBaseline")]
        ScalarAreaData RightGlomerularFilteringSurfaceAreaBaseline { get; set; }

        [JsonProperty("RightGlomerularFluidPermeabilityBaseline")]
        ScalarVolumePerTimePressureAreaData RightGlomerularFluidPermeabilityBaseline { get; set; }

        [JsonProperty("RightTubularReabsorptionFilteringSurfaceAreaBaseline")]
        ScalarAreaData RightTubularReabsorptionFilteringSurfaceAreaBaseline { get; set; }

        [JsonProperty("RightTubularReabsorptionFluidPermeabilityBaseline")]
        ScalarVolumePerTimePressureAreaData RightTubularReabsorptionFluidPermeabilityBaseline { get; set; }

        [JsonProperty("TargetSodiumDelivery")] ScalarMassPerTimeData TargetSodiumDelivery { get; set; }
    }

    public class RespiratoryConfigurationData
    {
        [JsonProperty("CentralControllerCO2PressureSetPoint")]
        ScalarPressureData CentralControllerCO2PressureSetPoint { get; set; }

        [JsonProperty("CentralVentilatoryControllerGain")]
        ScalarData CentralVentilatoryControllerGain { get; set; }

        [JsonProperty("MinimumAllowableTidalVolume")]
        ScalarVolumeData MinimumAllowableTidalVolume { get; set; }

        [JsonProperty("MinimumAllowableInspiratoryAndExpiratoryPeriod")]
        ScalarTimeData MinimumAllowableInspiratoryAndExpiratoryPeriod { get; set; }

        [JsonProperty("PeripheralControllerCO2PressureSetPoint")]
        ScalarPressureData PeripheralControllerCO2PressureSetPoint { get; set; }

        [JsonProperty("PeripheralVentilatoryControllerGain")]
        ScalarData PeripheralVentilatoryControllerGain { get; set; }

        [JsonProperty("PulmonaryVentilationRateMaximum")]
        ScalarVolumePerTimeData PulmonaryVentilationRateMaximum { get; set; }

        [JsonProperty("VentilationTidalVolumeIntercept")]
        ScalarVolumeData VentilationTidalVolumeIntercept { get; set; }

        [JsonProperty("VentilatoryOcclusionPressure")]
        ScalarPressureData VentilatoryOcclusionPressure { get; set; }

        [JsonProperty("UseExpandedRespiratory")]
        eSwitch UseExpandedRespiratory { get; set; }
    }

    public class TissueConfigurationData
    {
        [JsonProperty("EnableTissue")] eSwitch EnableTissue { get; set; }
    }

    [JsonProperty("TimeStep")] ScalarTimeData TimeStep { get; set; }
    [JsonProperty("AllowDynamicTimeStep")] eSwitch AllowDynamicTimeStep { get; set; }

    [JsonProperty("StabilizationFileName")]
    string StabilizationFileName { get; set; }

    [JsonProperty("TimedStabilization")] TimedStabilizationData TimedStabilization { get; set; }
    [JsonProperty("DynamicStabilization")] DynamicStabilizationData DynamicStabilization { get; set; }

    [JsonProperty("WritePatientBaselineFile")]
    eSwitch WritePatientBaselineFile { get; set; }

    [JsonProperty("PatientBaselineFilePath")]
    string PatientBaselineFilePath { get; set; }

    [JsonProperty("BloodChemistryConfiguration")]
    ConfigurationData.BloodChemistryConfigurationData BloodChemistryConfiguration { get; set; }

    [JsonProperty("CardiovascularConfiguration")]
    CardiovascularConfigurationData CardiovascularConfiguration { get; set; }

    [JsonProperty("CircuitConfiguration")] CircuitConfigurationData CircuitConfiguration { get; set; }

    [JsonProperty("ConstantsConfiguration")]
    ConstantsConfigurationData ConstantsConfiguration { get; set; }

    [JsonProperty("DrugsConfiguration")] DrugsConfigurationData DrugsConfiguration { get; set; }
    [JsonProperty("ECGConfiguration")] ECGConfigurationData ECGConfiguration { get; set; }
    [JsonProperty("EnergyConfiguration")] EnergyConfigurationData EnergyConfiguration { get; set; }

    [JsonProperty("EnvironmentConfiguration")]
    EnvironmentConfigurationData EnvironmentConfiguration { get; set; }

    [JsonProperty("GastrointestinalConfiguration")]
    GastrointestinalConfigurationData GastrointestinalConfiguration { get; set; }

    [JsonProperty("NervousConfiguration")] NervousConfigurationData NervousConfiguration { get; set; }
    [JsonProperty("RenalConfiguration")] RenalConfigurationData RenalConfiguration { get; set; }

    [JsonProperty("RespiratoryConfiguration")]
    RespiratoryConfigurationData RespiratoryConfiguration { get; set; }

    [JsonProperty("TissueConfiguration")] TissueConfigurationData TissueConfiguration { get; set; }
    [JsonProperty("Modifiers")] Dictionary<string, ScalarData> Modifiers { get; set; }
    [JsonProperty("Overrides")] Dictionary<string, ScalarData> Overrides { get; set; }
}