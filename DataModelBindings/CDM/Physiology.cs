using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public enum eHeartRhythm
{
    NormalSinus = 0,
    SinusBradycardia = 1,
    SinusTachycardia = 2,
    SinusPulselessElectricalActivity = 3,
    Asystole = 4,
    CoarseVentricularFibrillation = 5,
    FineVentricularFibrillation = 6,
    PulselessVentricularTachycardia = 7,
    StableVentricularTachycardia = 8,
    UnstableVentricularTachycardia = 9
}

public class PupillaryResponseData
{
    [JsonProperty("ReactivityModifier")] private ScalarNegative1To1Data ReactivityModifier { get; set; }
    [JsonProperty("ShapeModifier")] ScalarNegative1To1Data ShapeModifier { get; set; }
    [JsonProperty("SizeModifier")] ScalarNegative1To1Data SizeModifier { get; set; }
}

public class BloodChemistrySystemData
{
    [JsonProperty("BloodDensity")] ScalarMassPerVolumeData BloodDensity { get; set; }
    [JsonProperty("BloodPH")] ScalarData BloodPH { get; set; }
    [JsonProperty("BloodSpecificHeat")] ScalarHeatCapacitancePerMassData BloodSpecificHeat { get; set; }

    [JsonProperty("BloodUreaNitrogenConcentration")]
    ScalarMassPerVolumeData BloodUreaNitrogenConcentration { get; set; }

    [JsonProperty("CarbonDioxideSaturation")]
    Scalar0To1Data CarbonDioxideSaturation { get; set; }

    [JsonProperty("CarbonMonoxideSaturation")]
    Scalar0To1Data CarbonMonoxideSaturation { get; set; }

    [JsonProperty("Hematocrit")] Scalar0To1Data Hematocrit { get; set; }
    [JsonProperty("HemoglobinContent")] ScalarMassData HemoglobinContent { get; set; }
    [JsonProperty("OxygenSaturation")] Scalar0To1Data OxygenSaturation { get; set; }
    [JsonProperty("Phosphate")] ScalarAmountPerVolumeData Phosphate { get; set; }
    [JsonProperty("PlasmaVolume")] ScalarVolumeData PlasmaVolume { get; set; }
    [JsonProperty("PulseOximetry")] Scalar0To1Data PulseOximetry { get; set; }
    [JsonProperty("RedBloodCellCount")] ScalarAmountPerVolumeData RedBloodCellCount { get; set; }
    [JsonProperty("ShuntFraction")] Scalar0To1Data ShuntFraction { get; set; }
    [JsonProperty("StrongIonDifference")] ScalarAmountPerVolumeData StrongIonDifference { get; set; }

    [JsonProperty("TotalProteinConcentration")]
    ScalarMassPerVolumeData TotalProteinConcentration { get; set; }

    [JsonProperty("VolumeFractionNeutralLipidInPlasma")]
    Scalar0To1Data VolumeFractionNeutralLipidInPlasma { get; set; }

    [JsonProperty("VolumeFractionNeutralPhospholipidInPlasma")]
    Scalar0To1Data VolumeFractionNeutralPhospholipidInPlasma { get; set; }

    [JsonProperty("WhiteBloodCellCount")] ScalarAmountPerVolumeData WhiteBloodCellCount { get; set; }

    [JsonProperty("ArterialCarbonDioxidePressure")]
    ScalarPressureData ArterialCarbonDioxidePressure { get; set; }

    [JsonProperty("ArterialOxygenPressure")]
    ScalarPressureData ArterialOxygenPressure { get; set; }

    [JsonProperty("PulmonaryArterialCarbonDioxidePressure")]
    ScalarPressureData PulmonaryArterialCarbonDioxidePressure { get; set; }

    [JsonProperty("PulmonaryArterialOxygenPressure")]
    ScalarPressureData PulmonaryArterialOxygenPressure { get; set; }

    [JsonProperty("PulmonaryVenousCarbonDioxidePressure")]
    ScalarPressureData PulmonaryVenousCarbonDioxidePressure { get; set; }

    [JsonProperty("PulmonaryVenousOxygenPressure")]
    ScalarPressureData PulmonaryVenousOxygenPressure { get; set; }

