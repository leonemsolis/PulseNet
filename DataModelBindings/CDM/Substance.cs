using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class SubstanceAerosolizationData
{
    [JsonProperty("BronchioleModifier")] ScalarNegative1To1Data BronchioleModifier { get; set; }

    [JsonProperty("InflammationCoefficient")]
    Scalar0To1Data InflammationCoefficient { get; set; }

    [JsonProperty("ParticulateSizeDistribution")]
    HistogramFractionVsLengthData ParticulateSizeDistribution { get; set; }
}

public class SubstancePhysicochemicalsData
{
    public enum eIonicState
    {
        NullIonicState = 0,
        Acid = 1,
        Base = 2,
        Neutral = 3,
        WeakBase = 4
    }

    public enum eBindingProtein
    {
        NullBindingProtein = 0,
        AAG = 1,
        Albumin = 2,
        Lipoprotein = 3
    }

    [JsonProperty("AcidDissociationConstant")]
    ScalarData AcidDissociationConstant { get; set; }

    [JsonProperty("BindingProtein")] eBindingProtein BindingProtein { get; set; }
    [JsonProperty("BloodPlasmaRatio")] ScalarData BloodPlasmaRatio { get; set; }

    [JsonProperty("FractionUnboundInPlasma")]
    Scalar0To1Data FractionUnboundInPlasma { get; set; }

    [JsonProperty("IonicState")] eIonicState IonicState { get; set; }
    [JsonProperty("LogP")] ScalarData LogP { get; set; }

    [JsonProperty("OralAbsorptionRateConstant")]
    ScalarData OralAbsorptionRateConstant { get; set; }
}

public class SubstanceTissuePharmacokineticsData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("PartitionCoefficient")] ScalarData PartitionCoefficient { get; set; }
}

public class SubstancePharmacokineticsData
{
    [JsonProperty("Physicochemicals")] SubstancePhysicochemicalsData Physicochemicals { get; set; }

    [JsonProperty("SubstanceTissuePharmacokineticsData")]
    List<SubstanceTissuePharmacokineticsData> TissueKinetics { get; set; }
}

public class SubstancePharmacodynamicsData
{
    [JsonProperty("Bronchodilation")] ScalarNegative1To1Data Bronchodilation { get; set; }

    [JsonProperty("DiastolicPressureModifier")]
    ScalarNegative1To1Data DiastolicPressureModifier { get; set; }

    [JsonProperty("EC50")] ScalarMassPerVolumeData EC50 { get; set; }
    [JsonProperty("EMaxShapeParameter")] ScalarData EMaxShapeParameter { get; set; }
    [JsonProperty("HeartRateModifier")] ScalarNegative1To1Data HeartRateModifier { get; set; }
    [JsonProperty("NeuromuscularBlock")] ScalarNegative1To1Data NeuromuscularBlock { get; set; }
    [JsonProperty("PupillaryResponse")] PupillaryResponseData PupillaryResponse { get; set; }

    [JsonProperty("RespirationRateModifier")]
    ScalarNegative1To1Data RespirationRateModifier { get; set; }

    [JsonProperty("Sedation")] ScalarNegative1To1Data Sedation { get; set; }

    [JsonProperty("SystolicPressureModifier")]
    ScalarNegative1To1Data SystolicPressureModifier { get; set; }

    [JsonProperty("TidalVolumeModifier")] ScalarNegative1To1Data TidalVolumeModifier { get; set; }

    [JsonProperty("TubularPermeabilityModifier")]
    ScalarNegative1To1Data TubularPermeabilityModifier { get; set; }
}

public class SubstanceSystemicClearanceData
{
    [JsonProperty("FractionExcretedInFeces")]
    Scalar0To1Data FractionExcretedInFeces { get; set; }

    [JsonProperty("FractionExcretedInUrine")]
    Scalar0To1Data FractionExcretedInUrine { get; set; }

    [JsonProperty("FractionMetabolizedInGut")]
    Scalar0To1Data FractionMetabolizedInGut { get; set; }

    [JsonProperty("FractionUnboundInPlasma")]
    Scalar0To1Data FractionUnboundInPlasma { get; set; }

    [JsonProperty("IntrinsicClearance")] ScalarVolumePerTimeMassData IntrinsicClearance { get; set; }
    [JsonProperty("RenalClearance")] ScalarVolumePerTimeMassData RenalClearance { get; set; }
    [JsonProperty("SystemicClearance")] ScalarVolumePerTimeMassData SystemicClearance { get; set; }
}

