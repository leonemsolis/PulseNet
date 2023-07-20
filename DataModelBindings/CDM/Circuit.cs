using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class CircuitData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Node")] List<string> Node { get; set; }
    [JsonProperty("Path")] List<string> Path { get; set; }
}

public class CircuitNodeData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("ReferenceNode")] bool ReferenceNode { get; set; }
}

public class CircuitPathData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("SourceNode")] string SourceNode { get; set; }
    [JsonProperty("TargetNode")] string TargetNode { get; set; }

    [JsonProperty("Switch")] eGate Switch { get; set; }
    [JsonProperty("NextSwitch")] eGate NextSwitch { get; set; }

    [JsonProperty("Valve")] eGate Valve { get; set; }
    [JsonProperty("NextValve")] eGate NextValve { get; set; }

    [JsonProperty("PolarizedState")] eGate PolarizedState { get; set; }
    [JsonProperty("NextPolarizedState")] eGate NextPolarizedState { get; set; }
}

public class ElectricalCircuitData
{
    [JsonProperty("Circuit")] CircuitData Circuit { get; set; }
}

public class ElectricalCircuitNodeData
{
    [JsonProperty("CircuitNode")] CircuitNodeData CircuitNode { get; set; }

    [JsonProperty("Voltage")] ScalarElectricPotentialData Voltage { get; set; }

    [JsonProperty("NextVoltage")] ScalarElectricPotentialData NextVoltage { get; set; }

    [JsonProperty("Charge")] ScalarElectricChargeData Charge { get; set; }
    [JsonProperty("NextCharge")] ScalarElectricChargeData NextCharge { get; set; }
    [JsonProperty("ChargeBaseline")] ScalarElectricChargeData ChargeBaseline { get; set; }
}

public class ElectricalCircuitPathData
{
    [JsonProperty("CircuitPath")] CircuitPathData CircuitPath { get; set; }

    [JsonProperty("Resistance")] ScalarElectricResistanceData Resistance { get; set; }
    [JsonProperty("NextResistance")] ScalarElectricResistanceData NextResistance { get; set; }

    [JsonProperty("ResistanceBaseline")] ScalarElectricResistanceData ResistanceBaseline { get; set; }

    [JsonProperty("Capacitance")] ScalarElectricCapacitanceData Capacitance { get; set; }
    [JsonProperty("NextCapacitance")] ScalarElectricCapacitanceData NextCapacitance { get; set; }

    [JsonProperty("CapacitanceBaseline")] ScalarElectricCapacitanceData CapacitanceBaseline { get; set; }

    [JsonProperty("Inductance")] ScalarElectricInductanceData Inductance { get; set; }
    [JsonProperty("NextInductance")] ScalarElectricInductanceData NextInductance { get; set; }

    [JsonProperty("InductanceBaseline")] ScalarElectricInductanceData InductanceBaseline { get; set; }

    [JsonProperty("Current")] ScalarElectricCurrentData Current { get; set; }
    [JsonProperty("NextCurrent")] ScalarElectricCurrentData NextCurrent { get; set; }
    [JsonProperty("CurrentSource")] ScalarElectricCurrentData CurrentSource { get; set; }
    [JsonProperty("NextCurrentSource")] ScalarElectricCurrentData NextCurrentSource { get; set; }

    [JsonProperty("CurrentSourceBaseline")]
    ScalarElectricCurrentData CurrentSourceBaseline { get; set; }

    [JsonProperty("VoltageSource")] ScalarElectricPotentialData VoltageSource { get; set; }
    [JsonProperty("NextVoltageSource")] ScalarElectricPotentialData NextVoltageSource { get; set; }

    [JsonProperty("VoltageSourceBaseline")]
    ScalarElectricPotentialData VoltageSourceBaseline { get; set; }

    [JsonProperty("ValveBreakdownVoltage")]
    ScalarElectricPotentialData ValveBreakdownVoltage { get; set; }
}

public class FluidCircuitData
{
    [JsonProperty("Circuit")] CircuitData Circuit { get; set; }
}

public class FluidCircuitNodeData
{
    [JsonProperty("CircuitNode")] CircuitNodeData CircuitNode { get; set; }

    [JsonProperty("Pressure")] ScalarPressureData Pressure { get; set; }

    [JsonProperty("NextPressure")] ScalarPressureData NextPressure { get; set; }

    [JsonProperty("Volume")] ScalarVolumeData Volume { get; set; }
    [JsonProperty("NextVolume")] ScalarVolumeData NextVolume { get; set; }
    [JsonProperty("VolumeBaseline")] ScalarVolumeData VolumeBaseline { get; set; }
}

public class FluidCircuitPathData
{
    [JsonProperty("CircuitPath")] CircuitPathData CircuitPath { get; set; }

    [JsonProperty("Resistance")] ScalarPressureTimePerVolumeData Resistance { get; set; }
    [JsonProperty("NextResistance")] ScalarPressureTimePerVolumeData NextResistance { get; set; }

    [JsonProperty("ResistanceBaseline")] ScalarPressureTimePerVolumeData ResistanceBaseline { get; set; }

    [JsonProperty("Compliance")] ScalarVolumePerPressureData Compliance { get; set; }
    [JsonProperty("NextCompliance")] ScalarVolumePerPressureData NextCompliance { get; set; }

    [JsonProperty("ComplianceBaseline")] ScalarVolumePerPressureData ComplianceBaseline { get; set; }