    [JsonProperty("VenousCarbonDioxidePressure")]
    ScalarPressureData VenousCarbonDioxidePressure { get; set; }

    [JsonProperty("VenousOxygenPressure")] ScalarPressureData VenousOxygenPressure { get; set; }
}

public class CardiovascularSystemData
{
    [JsonProperty("ArterialPressure")] ScalarPressureData ArterialPressure { get; set; }
    [JsonProperty("BloodVolume")] ScalarVolumeData BloodVolume { get; set; }
    [JsonProperty("CardiacIndex")] ScalarVolumePerTimeAreaData CardiacIndex { get; set; }
    [JsonProperty("CardiacOutput")] ScalarVolumePerTimeData CardiacOutput { get; set; }

    [JsonProperty("CentralVenousPressure")]
    ScalarPressureData CentralVenousPressure { get; set; }

    [JsonProperty("CerebralBloodFlow")] ScalarVolumePerTimeData CerebralBloodFlow { get; set; }

    [JsonProperty("CerebralPerfusionPressure")]
    ScalarPressureData CerebralPerfusionPressure { get; set; }

    [JsonProperty("CoronaryPerfusionPressure")]
    ScalarPressureData CoronaryPerfusionPressure { get; set; }

    [JsonProperty("DiastolicArterialPressure")]
    ScalarPressureData DiastolicArterialPressure { get; set; }

    [JsonProperty("DiastolicLeftHeartPressure")]
    ScalarPressureData DiastolicLeftHeartPressure { get; set; }

    [JsonProperty("DiastolicRightHeartPressure")]
    ScalarPressureData DiastolicRightHeartPressure { get; set; }

    [JsonProperty("HeartEjectionFraction")]
    Scalar0To1Data HeartEjectionFraction { get; set; }

    [JsonProperty("HeartRate")] ScalarFrequencyData HeartRate { get; set; }
    [JsonProperty("HeartRhythm")] eHeartRhythm HeartRhythm { get; set; }
    [JsonProperty("HeartStrokeVolume")] ScalarVolumeData HeartStrokeVolume { get; set; }
    [JsonProperty("IntracranialPressure")] ScalarPressureData IntracranialPressure { get; set; }
    [JsonProperty("MeanArterialPressure")] ScalarPressureData MeanArterialPressure { get; set; }

    [JsonProperty("MeanArterialCarbonDioxidePartialPressure")]
    ScalarPressureData MeanArterialCarbonDioxidePartialPressure { get; set; }

    [JsonProperty("MeanArterialCarbonDioxidePartialPressureDelta")]
    ScalarPressureData MeanArterialCarbonDioxidePartialPressureDelta { get; set; }

    [JsonProperty("MeanCentralVenousPressure")]
    ScalarPressureData MeanCentralVenousPressure { get; set; }

    [JsonProperty("MeanSkinFlow")] ScalarVolumePerTimeData MeanSkinFlow { get; set; }

    [JsonProperty("PulmonaryArterialPressure")]
    ScalarPressureData PulmonaryArterialPressure { get; set; }

    [JsonProperty("PulmonaryCapillariesCoverageFraction")]
    Scalar0To1Data PulmonaryCapillariesCoverageFraction { get; set; }

    [JsonProperty("PulmonaryCapillariesWedgePressure")]
    ScalarPressureData PulmonaryCapillariesWedgePressure { get; set; }

    [JsonProperty("PulmonaryDiastolicArterialPressure")]
    ScalarPressureData PulmonaryDiastolicArterialPressure { get; set; }

    [JsonProperty("PulmonaryMeanArterialPressure")]
    ScalarPressureData PulmonaryMeanArterialPressure { get; set; }

    [JsonProperty("PulmonaryMeanCapillaryFlow")]
    ScalarVolumePerTimeData PulmonaryMeanCapillaryFlow { get; set; }

    [JsonProperty("PulmonaryMeanShuntFlow")]
    ScalarVolumePerTimeData PulmonaryMeanShuntFlow { get; set; }

    [JsonProperty("PulmonarySystolicArterialPressure")]
    ScalarPressureData PulmonarySystolicArterialPressure { get; set; }

    [JsonProperty("PulmonaryVascularResistance")]
    ScalarPressureTimePerVolumeData PulmonaryVascularResistance { get; set; }

