using System.Collections.Generic;
using Newtonsoft.Json;
using PulseNet.DataModelBindings.CDM;

namespace PulseNet.DataModelBindings.CDM;

public class AnyPatientActionData
{
    [JsonProperty("Assessment")] PatientAssessmentRequestData Assessment { get; set; }

    [JsonProperty("AcuteRespiratoryDistressSyndromeExacerbation")]
    AcuteRespiratoryDistressSyndromeExacerbationData AcuteRespiratoryDistressSyndromeExacerbation { get; set; }

    [JsonProperty("AcuteStress")] AcuteStressData AcuteStress { get; set; }
    [JsonProperty("AirwayObstruction")] AirwayObstructionData AirwayObstruction { get; set; }
    [JsonProperty("Arrhythmia")] ArrhythmiaData Arrhythmia { get; set; }
    [JsonProperty("AsthmaAttack")] AsthmaAttackData AsthmaAttack { get; set; }
    [JsonProperty("BrainInjury")] BrainInjuryData BrainInjury { get; set; }
    [JsonProperty("Bronchoconstriction")] BronchoconstrictionData Bronchoconstriction { get; set; }
    [JsonProperty("ChestCompression")] ChestCompressionData ChestCompression { get; set; }

    [JsonProperty("ChestCompressionAutomated")]
    ChestCompressionAutomatedData ChestCompressionAutomated { get; set; }

    [JsonProperty("ChestCompressionInstantaneous")]
    ChestCompressionInstantaneousData ChestCompressionInstantaneous { get; set; }

    [JsonProperty("ChestOcclusiveDressing")]
    ChestOcclusiveDressingData ChestOcclusiveDressing { get; set; }

    [JsonProperty("ChronicObstructivePulmonaryDiseaseExacerbation")]
    ChronicObstructivePulmonaryDiseaseExacerbationData ChronicObstructivePulmonaryDiseaseExacerbation { get; set; }

    [JsonProperty("ConsciousRespiration")] ConsciousRespirationData ConsciousRespiration { get; set; }
    [JsonProperty("ConsumeNutrients")] ConsumeNutrientsData ConsumeNutrients { get; set; }
    [JsonProperty("Dyspnea")] DyspneaData Dyspnea { get; set; }
    [JsonProperty("Exercise")] ExerciseData Exercise { get; set; }
    [JsonProperty("Hemorrhage")] HemorrhageData Hemorrhage { get; set; }
    [JsonProperty("Hemothorax")] HemothoraxData Hemothorax { get; set; }

    [JsonProperty("ImpairedAlveolarExchangeExacerbation")]
    ImpairedAlveolarExchangeExacerbationData ImpairedAlveolarExchangeExacerbation { get; set; }

    [JsonProperty("Intubation")] IntubationData Intubation { get; set; }

    [JsonProperty("LobarPneumoniaExacerbation")]
    LobarPneumoniaExacerbationData LobarPneumoniaExacerbation { get; set; }

    [JsonProperty("MechanicalVentilation")]
    MechanicalVentilationData MechanicalVentilation { get; set; }

    [JsonProperty("NeedleDecompression")] NeedleDecompressionData NeedleDecompression { get; set; }
    [JsonProperty("PericardialEffusion")] PericardialEffusionData PericardialEffusion { get; set; }

    [JsonProperty("PulmonaryShuntExacerbation")]
    PulmonaryShuntExacerbationData PulmonaryShuntExacerbation { get; set; }

    [JsonProperty("RespiratoryFatigue")] RespiratoryFatigueData RespiratoryFatigue { get; set; }

    [JsonProperty("RespiratoryMechanicsConfiguration")]
    RespiratoryMechanicsConfigurationData RespiratoryMechanicsConfiguration { get; set; }

    [JsonProperty("SubstanceBolus")] SubstanceBolusData SubstanceBolus { get; set; }

    [JsonProperty("SubstanceCompoundInfusion")]
    SubstanceCompoundInfusionData SubstanceCompoundInfusion { get; set; }

    [JsonProperty("SubstanceInfusion")] SubstanceInfusionData SubstanceInfusion { get; set; }
    [JsonProperty("SupplementalOxygen")] SupplementalOxygenData SupplementalOxygen { get; set; }
    [JsonProperty("TensionPneumothorax")] TensionPneumothoraxData TensionPneumothorax { get; set; }
    [JsonProperty("TubeThoracostomy")] TubeThoracostomyData TubeThoracostomy { get; set; }
    [JsonProperty("Urinate")] UrinateData Urinate { get; set; }
}

public class PatientActionData
{
    [JsonProperty("Action")] ActionData Action { get; set; }
}

public class PatientAssessmentRequestData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Type")] ePatientAssessmentType Type { get; set; }
}

public class AcuteRespiratoryDistressSyndromeExacerbationData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
    [JsonProperty("LeftLungAffected")] Scalar0To1Data LeftLungAffected { get; set; }
    [JsonProperty("RightLungAffected")] Scalar0To1Data RightLungAffected { get; set; }
}

