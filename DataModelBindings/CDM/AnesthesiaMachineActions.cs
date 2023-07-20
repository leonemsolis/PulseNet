using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class AnesthesiaMachineActionData
{
    [JsonProperty("EquipmentAction")] public EquipmentActionData EquipmentAction { get; set; }
}

public class AnesthesiaMachineConfigurationData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Option")] public OptionData Option { get; set; }

    [JsonProperty("MergeType")] public int MergeType { get; set; }
}

public class AnesthesiaMachineExpiratoryValveLeakData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineExpiratoryValveObstructionData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineInspiratoryValveLeakData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineInspiratoryValveObstructionData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineMaskLeakData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineSodaLimeFailureData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineTubeCuffLeakData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineVaporizerFailureData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineVentilatorPressureLossData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineYPieceDisconnectData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("Severity")] public Scalar0To1Data Severity { get; set; }
}

public class AnesthesiaMachineOxygenWallPortPressureLossData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("State")] public int State { get; set; }
}

public class AnesthesiaMachineOxygenTankPressureLossData
{
    [JsonProperty("AnesthesiaMachineAction")]
    public AnesthesiaMachineActionData AnesthesiaMachineAction { get; set; }

    [JsonProperty("State")] public int State { get; set; }
}

public class OptionData
{
    [JsonProperty("Configuration")] public AnesthesiaMachineData Configuration { get; set; }

    [JsonProperty("ConfigurationFile")] public string ConfigurationFile { get; set; }
}