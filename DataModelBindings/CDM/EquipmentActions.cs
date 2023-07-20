using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class AnyEquipmentActionData
{
    [JsonProperty("AnesthesiaMachineConfiguration")]
    AnesthesiaMachineConfigurationData AnesthesiaMachineConfiguration { get; set; }

    [JsonProperty("AnesthesiaMachineExpiratoryValveLeak")]
    AnesthesiaMachineExpiratoryValveLeakData AnesthesiaMachineExpiratoryValveLeak { get; set; }

    [JsonProperty("AnesthesiaMachineExpiratoryValveObstruction")]
    AnesthesiaMachineExpiratoryValveObstructionData AnesthesiaMachineExpiratoryValveObstruction { get; set; }

    [JsonProperty("AnesthesiaMachineInspiratoryValveLeak")]
    AnesthesiaMachineInspiratoryValveLeakData AnesthesiaMachineInspiratoryValveLeak { get; set; }

    [JsonProperty("AnesthesiaMachineInspiratoryValveObstruction")]
    AnesthesiaMachineInspiratoryValveObstructionData AnesthesiaMachineInspiratoryValveObstruction { get; set; }

    [JsonProperty("AnesthesiaMachineMaskLeak")]
    AnesthesiaMachineMaskLeakData AnesthesiaMachineMaskLeak { get; set; }

    [JsonProperty("AnesthesiaMachineSodaLimeFailure")]
    AnesthesiaMachineSodaLimeFailureData AnesthesiaMachineSodaLimeFailure { get; set; }

    [JsonProperty("AnesthesiaMachineTubeCuffLeak")]
    AnesthesiaMachineTubeCuffLeakData AnesthesiaMachineTubeCuffLeak { get; set; }

    [JsonProperty("AnesthesiaMachineVaporizerFailure")]
    AnesthesiaMachineVaporizerFailureData AnesthesiaMachineVaporizerFailure { get; set; }

    [JsonProperty("AnesthesiaMachineVentilatorPressureLoss")]
    AnesthesiaMachineVentilatorPressureLossData AnesthesiaMachineVentilatorPressureLoss { get; set; }

    [JsonProperty("AnesthesiaMachineYPieceDisconnect")]
    AnesthesiaMachineYPieceDisconnectData AnesthesiaMachineYPieceDisconnect { get; set; }

    [JsonProperty("AnesthesiaMachineOxygenWallPortPressureLoss")]
    AnesthesiaMachineOxygenWallPortPressureLossData AnesthesiaMachineOxygenWallPortPressureLoss { get; set; }

    [JsonProperty("AnesthesiaMachineOxygenTankPressureLoss")]
    AnesthesiaMachineOxygenTankPressureLossData AnesthesiaMachineOxygenTankPressureLoss { get; set; }

    [JsonProperty("BagValveMaskConfiguration")]
    BagValveMaskConfigurationData BagValveMaskConfiguration { get; set; }

    [JsonProperty("BagValveMaskAutomated")]
    BagValveMaskAutomatedData BagValveMaskAutomated { get; set; }

    [JsonProperty("BagValveMaskInstantaneous")]
    BagValveMaskInstantaneousData BagValveMaskInstantaneous { get; set; }

    [JsonProperty("BagValveMaskSqueeze")] BagValveMaskSqueezeData BagValveMaskSqueeze { get; set; }

    [JsonProperty("ECMOConfiguration")] ECMOConfigurationData ECMOConfiguration { get; set; }

    [JsonProperty("InhalerConfiguration")] InhalerConfigurationData InhalerConfiguration { get; set; }

    [JsonProperty("MechanicalVentilatorConfiguration")]
    MechanicalVentilatorConfigurationData MechanicalVentilatorConfiguration { get; set; }

    [JsonProperty("MechanicalVentilatorHold")]
    MechanicalVentilatorHoldData MechanicalVentilatorHold { get; set; }

    [JsonProperty("MechanicalVentilatorLeak")]
    MechanicalVentilatorLeakData MechanicalVentilatorLeak { get; set; }

    [JsonProperty("MechanicalVentilatorContinuousPositiveAirwayPressure")]
    MechanicalVentilatorContinuousPositiveAirwayPressureData MechanicalVentilatorContinuousPositiveAirwayPressure
    {
        get;
        set;
    }

    [JsonProperty("MechanicalVentilatorPressureControl")]
    MechanicalVentilatorPressureControlData MechanicalVentilatorPressureControl { get; set; }

    [JsonProperty("MechanicalVentilatorVolumeControl")]
    MechanicalVentilatorVolumeControlData MechanicalVentilatorVolumeControl { get; set; }
}