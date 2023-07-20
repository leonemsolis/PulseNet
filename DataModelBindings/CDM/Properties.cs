using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

// Curve/Segments Data
public class SegmentConstantData
{
    [JsonProperty("BeginVolume")] public ScalarVolumeData BeginVolume { get; set; }

    [JsonProperty("EndVolume")] public ScalarVolumeData EndVolume { get; set; }

    [JsonProperty("Compliance")] public ScalarVolumePerPressureData Compliance { get; set; }
}

public class SegmentLinearData
{
    [JsonProperty("BeginVolume")] public ScalarVolumeData BeginVolume { get; set; }

    [JsonProperty("EndVolume")] public ScalarVolumeData EndVolume { get; set; }

    [JsonProperty("Slope")] public ScalarPressurePerVolumeData Slope { get; set; }

    [JsonProperty("YIntercept")] public ScalarPressureData YIntercept { get; set; }
}

public class SegmentParabolicData
{
    [JsonProperty("BeginVolume")] public ScalarVolumeData BeginVolume { get; set; }

    [JsonProperty("EndVolume")] public ScalarVolumeData EndVolume { get; set; }

    [JsonProperty("Coefficient1")] public ScalarData Coefficient1 { get; set; }

    [JsonProperty("Coefficient2")] public ScalarData Coefficient2 { get; set; }

    [JsonProperty("Coefficient3")] public ScalarData Coefficient3 { get; set; }

    [JsonProperty("Coefficient4")] public ScalarData Coefficient4 { get; set; }
}

public class SegmentSigmoidalData
{
    [JsonProperty("BeginVolume")] public ScalarVolumeData BeginVolume { get; set; }

    [JsonProperty("EndVolume")] public ScalarVolumeData EndVolume { get; set; }

    [JsonProperty("LowerCorner")] public ScalarPressureData LowerCorner { get; set; }

    [JsonProperty("UpperCorner")] public ScalarPressureData UpperCorner { get; set; }

    [JsonProperty("BaselineCompliance")] public ScalarVolumePerPressureData BaselineCompliance { get; set; }
}

public class AnySegmentData
{
    [JsonProperty("ConstantSegment", NullValueHandling = NullValueHandling.Ignore)]
    public SegmentConstantData ConstantSegment { get; set; }

    [JsonProperty("LinearSegment", NullValueHandling = NullValueHandling.Ignore)]
    public SegmentLinearData LinearSegment { get; set; }

    [JsonProperty("ParabolicSegment", NullValueHandling = NullValueHandling.Ignore)]
    public SegmentParabolicData ParabolicSegment { get; set; }

    [JsonProperty("SigmoidalSegment", NullValueHandling = NullValueHandling.Ignore)]
    public SegmentSigmoidalData SigmoidalSegment { get; set; }
}

public class CurveData
{
    [JsonProperty("Segment")] public List<AnySegmentData> Segment { get; set; }
}

// Average Data
public class RunningAverageData
{
    [JsonProperty("Sum")] public double Sum { get; set; }

    [JsonProperty("NumSamples")] public uint NumSamples { get; set; }
}

public class TemporalInterpolatorData
{
    [JsonProperty("Complete")] public bool Complete { get; set; }

    [JsonProperty("PositiveTransition")] public bool PositiveTransition { get; set; }

    [JsonProperty("Period_s")] public double Period_s { get; set; }

    [JsonProperty("Current")] public double Current { get; set; }

    [JsonProperty("Target")] public double Target { get; set; }

    [JsonProperty("Initial")] public double Initial { get; set; }
}

// Scalar Data
public class ScalarData
{
    [JsonProperty(nameof(Value))] public double Value { get; set; }

    [JsonProperty("Unit")] public string Unit { get; set; }

    [JsonProperty("ReadOnly")] public bool ReadOnly { get; set; }
}