public class SubstanceRenalRegulationData
{
    [JsonProperty("ChargeInBlood")] eCharge ChargeInBlood { get; set; }

    [JsonProperty("FractionUnboundInPlasma")]
    Scalar0To1Data FractionUnboundInPlasma { get; set; }

    [JsonProperty("ReabsorptionRatio")] ScalarData ReabsorptionRatio { get; set; }
    [JsonProperty("TransportMaximum")] ScalarMassPerTimeData TransportMaximum { get; set; }
}

public class SubstanceRenalClearanceData
{
    [JsonProperty("Clearance")] ScalarVolumePerTimeMassData Clearance { get; set; }
    [JsonProperty("Regulation")] SubstanceRenalRegulationData Regulation { get; set; }
    [JsonProperty("FiltrationRate")] ScalarMassPerTimeData FiltrationRate { get; set; }
    [JsonProperty("ReabsorptionRate")] ScalarMassPerTimeData ReabsorptionRate { get; set; }
    [JsonProperty("ExcretionRate")] ScalarMassPerTimeData ExcretionRate { get; set; }

    [JsonProperty("GlomerularFilterability")]
    ScalarData GlomerularFilterability { get; set; }
}

public class SubstanceClearanceData
{
    [JsonProperty("SystemicClearance")] SubstanceSystemicClearanceData SystemicClearance { get; set; }
    [JsonProperty("RenalClearance")] SubstanceRenalClearanceData RenalClearance { get; set; }
}

public class SubstanceFractionData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Amount")] Scalar0To1Data Amount { get; set; }
}

public class SubstanceConcentrationData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Concentration")] ScalarMassPerVolumeData Concentration { get; set; }
}

public class SubstanceData
{
    public enum eState
    {
        NullState = 0,
        Solid = 1,
        Liquid = 2,
        Gas = 3,
        Molecular = 4
    }

    [JsonProperty("Name")]
    string Name { get; set; }

    [JsonProperty("Density")] ScalarMassPerVolumeData Density { get; set; }
    [JsonProperty("MolarMass")] ScalarMassPerAmountData MolarMass { get; set; }
    [JsonProperty("Valence")] ScalarData Valence { get; set; }
    [JsonProperty("State")] eState State { get; set; }

    [JsonProperty("MaximumDiffusionFlux")]
    ScalarMassPerAreaTimeData MaximumDiffusionFlux { get; set; }

    [JsonProperty("MichaelisCoefficient")] ScalarData MichaelisCoefficient { get; set; }

    [JsonProperty("Aerosolization")]
    SubstanceAerosolizationData Aerosolization { get; set; }

    [JsonProperty("BloodConcentration")]
    ScalarMassPerVolumeData BloodConcentration { get; set; }

    [JsonProperty("MassInBody")] ScalarMassData MassInBody { get; set; }
    [JsonProperty("MassInBlood")] ScalarMassData MassInBlood { get; set; }
    [JsonProperty("MassInTissue")] ScalarMassData MassInTissue { get; set; }
    [JsonProperty("PlasmaConcentration")] ScalarMassPerVolumeData PlasmaConcentration { get; set; }
    [JsonProperty("SystemicMassCleared")] ScalarMassData SystemicMassCleared { get; set; }
    [JsonProperty("TissueConcentration")] ScalarMassPerVolumeData TissueConcentration { get; set; }

    [JsonProperty("AlveolarTransfer")]
    ScalarVolumePerTimeData AlveolarTransfer { get; set; }

    [JsonProperty("DiffusingCapacity")] ScalarVolumePerTimePressureData DiffusingCapacity { get; set; }
    [JsonProperty("EndTidalFraction")] Scalar0To1Data EndTidalFraction { get; set; }
    [JsonProperty("EndTidalPressure")] ScalarPressureData EndTidalPressure { get; set; }

    [JsonProperty("RelativeDiffusionCoefficient")]
    ScalarData RelativeDiffusionCoefficient { get; set; }

    [JsonProperty("SolubilityCoefficient")]
    ScalarInversePressureData SolubilityCoefficient { get; set; }

    [JsonProperty("Clearance")]
    SubstanceClearanceData Clearance { get; set; }

    [JsonProperty("Pharmacokinetics")] SubstancePharmacokineticsData Pharmacokinetics { get; set; }
    [JsonProperty("Pharmacodynamics")] SubstancePharmacodynamicsData Pharmacodynamics { get; set; }
}

public class SubstanceCompoundData
{
    [JsonProperty("Name")] string Name { get; set; }

    [JsonProperty("SubstanceConcentrationData")]
    List<SubstanceConcentrationData> Component { get; set; }
}