    [JsonProperty("PulmonaryVascularResistanceIndex")]
    ScalarPressureTimePerVolumeAreaData PulmonaryVascularResistanceIndex { get; set; }

    [JsonProperty("PulsePressure")] ScalarPressureData PulsePressure { get; set; }

    [JsonProperty("SystemicVascularResistance")]
    ScalarPressureTimePerVolumeData SystemicVascularResistance { get; set; }

    [JsonProperty("SystolicArterialPressure")]
    ScalarPressureData SystolicArterialPressure { get; set; }

    [JsonProperty("SystolicLeftHeartPressure")]
    ScalarPressureData SystolicLeftHeartPressure { get; set; }

    [JsonProperty("SystolicRightHeartPressure")]
    ScalarPressureData SystolicRightHeartPressure { get; set; }

    [JsonProperty("TotalHemorrhageRate")] ScalarVolumePerTimeData TotalHemorrhageRate { get; set; }

    [JsonProperty("TotalHemorrhagedVolume")]
    ScalarVolumeData TotalHemorrhagedVolume { get; set; }

    [JsonProperty("TotalPulmonaryPerfusion")]
    ScalarVolumePerTimeData TotalPulmonaryPerfusion { get; set; }
}

public class DrugSystemData
{
    [JsonProperty("BronchodilationLevel")] ScalarNegative1To1Data BronchodilationLevel { get; set; }
    [JsonProperty("HeartRateChange")] ScalarFrequencyData HeartRateChange { get; set; }

    [JsonProperty("MeanBloodPressureChange")]
    ScalarPressureData MeanBloodPressureChange { get; set; }

    [JsonProperty("NeuromuscularBlockLevel")]
    Scalar0To1Data NeuromuscularBlockLevel { get; set; }

    [JsonProperty("PulsePressureChange")] ScalarPressureData PulsePressureChange { get; set; }
    [JsonProperty("PupillaryResponse")] PupillaryResponseData PupillaryResponse { get; set; }

    [JsonProperty("RespirationRateChange")]
    ScalarFrequencyData RespirationRateChange { get; set; }

    [JsonProperty("SedationLevel")] Scalar0To1Data SedationLevel { get; set; }
    [JsonProperty("TidalVolumeChange")] ScalarVolumeData TidalVolumeChange { get; set; }

    [JsonProperty("TubularPermeabilityChange")]
    ScalarNegative1To1Data TubularPermeabilityChange { get; set; }
}

public class EndocrineSystemData
{
    [JsonProperty("InsulinSynthesisRate")] ScalarAmountPerTimeData InsulinSynthesisRate { get; set; }
}

public class EnergySystemData
{
    [JsonProperty("AchievedExerciseLevel")]
    Scalar0To1Data AchievedExerciseLevel { get; set; }

    [JsonProperty("CoreTemperature")] private ScalarTemperatureData CoreTemperature { get; set; }

    [JsonProperty("CreatinineProductionRate")]
    ScalarAmountPerTimeData CreatinineProductionRate { get; set; }

    [JsonProperty("ExerciseMeanArterialPressureDelta")]
    ScalarPressureData ExerciseMeanArterialPressureDelta { get; set; }

    [JsonProperty("FatigueLevel")] Scalar0To1Data FatigueLevel { get; set; }
    [JsonProperty("KetoneProductionRate")] ScalarAmountPerTimeData KetoneProductionRate { get; set; }

    [JsonProperty("LactateProductionRate")]
    ScalarAmountPerTimeData LactateProductionRate { get; set; }

    [JsonProperty("SkinTemperature")] ScalarTemperatureData SkinTemperature { get; set; }
    [JsonProperty("SweatRate")] ScalarMassPerTimeData SweatRate { get; set; }
    [JsonProperty("TotalMetabolicRate")] ScalarPowerData TotalMetabolicRate { get; set; }
    [JsonProperty("TotalWorkRateLevel")] Scalar0To1Data TotalWorkRateLevel { get; set; }
}

public class GastrointestinalSystemData
{
    [JsonProperty("WaterAbsorptionRate")] ScalarVolumePerTimeData WaterAbsorptionRate { get; set; }
    [JsonProperty("StomachContents")] NutritionData StomachContents { get; set; }
}

public class HepaticSystemData
{
}