// Various Scalar Types
public class Scalar0To1Data
{
    [JsonProperty("Scalar0To1")] public ScalarData Scalar0To1 { get; set; }
}

public class ScalarNegative1To1Data
{
    [JsonProperty("ScalarNegative1To1")] public ScalarData ScalarNegative1To1 { get; set; }
}

public class ScalarAmountData
{
    [JsonProperty("ScalarAmount")] public ScalarData ScalarAmount { get; set; }
}

public class ScalarAmountPerMassData
{
    [JsonProperty("ScalarAmountPerMass")] public ScalarData ScalarAmountPerMass { get; set; }
}

public class ScalarAmountPerTimeData
{
    [JsonProperty("ScalarAmountPerTime")] public ScalarData ScalarAmountPerTime { get; set; }
}

public class ScalarAmountPerVolumeData
{
    [JsonProperty("ScalarAmountPerVolume")]
    public ScalarData ScalarAmountPerVolume { get; set; }
}

public class ScalarAreaData
{
    [JsonProperty("ScalarArea")] public ScalarData ScalarArea { get; set; }
}

public class ScalarAreaPerTimePressureData
{
    [JsonProperty("ScalarAreaPerTimePressure")]
    public ScalarData ScalarAreaPerTimePressure { get; set; }
}

public class ScalarElectricCapacitanceData
{
    [JsonProperty("ScalarElectricCapacitance")]
    public ScalarData ScalarElectricCapacitance { get; set; }
}

public class ScalarElectricChargeData
{
    [JsonProperty("ScalarElectricCharge")] public ScalarData ScalarElectricCharge { get; set; }
}

public class ScalarElectricCurrentData
{
    [JsonProperty("ScalarElectricCurrent")]
    public ScalarData ScalarElectricCurrent { get; set; }
}

public class ScalarElectricPotentialData
{
    [JsonProperty("ScalarElectricPotential")]
    public ScalarData ScalarElectricPotential { get; set; }
}

public class ScalarElectricInductanceData
{
    [JsonProperty("ScalarElectricInductance")]
    public ScalarData ScalarElectricInductance { get; set; }
}

public class ScalarElectricResistanceData
{
    [JsonProperty("ScalarElectricResistance")]
    public ScalarData ScalarElectricResistance { get; set; }
}

public class ScalarEnergyData
{
    [JsonProperty("ScalarEnergy")] public ScalarData ScalarEnergy { get; set; }
}

public class ScalarEnergyPerAmountData
{
    [JsonProperty("ScalarEnergyPerAmount")]
    public ScalarData ScalarEnergyPerAmount { get; set; }
}

public class ScalarEnergyPerMassData
{
    [JsonProperty("ScalarEnergyPerMass")] public ScalarData ScalarEnergyPerMass { get; set; }
}

public class ScalarEquivalentWeightPerVolumeData
{
    [JsonProperty("ScalarEquivalentWeightPerVolume")]
    public ScalarData ScalarEquivalentWeightPerVolume { get; set; }
}

public class ScalarForceData
{
    [JsonProperty("ScalarForce")] public ScalarData ScalarForce { get; set; }
}

public class ScalarFrequencyData
{
    [JsonProperty("ScalarFrequency")] public ScalarData ScalarFrequency { get; set; }
}

public class ScalarHeatCapacitanceData
{
    [JsonProperty("ScalarHeatCapacitance")]
    public ScalarData ScalarHeatCapacitance { get; set; }
}

public class ScalarHeatCapacitancePerAmountData
{
    [JsonProperty("ScalarHeatCapacitancePerAmount")]
    public ScalarData ScalarHeatCapacitancePerAmount { get; set; }
}

public class ScalarHeatCapacitancePerMassData
{
    [JsonProperty("ScalarHeatCapacitancePerMass")]
    public ScalarData ScalarHeatCapacitancePerMass { get; set; }
}

public class ScalarHeatConductanceData
{
    [JsonProperty("ScalarHeatConductance")]
    public ScalarData ScalarHeatConductance { get; set; }
}

