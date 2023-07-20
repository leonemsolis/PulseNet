using System.Collections.Generic;
using Newtonsoft.Json;
using PulseNet.DataModelBindings.CDM;

namespace PulseNet.DataModelBindings.Engine;

public class BloodChemistryData
{
    [JsonProperty("Common")] BloodChemistrySystemData Common { get; set; }

    [JsonProperty("ArterialOxygenAverage_mmHg")]
    RunningAverageData ArterialOxygenAverage_mmHg { get; set; }

    [JsonProperty("ArterialCarbonDioxideAverage_mmHg")]
    RunningAverageData ArterialCarbonDioxideAverage_mmHg { get; set; }
}

public class CardiovascularData
{
    [JsonProperty("Common")] CardiovascularSystemData Common { get; set; }
    [JsonProperty("StartSystole")] bool StartSystole { get; set; }
    [JsonProperty("HeartFlowDetected")] bool HeartFlowDetected { get; set; }
    [JsonProperty("FullyCompressedHeart")] bool FullyCompressedHeart { get; set; }

    [JsonProperty("StabilizedHeartRateBaseline_Per_min")]
    double StabilizedHeartRateBaseline_Per_min { get; set; }

    [JsonProperty("StabilizedMeanArterialPressureBaseline_mmHg")]
    double StabilizedMeanArterialPressureBaseline_mmHg { get; set; }

    // Driver Variables
    [JsonProperty("CurrentDriverCycleTime_s")]
    double CurrentDriverCycleTime_s { get; set; }

    [JsonProperty("DriverCyclePeriod_s")] double DriverCyclePeriod_s { get; set; }

    [JsonProperty("LeftHeartElastanceModifier")]
    double LeftHeartElastanceModifier { get; set; }

    [JsonProperty("LeftHeartElastance_mmHg_Per_mL")]
    double LeftHeartElastance_mmHg_Per_mL { get; set; }

    [JsonProperty("LeftHeartElastanceMax_mmHg_Per_mL")]
    double LeftHeartElastanceMax_mmHg_Per_mL { get; set; }

    [JsonProperty("LeftHeartElastanceMin_mmHg_Per_mL")]
    double LeftHeartElastanceMin_mmHg_Per_mL { get; set; }

    [JsonProperty("RightHeartElastance_mmHg_Per_mL")]
    double RightHeartElastance_mmHg_Per_mL { get; set; }

    [JsonProperty("RightHeartElastanceMax_mmHg_Per_mL")]
    double RightHeartElastanceMax_mmHg_Per_mL { get; set; }

    [JsonProperty("RightHeartElastanceMin_mmHg_Per_mL")]
    double RightHeartElastanceMin_mmHg_Per_mL { get; set; }

    // Arrhythmia
    [JsonProperty("EnableFeedbackAfterArrhythmiaTrasition")]
    eSwitch EnableFeedbackAfterArrhythmiaTrasition { get; set; }

    [JsonProperty("StartCardiacArrest")] bool StartCardiacArrest { get; set; }
    [JsonProperty("TransitionArrhythmia")] bool TransitionArrhythmia { get; set; }

    [JsonProperty("CardiacArrestVitalsUpdateTimer_s")]
    double CardiacArrestVitalsUpdateTimer_s { get; set; }

    [JsonProperty("HeartRateBaseline_Per_min")]
    TemporalInterpolatorData HeartRateBaseline_Per_min { get; set; }

    [JsonProperty("HeartComplianceModifier")]
    TemporalInterpolatorData HeartComplianceModifier { get; set; }

    [JsonProperty("AortaComplianceModifier")]
    TemporalInterpolatorData AortaComplianceModifier { get; set; }

    [JsonProperty("VenaCavaComplianceModifier")]
    TemporalInterpolatorData VenaCavaComplianceModifier { get; set; }

    [JsonProperty("PulmonaryComplianceModifier")]
    TemporalInterpolatorData PulmonaryComplianceModifier { get; set; }

    [JsonProperty("SystemicVascularResistanceModifier")]
    TemporalInterpolatorData SystemicVascularResistanceModifier { get; set; }