    [JsonProperty("Inertance")] ScalarPressureTimeSquaredPerVolumeData Inertance { get; set; }
    [JsonProperty("NextInertance")] ScalarPressureTimeSquaredPerVolumeData NextInertance { get; set; }

    [JsonProperty("InertanceBaseline")] ScalarPressureTimeSquaredPerVolumeData InertanceBaseline { get; set; }

    [JsonProperty("Flow")] ScalarVolumePerTimeData Flow { get; set; }
    [JsonProperty("NextFlow")] ScalarVolumePerTimeData NextFlow { get; set; }
    [JsonProperty("FlowSource")] ScalarVolumePerTimeData FlowSource { get; set; }
    [JsonProperty("NextFlowSource")] ScalarVolumePerTimeData NextFlowSource { get; set; }

    [JsonProperty("FlowSourceBaseline")] ScalarVolumePerTimeData FlowSourceBaseline { get; set; }

    [JsonProperty("PressureSource")] ScalarPressureData PressureSource { get; set; }
    [JsonProperty("NextPressureSource")] ScalarPressureData NextPressureSource { get; set; }

    [JsonProperty("PressureSourceBaseline")]
    ScalarPressureData PressureSourceBaseline { get; set; }

    [JsonProperty("ValveBreakdownPressure")]
    ScalarPressureData ValveBreakdownPressure { get; set; }
}

public class ThermalCircuitData
{
    [JsonProperty("Circuit")] CircuitData Circuit { get; set; }
}

public class ThermalCircuitNodeData
{
    [JsonProperty("CircuitNode")] CircuitNodeData CircuitNode { get; set; }

    [JsonProperty("Temperature")] ScalarTemperatureData Temperature { get; set; }

    [JsonProperty("NextTemperature")] ScalarTemperatureData NextTemperature { get; set; }

    [JsonProperty("Heat")] ScalarEnergyData Heat { get; set; }
    [JsonProperty("NextHeat")] ScalarEnergyData NextHeat { get; set; }
    [JsonProperty("HeatBaseline")] ScalarEnergyData HeatBaseline { get; set; }
}

public class ThermalCircuitPathData
{
    [JsonProperty("CircuitPath")] CircuitPathData CircuitPath { get; set; }

    [JsonProperty("Resistance")] ScalarHeatResistanceData Resistance { get; set; }
    [JsonProperty("NextResistance")] ScalarHeatResistanceData NextResistance { get; set; }

    [JsonProperty("ResistanceBaseline")] ScalarHeatResistanceData ResistanceBaseline { get; set; }

    [JsonProperty("Capacitance")] ScalarHeatCapacitanceData Capacitance { get; set; }
    [JsonProperty("NextCapacitance")] ScalarHeatCapacitanceData NextCapacitance { get; set; }

    [JsonProperty("CapacitanceBaseline")] ScalarHeatCapacitanceData CapacitanceBaseline { get; set; }

    [JsonProperty("Inductance")] ScalarHeatInductanceData Inductance { get; set; }
    [JsonProperty("NextInductance")] ScalarHeatInductanceData NextInductance { get; set; }

    [JsonProperty("InductanceBaseline")] ScalarHeatInductanceData InductanceBaseline { get; set; }

    [JsonProperty("HeatTransferRate")] ScalarPowerData HeatTransferRate { get; set; }
    [JsonProperty("NextHeatTransferRate")] ScalarPowerData NextHeatTransferRate { get; set; }
    [JsonProperty("HeatSource")] ScalarPowerData HeatSource { get; set; }
    [JsonProperty("NextHeatSource")] ScalarPowerData NextHeatSource { get; set; }

    [JsonProperty("HeatSourceBaseline")] ScalarPowerData HeatSourceBaseline { get; set; }

    [JsonProperty("TemperatureSource")] ScalarTemperatureData TemperatureSource { get; set; }

    [JsonProperty("NextTemperatureSource")]
    ScalarTemperatureData NextTemperatureSource { get; set; }

    [JsonProperty("TemperatureSourceBaseline")]
    ScalarTemperatureData TemperatureSourceBaseline { get; set; }

    [JsonProperty("ValveBreakdownTemperature")]
    ScalarTemperatureData ValveBreakdownTemperature { get; set; }
}

public class CircuitManagerData
{
    [JsonProperty("ElectricalNode")]
    List<ElectricalCircuitNodeData> ElectricalNode { get; set; }

    [JsonProperty("ElectricalPath")]
    List<ElectricalCircuitPathData> ElectricalPath { get; set; }

    [JsonProperty("ElectricalCircuit")]
    List<ElectricalCircuitData> ElectricalCircuit { get; set; }

    [JsonProperty("FluidNode")] List<FluidCircuitNodeData> FluidNode { get; set; }
    [JsonProperty("FluidPath")] List<FluidCircuitPathData> FluidPath { get; set; }
    [JsonProperty("FluidCircuit")] List<FluidCircuitData> FluidCircuit { get; set; }

    [JsonProperty("ThermalNode")]
    List<ThermalCircuitNodeData> ThermalNode { get; set; }

    [JsonProperty("ThermalPath")]
    List<ThermalCircuitPathData> ThermalPath { get; set; }

    [JsonProperty("ThermalCircuit")] List<ThermalCircuitData> ThermalCircuit { get; set; }
}