public class ScalarHeatConductancePerAreaData
{
    [JsonProperty("ScalarHeatConductancePerArea")]
    public ScalarData ScalarHeatConductancePerArea { get; set; }
}

public class ScalarHeatInductanceData
{
    [JsonProperty("ScalarHeatInductance")] public ScalarData ScalarHeatInductance { get; set; }
}

public class ScalarHeatResistanceData
{
    [JsonProperty("ScalarHeatResistance")] public ScalarData ScalarHeatResistance { get; set; }
}

public class ScalarHeatResistanceAreaData
{
    [JsonProperty("ScalarHeatResistanceArea")]
    public ScalarData ScalarHeatResistanceArea { get; set; }
}

public class ScalarInversePressureData
{
    [JsonProperty("ScalarInversePressure")]
    public ScalarData ScalarInversePressure { get; set; }
}

public class ScalarInverseVolumeData
{
    [JsonProperty("ScalarInverseVolume")] public ScalarData ScalarInverseVolume { get; set; }
}

public class ScalarLengthData
{
    [JsonProperty("ScalarLength")] public ScalarData ScalarLength { get; set; }
}

public class ScalarLengthPerTimeData
{
    [JsonProperty("ScalarLengthPerTime")] public ScalarData ScalarLengthPerTime { get; set; }
}

public class ScalarLengthPerTimePressureData
{
    [JsonProperty("ScalarLengthPerTimePressure")]
    public ScalarData ScalarLengthPerTimePressure { get; set; }
}

public class ScalarLengthPerTimeAreaData
{
    [JsonProperty("ScalarLengthPerTimeArea")]
    public ScalarData ScalarLengthPerTimeArea { get; set; }
}

public class ScalarMassData
{
    [JsonProperty("ScalarMass")] public ScalarData ScalarMass { get; set; }
}

public class ScalarMassPerAmountData
{
    [JsonProperty("ScalarMassPerAmount")] public ScalarData ScalarMassPerAmount { get; set; }
}

public class ScalarMassPerAreaTimeData
{
    [JsonProperty("ScalarMassPerAreaTime")]
    public ScalarData ScalarMassPerAreaTime { get; set; }
}

public class ScalarMassPerMassData
{
    [JsonProperty("ScalarMassPerMass")] public ScalarData ScalarMassPerMass { get; set; }
}

public class ScalarMassPerTimeData
{
    [JsonProperty("ScalarMassPerTime")] public ScalarData ScalarMassPerTime { get; set; }
}

public class ScalarMassPerVolumeData
{
    [JsonProperty("ScalarMassPerVolume")] public ScalarData ScalarMassPerVolume { get; set; }
}

public class ScalarOsmolalityData
{
    [JsonProperty("ScalarOsmolality")] public ScalarData ScalarOsmolality { get; set; }
}

public class ScalarOsmolarityData
{
    [JsonProperty("ScalarOsmolarity")] public ScalarData ScalarOsmolarity { get; set; }
}

public class ScalarPowerData
{
    [JsonProperty("ScalarPower")] public ScalarData ScalarPower { get; set; }
}

public class ScalarPowerPerAreaTemperatureToTheFourthData
{
    [JsonProperty("ScalarPowerPerAreaTemperatureToTheFourth")]
    public ScalarData ScalarPowerPerAreaTemperatureToTheFourth { get; set; }
}

public class ScalarPressureData
{
    [JsonProperty("ScalarPressure")] public ScalarData ScalarPressure { get; set; }
}

public class ScalarPressurePerVolumeData
{
    [JsonProperty("ScalarPressurePerVolume")]
    public ScalarData ScalarPressurePerVolume { get; set; }
}

public class ScalarPressureTimePerVolumeAreaData
{
    [JsonProperty("ScalarPressureTimePerVolumeArea")]
    public ScalarData ScalarPressureTimePerVolumeArea { get; set; }
}