    [JsonProperty("SystemicVascularComplianceModifier")]
    TemporalInterpolatorData SystemicVascularComplianceModifier { get; set; }

    // CPR
    [JsonProperty("CompressionFrequencyCurrentTime_s")]
    double CompressionFrequencyCurrentTime_s { get; set; }

    [JsonProperty("CompressionFrequencyDuration_s")]
    double CompressionFrequencyDuration_s { get; set; }

    [JsonProperty("CompressionPeriod_s")] double CompressionPeriod_s { get; set; }

    [JsonProperty("CompressionPeriodCurrentTime_s")]
    double CompressionPeriodCurrentTime_s { get; set; }

    // Vitals and Averages
    [JsonProperty("CardiacCycleDiastolicVolume_mL")]
    double CardiacCycleDiastolicVolume_mL { get; set; }

    [JsonProperty("CardiacCycleAortaPressureHigh_mmHg")]
    double CardiacCycleAortaPressureHigh_mmHg { get; set; }

    [JsonProperty("CardiacCycleAortaPressureLow_mmHg")]
    double CardiacCycleAortaPressureLow_mmHg { get; set; }

    [JsonProperty("CardiacCycleLeftHeartPressureHigh_mmHg")]
    double CardiacCycleLeftHeartPressureHigh_mmHg { get; set; }

    [JsonProperty("CardiacCycleLeftHeartPressureLow_mmHg")]
    double CardiacCycleLeftHeartPressureLow_mmHg { get; set; }

    [JsonProperty("CardiacCyclePulmonaryArteryPressureHigh_mmHg")]
    double CardiacCyclePulmonaryArteryPressureHigh_mmHg { get; set; }

    [JsonProperty("CardiacCyclePulmonaryArteryPressureLow_mmHg")]
    double CardiacCyclePulmonaryArteryPressureLow_mmHg { get; set; }

    [JsonProperty("CardiacCycleRightHeartPressureHigh_mmHg")]
    double CardiacCycleRightHeartPressureHigh_mmHg { get; set; }

    [JsonProperty("CardiacCycleRightHeartPressureLow_mmHg")]
    double CardiacCycleRightHeartPressureLow_mmHg { get; set; }

    [JsonProperty("LastCardiacCycleMeanArterialCO2PartialPressure_mmHg")]
    double LastCardiacCycleMeanArterialCO2PartialPressure_mmHg { get; set; }

    [JsonProperty("CardiacCycleStrokeVolume_mL")]
    double CardiacCycleStrokeVolume_mL { get; set; }

    [JsonProperty("LeftCardiacCyclePerfusionVolumes_mL")]
    List<double> LeftCardiacCyclePerfusionVolumes_mL { get; set; }

    [JsonProperty("RightCardiacCyclePerfusionVolumes_mL")]
    List<double> RightCardiacCyclePerfusionVolumes_mL { get; set; }

    [JsonProperty("CardiacCycleArterialPressure_mmHg")]
    RunningAverageData CardiacCycleArterialPressure_mmHg { get; set; }

    [JsonProperty("CardiacCycleArterialCO2PartialPressure_mmHg")]
    RunningAverageData CardiacCycleArterialCO2PartialPressure_mmHg { get; set; }

    [JsonProperty("CardiacCyclePulmonaryCapillariesWedgePressure_mmHg")]
    RunningAverageData CardiacCyclePulmonaryCapillariesWedgePressure_mmHg { get; set; }

    [JsonProperty("CardiacCyclePulmonaryCapillariesFlow_mL_Per_s")]
    RunningAverageData CardiacCyclePulmonaryCapillariesFlow_mL_Per_s { get; set; }

    [JsonProperty("CardiacCyclePulmonaryShuntFlow_mL_Per_s")]
    RunningAverageData CardiacCyclePulmonaryShuntFlow_mL_Per_s { get; set; }

    [JsonProperty("CardiacCyclePulmonaryArteryPressure_mmHg")]
    RunningAverageData CardiacCyclePulmonaryArteryPressure_mmHg { get; set; }