public class NervousSystemData
{
    [JsonProperty("ChemoreceptorFeedback")]
    eSwitch ChemoreceptorFeedback { get; set; }

    [JsonProperty("ChemoreceptorHeartRateScale")]
    ScalarData ChemoreceptorHeartRateScale { get; set; }

    [JsonProperty("ChemoreceptorHeartElastanceScale")]
    ScalarData ChemoreceptorHeartElastanceScale { get; set; }

    [JsonProperty("BaroreceptorFeedback")] eSwitch BaroreceptorFeedback { get; set; }

    [JsonProperty("BaroreceptorHeartRateScale")]
    ScalarData BaroreceptorHeartRateScale { get; set; }

    [JsonProperty("BaroreceptorHeartElastanceScale")]
    ScalarData BaroreceptorHeartElastanceScale { get; set; }

    [JsonProperty("BaroreceptorResistanceScale")]
    ScalarData BaroreceptorResistanceScale { get; set; }

    [JsonProperty("BaroreceptorComplianceScale")]
    ScalarData BaroreceptorComplianceScale { get; set; }

    [JsonProperty("LeftEyePupillaryResponse")]
    PupillaryResponseData LeftEyePupillaryResponse { get; set; }

    [JsonProperty("RightEyePupillaryResponse")]
    PupillaryResponseData RightEyePupillaryResponse { get; set; }
}

public class RenalSystemData
{
    [JsonProperty("FiltrationFraction")] Scalar0To1Data FiltrationFraction { get; set; }

    [JsonProperty("GlomerularFiltrationRate")]
    ScalarVolumePerTimeData GlomerularFiltrationRate { get; set; }

    [JsonProperty("LeftAfferentArterioleResistance")]
    ScalarPressureTimePerVolumeData LeftAfferentArterioleResistance { get; set; }

    [JsonProperty("LeftBowmansCapsulesHydrostaticPressure")]
    ScalarPressureData LeftBowmansCapsulesHydrostaticPressure { get; set; }

    [JsonProperty("LeftBowmansCapsulesOsmoticPressure")]
    ScalarPressureData LeftBowmansCapsulesOsmoticPressure { get; set; }

    [JsonProperty("LeftEfferentArterioleResistance")]
    ScalarPressureTimePerVolumeData LeftEfferentArterioleResistance { get; set; }

    [JsonProperty("LeftGlomerularCapillariesHydrostaticPressure")]
    ScalarPressureData LeftGlomerularCapillariesHydrostaticPressure { get; set; }

    [JsonProperty("LeftGlomerularCapillariesOsmoticPressure")]
    ScalarPressureData LeftGlomerularCapillariesOsmoticPressure { get; set; }

    [JsonProperty("LeftGlomerularFiltrationCoefficient")]
    ScalarVolumePerTimePressureData LeftGlomerularFiltrationCoefficient { get; set; }

    [JsonProperty("LeftGlomerularFiltrationRate")]
    ScalarVolumePerTimeData LeftGlomerularFiltrationRate { get; set; }

    [JsonProperty("LeftGlomerularFiltrationSurfaceArea")]
    ScalarAreaData LeftGlomerularFiltrationSurfaceArea { get; set; }

    [JsonProperty("LeftGlomerularFluidPermeability")]
    ScalarVolumePerTimePressureAreaData LeftGlomerularFluidPermeability { get; set; }

    [JsonProperty("LeftFiltrationFraction")]
    Scalar0To1Data LeftFiltrationFraction { get; set; }

    [JsonProperty("LeftNetFiltrationPressure")]
    ScalarPressureData LeftNetFiltrationPressure { get; set; }

    [JsonProperty("LeftNetReabsorptionPressure")]
    ScalarPressureData LeftNetReabsorptionPressure { get; set; }

    [JsonProperty("LeftPeritubularCapillariesHydrostaticPressure")]
    ScalarPressureData LeftPeritubularCapillariesHydrostaticPressure { get; set; }

    [JsonProperty("LeftPeritubularCapillariesOsmoticPressure")]
    ScalarPressureData LeftPeritubularCapillariesOsmoticPressure { get; set; }

    [JsonProperty("LeftReabsorptionFiltrationCoefficient")]
    ScalarVolumePerTimePressureData LeftReabsorptionFiltrationCoefficient { get; set; }