public class AcuteStressData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class AirwayObstructionData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class ArrhythmiaData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Rhythm")] eHeartRhythm Rhythm { get; set; }
}

public class AsthmaAttackData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class BrainInjuryData
{
    public enum eType
    {
        Diffuse = 0,
        LeftFocal = 1,
        RightFocal = 2,
    }

    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Type")] eType Type { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class BronchoconstrictionData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class ChestCompressionData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }

    [JsonProperty("Force")] ScalarForceData Force { get; set; }
    [JsonProperty("Depth")] ScalarLengthData Depth { get; set; }

    [JsonProperty("CompressionPeriod")] ScalarTimeData CompressionPeriod { get; set; }
}

public class ChestCompressionAutomatedData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }

    [JsonProperty("Force")] ScalarForceData Force { get; set; }
    [JsonProperty("Depth")] ScalarLengthData Depth { get; set; }

    [JsonProperty("CompressionFrequency")] ScalarFrequencyData CompressionFrequency { get; set; }
    [JsonProperty("AppliedForceFraction")] Scalar0To1Data AppliedForceFraction { get; set; }
}

public class ChestCompressionInstantaneousData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }

    [JsonProperty("Force")] ScalarForceData Force { get; set; }
    [JsonProperty("Depth")] ScalarLengthData Depth { get; set; }
}

public class ChestOcclusiveDressingData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("State")] eSwitch State { get; set; }
    [JsonProperty("Side")] eSide Side { get; set; }
}

public class ChronicObstructivePulmonaryDiseaseExacerbationData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("BronchitisSeverity")] Scalar0To1Data BronchitisSeverity { get; set; }
    [JsonProperty("EmphysemaSeverity")] Scalar0To1Data EmphysemaSeverity { get; set; }
}

public class DyspneaData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class ForcedInhaleData
{
    [JsonProperty("InspiratoryCapacityFraction")]
    Scalar0To1Data InspiratoryCapacityFraction { get; set; }

    [JsonProperty("InhalePeriod")] ScalarTimeData InhalePeriod { get; set; }
    [JsonProperty("HoldPeriod")] ScalarTimeData HoldPeriod { get; set; }
    [JsonProperty("ReleasePeriod")] ScalarTimeData ReleasePeriod { get; set; }
}

public class ForcedExhaleData
{
    [JsonProperty("ExpiratoryReserveVolumeFraction")]
    Scalar0To1Data ExpiratoryReserveVolumeFraction { get; set; }

    [JsonProperty("ExhalePeriod")] ScalarTimeData ExhalePeriod { get; set; }
    [JsonProperty("HoldPeriod")] ScalarTimeData HoldPeriod { get; set; }
    [JsonProperty("ReleasePeriod")] ScalarTimeData ReleasePeriod { get; set; }
}

public class ForcedPauseData
{
    [JsonProperty("Period")] ScalarTimeData Period { get; set; }
}

public class UseInhalerData
{
}

public class AnyConsciousRespirationCommandData
{
    [JsonProperty("Comment")] string Comment { get; set; }
    [JsonProperty("ForcedInhale")] ForcedInhaleData ForcedInhale { get; set; }
    [JsonProperty("ForcedExhale")] ForcedExhaleData ForcedExhale { get; set; }
    [JsonProperty("ForcedPause")] ForcedPauseData ForcedPause { get; set; }
    [JsonProperty("UseInhaler")] UseInhalerData UseInhaler { get; set; }
}

public class ConsciousRespirationData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("StartImmediately")] bool StartImmediately { get; set; }
    [JsonProperty("Command")] List<AnyConsciousRespirationCommandData> Command { get; set; }
}

public class ConsumeNutrientsData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Nutrition")] NutritionData Nutrition { get; set; }
    [JsonProperty("NutritionFile")] string NutritionFile { get; set; }
}

public class ExerciseData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Intensity")] Scalar0To1Data Intensity { get; set; }
}

public class HemorrhageData
{
    public enum eCompartment
    {
        None = 0,
        Aorta = 1,
        Brain = 2,
        Muscle = 3,
        LargeIntestine = 4,
        LeftArm = 5,
        LeftKidney = 6,
        LeftLeg = 7,
        Liver = 8,
        RightArm = 9,
        RightKidney = 10,
        RightLeg = 11,
        Skin = 12,
        SmallIntestine = 13,
        Splanchnic = 14,
        Spleen = 15,
        VenaCava = 16
    }

    public enum eType
    {
        External = 0,
        Internal = 1
    }

    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }

    [JsonProperty("Compartment")] eCompartment Compartment { get; set; }

    [JsonProperty("Type")] CompartmentData.eType Type { get; set; }

    [JsonProperty("FlowRate")] ScalarVolumePerTimeData FlowRate { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
    [JsonProperty("TotalBloodLost")] ScalarVolumeData TotalBloodLost { get; set; }
}