    [JsonProperty("CardiacCycleCentralVenousPressure_mmHg")]
    RunningAverageData CardiacCycleCentralVenousPressure_mmHg { get; set; }

    [JsonProperty("CardiacCycleSkinFlow_mL_Per_s")]
    RunningAverageData CardiacCycleSkinFlow_mL_Per_s { get; set; }
}

public class DrugData
{
    [JsonProperty("Common")] DrugSystemData Common { get; set; }
}

public class EndocrineData
{
    [JsonProperty("Common")] EndocrineSystemData Common { get; set; }
}

public class EnergyData
{
    [JsonProperty("Common")] EnergySystemData Common { get; set; }

    [JsonProperty("EnduranceEnergyStore_J")]
    double EnduranceEnergyStore_J { get; set; }

    [JsonProperty("MediumPowerEnergyStore_J")]
    double MediumPowerEnergyStore_J { get; set; }

    [JsonProperty("PeakPowerEnergyStore_J")]
    double PeakPowerEnergyStore_J { get; set; }

    [JsonProperty("UsableEnergyStore_J")] double UsableEnergyStore_J { get; set; }

    [JsonProperty("BloodpH")] RunningAverageData BloodpH { get; set; }

    [JsonProperty("BicarbonateMolarity_mmol_Per_L")]
    RunningAverageData BicarbonateMolarity_mmol_Per_L { get; set; }
}

public class GastrointestinalData
{
    [JsonProperty("Common")] GastrointestinalSystemData Common { get; set; }
}

public class HepaticData
{
    [JsonProperty("Common")] HepaticSystemData Common { get; set; }
}

public class NervousData
{
    [JsonProperty("Common")] NervousSystemData Common { get; set; }

    [JsonProperty("ArterialOxygenBaseline_mmHg")]
    double ArterialOxygenBaseline_mmHg { get; set; }

    [JsonProperty("ArterialCarbonDioxideBaseline_mmHg")]
    double ArterialCarbonDioxideBaseline_mmHg { get; set; }

    [JsonProperty("BaroreceptorFeedbackStatus")]
    bool BaroreceptorFeedbackStatus { get; set; }

    [JsonProperty("BaroreceptorSaturationStatus")]
    bool BaroreceptorSaturationStatus { get; set; }

    [JsonProperty("BaroreceptorActiveTime_s")]
    double BaroreceptorActiveTime_s { get; set; }

    [JsonProperty("BaroreceptorEffectivenessParameter")]
    double BaroreceptorEffectivenessParameter { get; set; }

    [JsonProperty("BaroreceptorSaturationTime_s")]
    double BaroreceptorSaturationTime_s { get; set; }

    [JsonProperty("LastMeanArterialPressure_mmHg")]
    double LastMeanArterialPressure_mmHg { get; set; }

    [JsonProperty("PreviousBloodVolume_mL")]
    double PreviousBloodVolume_mL { get; set; }

    [JsonProperty("PreviousHeartRhythm")] eHeartRhythm PreviousHeartRhythm { get; set; }

    [JsonProperty("TotalSympatheticFraction")]
    double TotalSympatheticFraction { get; set; }
}

public class RenalData
{
    [JsonProperty("Common")] RenalSystemData Common { get; set; }
    [JsonProperty("Urinating")] bool Urinating { get; set; }

    [JsonProperty("LeftAfferentResistance_mmHg_s_Per_mL")]
    double LeftAfferentResistance_mmHg_s_Per_mL { get; set; }

    [JsonProperty("RightAfferentResistance_mmHg_s_Per_mL")]
    double RightAfferentResistance_mmHg_s_Per_mL { get; set; }

    [JsonProperty("LeftSodiumFlowSetPoint_mg_Per_s")]
    double LeftSodiumFlowSetPoint_mg_Per_s { get; set; }

    [JsonProperty("RightSodiumFlowSetPoint_mg_Per_s")]
    double RightSodiumFlowSetPoint_mg_Per_s { get; set; }

    [JsonProperty("UrineProductionRate_mL_Per_min")]
    RunningAverageData UrineProductionRate_mL_Per_min { get; set; }