    [JsonProperty("LeftReabsorptionRate")] ScalarVolumePerTimeData LeftReabsorptionRate { get; set; }

    [JsonProperty("LeftTubularOsmoticPressure")]
    ScalarPressureData LeftTubularOsmoticPressure { get; set; }

    [JsonProperty("LeftTubularHydrostaticPressure")]
    ScalarPressureData LeftTubularHydrostaticPressure { get; set; }

    [JsonProperty("LeftTubularReabsorptionFiltrationSurfaceArea")]
    ScalarAreaData LeftTubularReabsorptionFiltrationSurfaceArea { get; set; }

    [JsonProperty("LeftTubularReabsorptionFluidPermeability")]
    ScalarVolumePerTimePressureAreaData LeftTubularReabsorptionFluidPermeability { get; set; }

    [JsonProperty("RenalBloodFlow")] ScalarVolumePerTimeData RenalBloodFlow { get; set; }
    [JsonProperty("RenalPlasmaFlow")] ScalarVolumePerTimeData RenalPlasmaFlow { get; set; }

    [JsonProperty("RenalVascularResistance")]
    ScalarPressureTimePerVolumeData RenalVascularResistance { get; set; }

    [JsonProperty("RightAfferentArterioleResistance")]
    ScalarPressureTimePerVolumeData RightAfferentArterioleResistance { get; set; }

    [JsonProperty("RightBowmansCapsulesHydrostaticPressure")]
    ScalarPressureData RightBowmansCapsulesHydrostaticPressure { get; set; }

    [JsonProperty("RightBowmansCapsulesOsmoticPressure")]
    ScalarPressureData RightBowmansCapsulesOsmoticPressure { get; set; }

    [JsonProperty("RightEfferentArterioleResistance")]
    ScalarPressureTimePerVolumeData RightEfferentArterioleResistance { get; set; }

    [JsonProperty("RightGlomerularCapillariesHydrostaticPressure")]
    ScalarPressureData RightGlomerularCapillariesHydrostaticPressure { get; set; }

    [JsonProperty("RightGlomerularCapillariesOsmoticPressure")]
    ScalarPressureData RightGlomerularCapillariesOsmoticPressure { get; set; }

    [JsonProperty("RightGlomerularFiltrationCoefficient")]
    ScalarVolumePerTimePressureData RightGlomerularFiltrationCoefficient { get; set; }

    [JsonProperty("RightGlomerularFiltrationRate")]
    ScalarVolumePerTimeData RightGlomerularFiltrationRate { get; set; }

    [JsonProperty("RightGlomerularFiltrationSurfaceArea")]
    ScalarAreaData RightGlomerularFiltrationSurfaceArea { get; set; }

    [JsonProperty("RightGlomerularFluidPermeability")]
    ScalarVolumePerTimePressureAreaData RightGlomerularFluidPermeability { get; set; }

    [JsonProperty("RightFiltrationFraction")]
    Scalar0To1Data RightFiltrationFraction { get; set; }

    [JsonProperty("RightNetFiltrationPressure")]
    ScalarPressureData RightNetFiltrationPressure { get; set; }

    [JsonProperty("RightNetReabsorptionPressure")]
    ScalarPressureData RightNetReabsorptionPressure { get; set; }

    [JsonProperty("RightPeritubularCapillariesHydrostaticPressure")]
    ScalarPressureData RightPeritubularCapillariesHydrostaticPressure { get; set; }

    [JsonProperty("RightPeritubularCapillariesOsmoticPressure")]
    ScalarPressureData RightPeritubularCapillariesOsmoticPressure { get; set; }

    [JsonProperty("RightReabsorptionFiltrationCoefficient")]
    ScalarVolumePerTimePressureData RightReabsorptionFiltrationCoefficient { get; set; }

    [JsonProperty("RightReabsorptionRate")]
    ScalarVolumePerTimeData RightReabsorptionRate { get; set; }

    [JsonProperty("RightTubularOsmoticPressure")]
    ScalarPressureData RightTubularOsmoticPressure { get; set; }

    [JsonProperty("RightTubularHydrostaticPressure")]
    ScalarPressureData RightTubularHydrostaticPressure { get; set; }