public class HemothoraxData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }

    [JsonProperty("Side")] eSide Side { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
    [JsonProperty("FlowRate")] ScalarVolumePerTimeData FlowRate { get; set; }
    [JsonProperty("TotalBloodVolume")] ScalarVolumeData TotalBloodVolume { get; set; }
}

public class ImpairedAlveolarExchangeExacerbationData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("ImpairedSurfaceArea")] ScalarAreaData ImpairedSurfaceArea { get; set; }
    [JsonProperty("ImpairedFraction")] Scalar0To1Data ImpairedFraction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class IntubationData
{
    public enum eType
    {
        Off = 0,
        Esophageal = 1,
        LeftMainstem = 2,
        RightMainstem = 3,
        Tracheal = 4,
        Oropharyngeal = 5,
        Nasopharyngeal = 6,
    }

    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Type")] CompartmentData.eType Type { get; set; }
    [JsonProperty("AirwayResistance")] ScalarPressureTimePerVolumeData AirwayResistance { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class LobarPneumoniaExacerbationData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
    [JsonProperty("LeftLungAffected")] Scalar0To1Data LeftLungAffected { get; set; }
    [JsonProperty("RightLungAffected")] Scalar0To1Data RightLungAffected { get; set; }
}

public class MechanicalVentilationData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("State")] eSwitch State { get; set; }
    [JsonProperty("Flow")] ScalarVolumePerTimeData Flow { get; set; }
    [JsonProperty("Pressure")] ScalarPressureData Pressure { get; set; }
    [JsonProperty("GasFraction")] List<SubstanceFractionData> GasFraction { get; set; }
    [JsonProperty("Aerosol")] List<SubstanceConcentrationData> Aerosol { get; set; }
}

public class NeedleDecompressionData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("State")] eSwitch State { get; set; }
    [JsonProperty("Side")] eSide Side { get; set; }
}

public class PericardialEffusionData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("EffusionRate")] ScalarVolumePerTimeData EffusionRate { get; set; }
}

public class PulmonaryShuntExacerbationData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class RespiratoryFatigueData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class RespiratoryMechanicsConfigurationData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Settings")] RespiratoryMechanicsData Settings { get; set; }
    [JsonProperty("SettingsFile")] string SettingsFile { get; set; }
    [JsonProperty("AppliedCycle")] eAppliedRespiratoryCycle AppliedCycle { get; set; }
    [JsonProperty("MergeType")] eMergeType MergeType { get; set; }
}

public class SubstanceBolusData
{
    public enum eRoute
    {
        Intravenous = 0,
        Epidural = 1,
        Intraosseous = 2,
        Intraarterial = 3,
        Intracardiac = 4,
        Intracerebral = 5,
        Intracerebroventricular = 6,
        Intradermal = 7,
        Intramuscular = 8,
        Subcutaneous = 9,
    }

    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Substance")] string Substance { get; set; }
    [JsonProperty("AdministrationRoute")] eRoute AdministrationRoute { get; set; }

    [JsonProperty("AdministrationDuration")]
    ScalarTimeData AdministrationDuration { get; set; }

    [JsonProperty("Concentration")] ScalarMassPerVolumeData Concentration { get; set; }
    [JsonProperty("Dose")] ScalarVolumeData Dose { get; set; }
    [JsonProperty("TotalInfusedDose")] ScalarVolumeData TotalInfusedDose { get; set; }
}

public class SubstanceCompoundInfusionData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("SubstanceCompound")] string SubstanceCompound { get; set; }
    [JsonProperty("BagVolume")] ScalarVolumeData BagVolume { get; set; }
    [JsonProperty("Rate")] ScalarVolumePerTimeData Rate { get; set; }
}

public class SubstanceInfusionData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Substance")] string Substance { get; set; }
    [JsonProperty("Concentration")] ScalarMassPerVolumeData Concentration { get; set; }
    [JsonProperty("Rate")] ScalarVolumePerTimeData Rate { get; set; }
    [JsonProperty("Volume")] ScalarVolumeData Volume { get; set; }
}

public class SupplementalOxygenData
{
    public enum eDevice
    {
        None = 0,
        NasalCannula = 1,
        SimpleMask = 2,
        NonRebreatherMask = 3,
    }

    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Device")] eDevice Device { get; set; }
    [JsonProperty("Flow")] ScalarVolumePerTimeData Flow { get; set; }
    [JsonProperty("Volume")] ScalarVolumeData Volume { get; set; }
}

public class TensionPneumothoraxData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Type")] eGate Type { get; set; }
    [JsonProperty("Side")] eSide Side { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class TubeThoracostomyData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
    [JsonProperty("Side")] eSide Side { get; set; }
    [JsonProperty("FlowRate")] ScalarVolumePerTimeData FlowRate { get; set; }
}

public class UrinateData
{
    [JsonProperty("PatientAction")] PatientActionData PatientAction { get; set; }
}