    [JsonProperty("UrineOsmolarity_mOsm_Per_L")]
    RunningAverageData UrineOsmolarity_mOsm_Per_L { get; set; }

    [JsonProperty("SodiumConcentration_mg_Per_mL")]
    RunningAverageData SodiumConcentration_mg_Per_mL { get; set; }

    [JsonProperty("SodiumExcretionRate_mg_Per_min")]
    RunningAverageData SodiumExcretionRate_mg_Per_min { get; set; }

    [JsonProperty("LeftSodiumFlow_mg_Per_s")]
    RunningAverageData LeftSodiumFlow_mg_Per_s { get; set; }

    [JsonProperty("RightSodiumFlow_mg_Per_s")]
    RunningAverageData RightSodiumFlow_mg_Per_s { get; set; }

    [JsonProperty("LeftRenalArterialPressure_mmHg")]
    RunningAverageData LeftRenalArterialPressure_mmHg { get; set; }

    [JsonProperty("RightRenalArterialPressure_mmHg")]
    RunningAverageData RightRenalArterialPressure_mmHg { get; set; }
}

public class RespiratoryData
{
    // Next value : 45
    [JsonProperty("Common")] RespiratorySystemData Common { get; set; }

    [JsonProperty("BreathingCycle")] bool BreathingCycle { get; set; }
    [JsonProperty("NotBreathing")] bool NotBreathing { get; set; }

    [JsonProperty("TopBreathTotalVolume_L")]
    double TopBreathTotalVolume_L { get; set; }

    [JsonProperty("LastCardiacCycleBloodPH")]
    double LastCardiacCycleBloodPH { get; set; }

    [JsonProperty("TopCarinaO2")] double TopCarinaO2 { get; set; }

    [JsonProperty("TopBreathElapsedTime_min")]
    double TopBreathElapsedTime_min { get; set; }

    [JsonProperty("BottomBreathElapsedTime_min")]
    double BottomBreathElapsedTime_min { get; set; }

    [JsonProperty("BottomBreathTotalVolume_L")]
    double BottomBreathTotalVolume_L { get; set; }

    [JsonProperty("BottomBreathAlveoliPressure_cmH2O")]
    double BottomBreathAlveoliPressure_cmH2O { get; set; }

    [JsonProperty("PeakAlveolarPressure_cmH2O")]
    double PeakAlveolarPressure_cmH2O { get; set; }

    [JsonProperty("MaximalAlveolarPressure_cmH2O")]
    double MaximalAlveolarPressure_cmH2O { get; set; }

    [JsonProperty("BloodPHRunningAverage")]
    RunningAverageData BloodPHRunningAverage { get; set; }

    [JsonProperty("MeanAirwayPressure_cmH2O")]
    RunningAverageData MeanAirwayPressure_cmH2O { get; set; }

    [JsonProperty("LeftTopBreathAcinarZoneVolumes_L")]
    List<double> LeftTopBreathAcinarZoneVolumes_L { get; set; }

    [JsonProperty("RightTopBreathAcinarZoneVolumes_L")]
    List<double> RightTopBreathAcinarZoneVolumes_L { get; set; }

    [JsonProperty("LeftBottomBreathAcinarZoneVolumes_L")]
    List<double> LeftBottomBreathAcinarZoneVolumes_L { get; set; }

    [JsonProperty("RightBottomBreathAcinarZoneVolumes_L")]
    List<double> RightBottomBreathAcinarZoneVolumes_L { get; set; }

    [JsonProperty("PreviousPleuralVolume_L")]
    double PreviousPleuralVolume_L { get; set; }

    [JsonProperty("ArterialO2PartialPressure_mmHg")]
    double ArterialO2PartialPressure_mmHg { get; set; }

    [JsonProperty("ArterialCO2PartialPressure_mmHg")]
    double ArterialCO2PartialPressure_mmHg { get; set; }

    [JsonProperty("BreathingCycleTime_s")] double BreathingCycleTime_s { get; set; }
    [JsonProperty("DriverPressure_cmH2O")] double DriverPressure_cmH2O { get; set; }