    [JsonProperty("RightTubularReabsorptionFiltrationSurfaceArea")]
    ScalarAreaData RightTubularReabsorptionFiltrationSurfaceArea { get; set; }

    [JsonProperty("RightTubularReabsorptionFluidPermeability")]
    ScalarVolumePerTimePressureAreaData RightTubularReabsorptionFluidPermeability { get; set; }

    [JsonProperty("UrinationRate")] ScalarVolumePerTimeData UrinationRate { get; set; }
    [JsonProperty("UrineOsmolality")] ScalarOsmolalityData UrineOsmolality { get; set; }
    [JsonProperty("UrineOsmolarity")] ScalarOsmolarityData UrineOsmolarity { get; set; }
    [JsonProperty("UrineProductionRate")] ScalarVolumePerTimeData UrineProductionRate { get; set; }
    [JsonProperty("UrineSpecificGravity")] ScalarData UrineSpecificGravity { get; set; }
    [JsonProperty("UrineVolume")] ScalarVolumeData UrineVolume { get; set; }

    [JsonProperty("UrineUreaNitrogenConcentration")]
    ScalarMassPerVolumeData UrineUreaNitrogenConcentration { get; set; }
}

public class RespiratoryMechanicsData
{
    [JsonProperty("Active")] eSwitch Active { get; set; }
    [JsonProperty("DefaultType")] eDefaultType DefaultType { get; set; }
    [JsonProperty("LeftComplianceCurve")] CurveData LeftComplianceCurve { get; set; }
    [JsonProperty("RightComplianceCurve")] CurveData RightComplianceCurve { get; set; }

    [JsonProperty("LeftExpiratoryResistance")]
    ScalarPressureTimePerVolumeData LeftExpiratoryResistance { get; set; }

    [JsonProperty("LeftInspiratoryResistance")]
    ScalarPressureTimePerVolumeData LeftInspiratoryResistance { get; set; }

    [JsonProperty("RightExpiratoryResistance")]
    ScalarPressureTimePerVolumeData RightExpiratoryResistance { get; set; }

    [JsonProperty("RightInspiratoryResistance")]
    ScalarPressureTimePerVolumeData RightInspiratoryResistance { get; set; }

    [JsonProperty("UpperExpiratoryResistance")]
    ScalarPressureTimePerVolumeData UpperExpiratoryResistance { get; set; }

    [JsonProperty("UpperInspiratoryResistance")]
    ScalarPressureTimePerVolumeData UpperInspiratoryResistance { get; set; }

    // Muscle Pressure Driver
    [JsonProperty("InspiratoryPeakPressure")]
    ScalarPressureData InspiratoryPeakPressure { get; set; }

    [JsonProperty("ExpiratoryPeakPressure")]
    ScalarPressureData ExpiratoryPeakPressure { get; set; }

    [JsonProperty("InspiratoryRiseTime")] ScalarTimeData InspiratoryRiseTime { get; set; }
    [JsonProperty("InspiratoryHoldTime")] ScalarTimeData InspiratoryHoldTime { get; set; }

    [JsonProperty("InspiratoryReleaseTime")]
    ScalarTimeData InspiratoryReleaseTime { get; set; }

    [JsonProperty("InspiratoryToExpiratoryPauseTime")]
    ScalarTimeData InspiratoryToExpiratoryPauseTime { get; set; }

    [JsonProperty("ExpiratoryRiseTime")] ScalarTimeData ExpiratoryRiseTime { get; set; }
    [JsonProperty("ExpiratoryHoldTime")] ScalarTimeData ExpiratoryHoldTime { get; set; }

    [JsonProperty("ExpiratoryReleaseTime")]
    ScalarTimeData ExpiratoryReleaseTime { get; set; }

    [JsonProperty("ResidueTime")] ScalarTimeData ResidueTime { get; set; }
}

public class RespiratorySystemData
{
    [JsonProperty("AirwayPressure")] ScalarPressureData AirwayPressure { get; set; }

    [JsonProperty("AlveolarArterialGradient")]
    ScalarPressureData AlveolarArterialGradient { get; set; }

    [JsonProperty("AlveolarDeadSpace")] ScalarVolumeData AlveolarDeadSpace { get; set; }
    [JsonProperty("AnatomicDeadSpace")] ScalarVolumeData AnatomicDeadSpace { get; set; }
    [JsonProperty("ChestWallCompliance")] ScalarVolumePerPressureData ChestWallCompliance { get; set; }