public class ScalarPressureTimePerAreaData
{
    [JsonProperty("ScalarPressureTimePerArea")]
    public ScalarData ScalarPressureTimePerArea { get; set; }
}

public class ScalarPressureTimePerVolumeData
{
    [JsonProperty("ScalarPressureTimePerVolume")]
    public ScalarData ScalarPressureTimePerVolume { get; set; }
}

public class ScalarPressureTimeSquaredPerVolumeData
{
    [JsonProperty("ScalarPressureTimeSquaredPerVolume")]
    public ScalarData ScalarPressureTimeSquaredPerVolume { get; set; }
}

public class ScalarTimeData
{
    [JsonProperty("ScalarTime")] public ScalarData ScalarTime { get; set; }
}

public class ScalarTemperatureData
{
    [JsonProperty("ScalarTemperature")] public ScalarData ScalarTemperature { get; set; }
}

public class ScalarVolumeData
{
    [JsonProperty("ScalarVolume")] public ScalarData ScalarVolume { get; set; }
}

public class ScalarVolumePerTimeData
{
    [JsonProperty("ScalarVolumePerTime")] public ScalarData ScalarVolumePerTime { get; set; }
}

public class ScalarVolumePerPressureData
{
    [JsonProperty("ScalarVolumePerPressure")]
    public ScalarData ScalarVolumePerPressure { get; set; }
}

public class ScalarVolumePerTimeAreaData
{
    [JsonProperty("ScalarVolumePerTimeArea")]
    public ScalarData ScalarVolumePerTimeArea { get; set; }
}

public class ScalarVolumePerTimeMassData
{
    [JsonProperty("ScalarVolumePerTimeMass")]
    public ScalarData ScalarVolumePerTimeMass { get; set; }
}

public class ScalarVolumePerTimePressureData
{
    [JsonProperty("ScalarVolumePerTimePressure")]
    public ScalarData ScalarVolumePerTimePressure { get; set; }
}

public class ScalarVolumePerTimePressureAreaData
{
    [JsonProperty("ScalarVolumePerTimePressureArea")]
    public ScalarData ScalarVolumePerTimePressureArea { get; set; }
}

// Array Data
public class DoubleArrayData
{
    [JsonProperty("Value")] public List<double> Value { get; set; }
}

public class IntegerArrayData
{
    [JsonProperty("Value")] public List<int> Value { get; set; }
}

public class ArrayData
{
    [JsonProperty("Value")] public DoubleArrayData Value { get; set; }

    [JsonProperty("Unit")] public string Unit { get; set; }
}

public class ArrayElectricPotentialData
{
    [JsonProperty("ArrayElectricPotential")]
    public ArrayData ArrayElectricPotential { get; set; }
}

public class ArrayTimeData
{
    [JsonProperty("ArrayTime")] public ArrayData ArrayTime { get; set; }
}

public class FunctionData
{
    [JsonProperty("Dependent")] public DoubleArrayData Dependent { get; set; }

    [JsonProperty("Independent")] public DoubleArrayData Independent { get; set; }

    [JsonProperty("DependentUnit")] public string DependentUnit { get; set; }

    [JsonProperty("IndependentUnit")] public string IndependentUnit { get; set; }
}

public class FunctionVolumeVsTimeData
{
    [JsonProperty("FunctionVolumeVsTime")] public FunctionData FunctionVolumeVsTime { get; set; }
}

public class FunctionElectricPotentialVsTimeData
{
    [JsonProperty("FunctionElectricPotentialVsTime")]
    public FunctionData FunctionElectricPotentialVsTime { get; set; }
}

public class HistogramData
{
    [JsonProperty("Histogram")] public FunctionData Histogram { get; set; }
}

public class HistogramFractionVsLengthData
{
    [JsonProperty("HistogramFractionVsLength")]
    public HistogramData HistogramFractionVsLength { get; set; }
}