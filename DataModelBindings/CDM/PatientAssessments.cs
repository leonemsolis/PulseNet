using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public enum ePatientAssessmentType
{
    ArterialBloodGasTest = 0,
    CompleteBloodCount = 1,
    ComprehensiveMetabolicPanel = 2,
    Urinalysis = 3,
}

public class PatientAssessmentData
{
}

public class ArterialBloodGasTestData
{
    [JsonProperty("PatientAssessment")] PatientAssessmentData PatientAssessment { get; set; }
    [JsonProperty("BloodPH")] ScalarData BloodPH { get; set; }
    [JsonProperty("Bicarbonate")] ScalarEquivalentWeightPerVolumeData Bicarbonate { get; set; }

    [JsonProperty("PartialPressureOfOxygen")]
    ScalarPressureData PartialPressureOfOxygen { get; set; }

    [JsonProperty("PartialPressureOfCarbonDioxide")]
    ScalarPressureData PartialPressureOfCarbonDioxide { get; set; }

    [JsonProperty("OxygenSaturation")] ScalarData OxygenSaturation { get; set; }
}

public class CompleteBloodCountData
{
    [JsonProperty("PatientAssessment")] PatientAssessmentData PatientAssessment { get; set; }
    [JsonProperty("Hematocrit")] Scalar0To1Data Hematocrit { get; set; }
    [JsonProperty("Hemoglobin")] ScalarMassPerVolumeData Hemoglobin { get; set; }
    [JsonProperty("PlateletCount")] ScalarAmountPerVolumeData PlateletCount { get; set; }

    [JsonProperty("MeanCorpuscularHemoglobin")]
    ScalarMassPerAmountData MeanCorpuscularHemoglobin { get; set; }

    [JsonProperty("MeanCorpuscularHemoglobinConcentration")]
    ScalarMassPerVolumeData MeanCorpuscularHemoglobinConcentration { get; set; }

    [JsonProperty("MeanCorpuscularVolume")]
    ScalarVolumeData MeanCorpuscularVolume { get; set; }

    [JsonProperty("RedBloodCellCount")] ScalarAmountPerVolumeData RedBloodCellCount { get; set; }
    [JsonProperty("WhiteBloodCellCount")] ScalarAmountPerVolumeData WhiteBloodCellCount { get; set; }
}

public class ComprehensiveMetabolicPanelData
{
    [JsonProperty("PatientAssessment")] PatientAssessmentData PatientAssessment { get; set; }
    [JsonProperty("Albumin")] ScalarMassPerVolumeData Albumin { get; set; }
    [JsonProperty("ALP")] ScalarMassPerVolumeData ALP { get; set; }
    [JsonProperty("ALT")] ScalarMassPerVolumeData ALT { get; set; }
    [JsonProperty("AST")] ScalarMassPerVolumeData AST { get; set; }
    [JsonProperty("BUN")] ScalarMassPerVolumeData BUN { get; set; }
    [JsonProperty("Calcium")] ScalarMassPerVolumeData Calcium { get; set; }
    [JsonProperty("Chloride")] ScalarAmountPerVolumeData Chloride { get; set; }
    [JsonProperty("CO2")] ScalarAmountPerVolumeData CO2 { get; set; }
    [JsonProperty("Creatinine")] ScalarMassPerVolumeData Creatinine { get; set; }
    [JsonProperty("Glucose")] ScalarMassPerVolumeData Glucose { get; set; }
    [JsonProperty("Potassium")] ScalarAmountPerVolumeData Potassium { get; set; }
    [JsonProperty("Sodium")] ScalarAmountPerVolumeData Sodium { get; set; }
    [JsonProperty("TotalBilirubin")] ScalarMassPerVolumeData TotalBilirubin { get; set; }
    [JsonProperty("TotalProtein")] ScalarMassPerVolumeData TotalProtein { get; set; }
}

public class UrinalysisMicroscopicData
{
    public enum eObservationType
    {
        NullObservationType = 0,
        LowPowerField = 1,
        HighPowerField = 2
    }


    enum eObservationAmount
    {
        NullObservationAmount = 0,
        Few = 1,
        Moderate = 2,
        Many = 3
    }

    [JsonProperty("ObservationType")] eObservationType ObservationType { get; set; }
    [JsonProperty("RedBloodCells")] ScalarAmountData RedBloodCells { get; set; }
    [JsonProperty("WhiteBloodCells")] ScalarAmountData WhiteBloodCells { get; set; }
    [JsonProperty("EpithelialCells")] eObservationAmount EpithelialCells { get; set; }
    [JsonProperty("Casts")] ScalarAmountData Casts { get; set; }
    [JsonProperty("Crystals")] eObservationAmount Crystals { get; set; }
    [JsonProperty("Bacteria")] eObservationAmount Bacteria { get; set; }
    [JsonProperty("Trichomonads")] eObservationAmount Trichomonads { get; set; }
    [JsonProperty("Yeast")] eObservationAmount Yeast { get; set; }
}

public class UrinalysisData
{
    public enum ePresenceIndicator
    {
        NullPresence = 0,
        Positive = 1,
        Negative = 2,
    }

    public enum eClarityIndicator
    {
        NullClarity = 0,
        Translucent = 1,
        SlightlyCloudy = 2,
        Cloudy = 3,
        Turbid = 4,
    }

    public enum eUrineColor
    {
        NullColor = 0,
        PaleYellow = 1,
        Yellow = 2,
        DarkYellow = 3,
    }

    [JsonProperty("PatientAssessment")] PatientAssessmentData PatientAssessment { get; set; }
    [JsonProperty("Color")] eUrineColor Color { get; set; }
    [JsonProperty("Appearance")] eClarityIndicator Appearance { get; set; }
    [JsonProperty("Glucose")] ePresenceIndicator Glucose { get; set; }
    [JsonProperty("Ketone")] ePresenceIndicator Ketone { get; set; }
    [JsonProperty("Bilirubin")] ScalarData Bilirubin { get; set; }
    [JsonProperty("SpecificGravity")] ScalarData SpecificGravity { get; set; }
    [JsonProperty("Blood")] ePresenceIndicator Blood { get; set; }
    [JsonProperty("pH")] ScalarData pH { get; set; }
    [JsonProperty("Protein")] ePresenceIndicator Protein { get; set; }
    [JsonProperty("Urobilinogen")] ScalarMassPerVolumeData Urobilinogen { get; set; }
    [JsonProperty("Nitrite")] ePresenceIndicator Nitrite { get; set; }
    [JsonProperty("LeukocyteEsterase")] ePresenceIndicator LeukocyteEsterase { get; set; }

    [JsonProperty("Microscopic")] UrinalysisMicroscopicData Microscopic { get; set; }
}