    [JsonProperty("ElasticWorkOfBreathing")]
    ScalarEnergyData ElasticWorkOfBreathing { get; set; }

    [JsonProperty("EndTidalCarbonDioxideFraction")]
    Scalar0To1Data EndTidalCarbonDioxideFraction { get; set; }

    [JsonProperty("EndTidalCarbonDioxidePressure")]
    ScalarPressureData EndTidalCarbonDioxidePressure { get; set; }

    [JsonProperty("EndTidalOxygenFraction")]
    Scalar0To1Data EndTidalOxygenFraction { get; set; }

    [JsonProperty("EndTidalOxygenPressure")]
    ScalarPressureData EndTidalOxygenPressure { get; set; }

    [JsonProperty("ExpiratoryFlow")] ScalarVolumePerTimeData ExpiratoryFlow { get; set; }

    [JsonProperty("ExpiratoryPulmonaryResistance")]
    ScalarPressureTimePerVolumeData ExpiratoryPulmonaryResistance { get; set; }

    [JsonProperty("ExpiratoryTidalVolume")]
    ScalarVolumeData ExpiratoryTidalVolume { get; set; }

    [JsonProperty("FractionOfInspiredOxygen")]
    Scalar0To1Data FractionOfInspiredOxygen { get; set; }

    [JsonProperty("HorowitzIndex")] ScalarPressureData HorowitzIndex { get; set; }

    [JsonProperty("ImposedPowerOfBreathing")]
    ScalarPowerData ImposedPowerOfBreathing { get; set; }

    [JsonProperty("ImposedWorkOfBreathing")]
    ScalarEnergyData ImposedWorkOfBreathing { get; set; }

    [JsonProperty("InspiratoryExpiratoryRatio")]
    ScalarData InspiratoryExpiratoryRatio { get; set; }

    [JsonProperty("InspiratoryFlow")] ScalarVolumePerTimeData InspiratoryFlow { get; set; }

    [JsonProperty("InspiratoryPulmonaryResistance")]
    ScalarPressureTimePerVolumeData InspiratoryPulmonaryResistance { get; set; }

    [JsonProperty("InspiratoryTidalVolume")]
    ScalarVolumeData InspiratoryTidalVolume { get; set; }

    [JsonProperty("IntrapleuralPressure")] ScalarPressureData IntrapleuralPressure { get; set; }

    [JsonProperty("IntrapulmonaryPressure")]
    ScalarPressureData IntrapulmonaryPressure { get; set; }

    [JsonProperty("IntrinsicPositiveEndExpiredPressure")]
    ScalarPressureData IntrinsicPositiveEndExpiredPressure { get; set; }

    [JsonProperty("LungCompliance")] ScalarVolumePerPressureData LungCompliance { get; set; }

    [JsonProperty("MaximalInspiratoryPressure")]
    ScalarPressureData MaximalInspiratoryPressure { get; set; }

    [JsonProperty("MeanAirwayPressure")] ScalarPressureData MeanAirwayPressure { get; set; }
    [JsonProperty("OxygenationIndex")] ScalarData OxygenationIndex { get; set; }

    [JsonProperty("OxygenSaturationIndex")]
    ScalarPressureData OxygenSaturationIndex { get; set; }

    [JsonProperty("PatientPowerOfBreathing")]
    ScalarPowerData PatientPowerOfBreathing { get; set; }

    [JsonProperty("PatientWorkOfBreathing")]
    ScalarEnergyData PatientWorkOfBreathing { get; set; }

    [JsonProperty("PeakInspiratoryPressure")]
    ScalarPressureData PeakInspiratoryPressure { get; set; }

    [JsonProperty("PhysiologicDeadSpace")] ScalarVolumeData PhysiologicDeadSpace { get; set; }

    [JsonProperty("PhysiologicDeadSpaceTidalVolumeRatio")]
    ScalarData PhysiologicDeadSpaceTidalVolumeRatio { get; set; }

    [JsonProperty("PositiveEndExpiratoryPressure")]
    ScalarPressureData PositiveEndExpiratoryPressure { get; set; }