    [JsonProperty("ElapsedBreathingCycleTime_min")]
    double ElapsedBreathingCycleTime_min { get; set; }

    [JsonProperty("IERatioScaleFactor")] double IERatioScaleFactor { get; set; }

    [JsonProperty("PeakInspiratoryPressure_cmH2O")]
    double PeakInspiratoryPressure_cmH2O { get; set; }

    [JsonProperty("PeakExpiratoryPressure_cmH2O")]
    double PeakExpiratoryPressure_cmH2O { get; set; }

    [JsonProperty("PreviousTargetAlveolarVentilation_L_Per_min")]
    double PreviousTargetAlveolarVentilation_L_Per_min { get; set; }

    [JsonProperty("VentilationFrequency_Per_min")]
    double VentilationFrequency_Per_min { get; set; }

    [JsonProperty("VentilationToTidalVolumeSlope")]
    double VentilationToTidalVolumeSlope { get; set; }

    [JsonProperty("ArterialO2RunningAverage_mmHg")]
    RunningAverageData ArterialO2RunningAverage_mmHg { get; set; }

    [JsonProperty("ArterialCO2RunningAverage_mmHg")]
    RunningAverageData ArterialCO2RunningAverage_mmHg { get; set; }

    // Muscle Pressure Waveform
    [JsonProperty("ExpiratoryHoldFraction")]
    double ExpiratoryHoldFraction { get; set; }

    [JsonProperty("ExpiratoryReleaseFraction")]
    double ExpiratoryReleaseFraction { get; set; }

    [JsonProperty("ExpiratoryRiseFraction")]
    double ExpiratoryRiseFraction { get; set; }

    [JsonProperty("InspiratoryHoldFraction")]
    double InspiratoryHoldFraction { get; set; }

    [JsonProperty("InspiratoryReleaseFraction")]
    double InspiratoryReleaseFraction { get; set; }

    [JsonProperty("InspiratoryRiseFraction")]
    double InspiratoryRiseFraction { get; set; }

    [JsonProperty("InspiratoryToExpiratoryPauseFraction")]
    double InspiratoryToExpiratoryPauseFraction { get; set; }

    [JsonProperty("ResidueFraction")] double ResidueFraction { get; set; }

    [JsonProperty("PreviousDyspneaSeverity")]
    double PreviousDyspneaSeverity { get; set; }

    // Conscious Breathing
    [JsonProperty("ActiveConsciousRespirationCommand")]
    bool ActiveConsciousRespirationCommand { get; set; }

    // Disease States
    [JsonProperty("LeftAlveoliDecrease_L")]
    double LeftAlveoliDecrease_L { get; set; }

    [JsonProperty("RightAlveoliDecrease_L")]
    double RightAlveoliDecrease_L { get; set; }

    // Overrides
    [JsonProperty("RespiratoryComplianceOverride_L_Per_cmH2O")]
    double RespiratoryComplianceOverride_L_Per_cmH2O { get; set; }

    [JsonProperty("RespiratoryResistanceOverride_cmH2O_s_Per_L")]
    double RespiratoryResistanceOverride_cmH2O_s_Per_L { get; set; }
}

public class TissueData
{
    [JsonProperty("Common")] TissueSystemData Common { get; set; }

    [JsonProperty("CardiacArrestVascularFlows_ml_per_min")]
    Dictionary<string, double> CardiacArrestVascularFlows_ml_per_min { get; set; }

    [JsonProperty("RestingTissueGlucose_g")]
    double RestingTissueGlucose_g { get; set; }

    [JsonProperty("RestingBloodGlucose_mg_Per_mL")]
    double RestingBloodGlucose_mg_Per_mL { get; set; }

    [JsonProperty("RestingBloodLipid_mg_Per_mL")]
    double RestingBloodLipid_mg_Per_mL { get; set; }

    [JsonProperty("RestingBloodInsulin_mg_Per_mL")]
    double RestingBloodInsulin_mg_Per_mL { get; set; }

    [JsonProperty("RestingFluidMass_kg")] double RestingFluidMass_kg { get; set; }
}