    [JsonProperty("PulmonaryCompliance")] ScalarVolumePerPressureData PulmonaryCompliance { get; set; }
    [JsonProperty("PulmonaryElastance")] ScalarPressurePerVolumeData PulmonaryElastance { get; set; }

    [JsonProperty("RelativeTotalLungVolume")]
    ScalarVolumeData RelativeTotalLungVolume { get; set; }

    [JsonProperty("ResistiveExpiratoryWorkOfBreathing")]
    ScalarEnergyData ResistiveExpiratoryWorkOfBreathing { get; set; }

    [JsonProperty("ResistiveInspiratoryWorkOfBreathing")]
    ScalarEnergyData ResistiveInspiratoryWorkOfBreathing { get; set; }

    [JsonProperty("RespirationRate")] ScalarFrequencyData RespirationRate { get; set; }

    [JsonProperty("RespiratoryMuscleFatigue")]
    Scalar0To1Data RespiratoryMuscleFatigue { get; set; }

    [JsonProperty("RespiratoryMusclePressure")]
    ScalarPressureData RespiratoryMusclePressure { get; set; }

    [JsonProperty("SaturationAndFractionOfInspiredOxygenRatio")]
    ScalarData SaturationAndFractionOfInspiredOxygenRatio { get; set; }

    [JsonProperty("SpecificVentilation")] ScalarData SpecificVentilation { get; set; }
    [JsonProperty("TidalVolume")] ScalarVolumeData TidalVolume { get; set; }

    [JsonProperty("TotalAlveolarVentilation")]
    ScalarVolumePerTimeData TotalAlveolarVentilation { get; set; }

    [JsonProperty("TotalDeadSpaceVentilation")]
    ScalarVolumePerTimeData TotalDeadSpaceVentilation { get; set; }

    [JsonProperty("TotalLungVolume")] ScalarVolumeData TotalLungVolume { get; set; }

    [JsonProperty("TotalPowerOfBreathing")]
    ScalarPowerData TotalPowerOfBreathing { get; set; }

    [JsonProperty("TotalPulmonaryVentilation")]
    ScalarVolumePerTimeData TotalPulmonaryVentilation { get; set; }

    [JsonProperty("TotalWorkOfBreathing")] ScalarEnergyData TotalWorkOfBreathing { get; set; }
    [JsonProperty("TransairwayPressure")] ScalarPressureData TransairwayPressure { get; set; }

    [JsonProperty("TransalveolarPressure")]
    ScalarPressureData TransalveolarPressure { get; set; }

    [JsonProperty("TransChestWallPressure")]
    ScalarPressureData TransChestWallPressure { get; set; }

    [JsonProperty("TransMusclePressure")] ScalarPressureData TransMusclePressure { get; set; }

    [JsonProperty("TranspulmonaryPressure")]
    ScalarPressureData TranspulmonaryPressure { get; set; }

    [JsonProperty("TransrespiratoryPressure")]
    ScalarPressureData TransrespiratoryPressure { get; set; }

    [JsonProperty("TransthoracicPressure")]
    ScalarPressureData TransthoracicPressure { get; set; }

    [JsonProperty("VentilationPerfusionRatio")]
    ScalarData VentilationPerfusionRatio { get; set; }

    [JsonProperty("RespiratoryMechanics")] RespiratoryMechanicsData RespiratoryMechanics { get; set; }
}

public class TissueSystemData
{
    [JsonProperty("CarbonDioxideProductionRate")]
    ScalarVolumePerTimeData CarbonDioxideProductionRate { get; set; }

    [JsonProperty("ExtracellularFluidVolume")]
    ScalarVolumeData ExtracellularFluidVolume { get; set; }

    [JsonProperty("ExtravascularFluidVolume")]
    ScalarVolumeData ExtravascularFluidVolume { get; set; }

    [JsonProperty("IntracellularFluidPH")] ScalarData IntracellularFluidPH { get; set; }

    [JsonProperty("IntracellularFluidVolume")]
    ScalarVolumeData IntracellularFluidVolume { get; set; }

    [JsonProperty("OxygenConsumptionRate")]
    ScalarVolumePerTimeData OxygenConsumptionRate { get; set; }

    [JsonProperty("RespiratoryExchangeRatio")]
    ScalarData RespiratoryExchangeRatio { get; set; }
}