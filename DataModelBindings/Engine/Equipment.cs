using Newtonsoft.Json;
using PulseNet.DataModelBindings.CDM;

namespace PulseNet.DataModelBindings.Engine;

public class AnesthesiaMachineData
{
    [JsonProperty("Common")] AnesthesiaMachineData Common { get; set; }
    [JsonProperty("Inhaling")] bool Inhaling { get; set; }

    [JsonProperty("CurrentBreathingCycleTime_s")]
    double CurrentBreathingCycleTime_s { get; set; }

    [JsonProperty("InspirationTime_s")] double InspirationTime_s { get; set; }

    [JsonProperty("OxygenInletVolumeFraction")]
    double OxygenInletVolumeFraction { get; set; }

    [JsonProperty("TotalBreathingCycleTime_s")]
    double TotalBreathingCycleTime_s { get; set; }
}

public class BagValveMaskData
{
    [JsonProperty("Common")] BagValveMaskData Common { get; set; }
    [JsonProperty("CurrentPeriodTime_s")] double CurrentPeriodTime_s { get; set; }
    [JsonProperty("SqueezeFlow_L_Per_s")] double SqueezeFlow_L_Per_s { get; set; }

    [JsonProperty("SqueezePressure_cmH2O")]
    double SqueezePressure_cmH2O { get; set; }
}

public class ECMOData
{
    [JsonProperty("Common")] ECMOData Common { get; set; }
}

public class ElectroCardioGramData
{
    [JsonProperty("Common")] ElectroCardioGramData Common { get; set; }
}

public class InhalerData
{
    [JsonProperty("Common")] InhalerData Common { get; set; }
}

public class MechanicalVentilatorData
{
    [JsonProperty("Common")] MechanicalVentilatorData Common { get; set; }

    [JsonProperty("CurrentInspiratoryVolume_L")]
    double CurrentInspiratoryVolume_L { get; set; }

    [JsonProperty("CurrentPeriodTime_s")] double CurrentPeriodTime_s { get; set; }

    [JsonProperty("CurrentRespiratoryVolume_L")]
    double CurrentRespiratoryVolume_L { get; set; }

    [JsonProperty("CurrentVentilatorVolume_L")]
    double CurrentVentilatorVolume_L { get; set; }

    [JsonProperty("DriverPressure_cmH2O")] double DriverPressure_cmH2O { get; set; }
    [JsonProperty("DriverFlow_L_Per_s")] double DriverFlow_L_Per_s { get; set; }

    [JsonProperty("EndTidalCarbonDioxideFraction")]
    double EndTidalCarbonDioxideFraction { get; set; }

    [JsonProperty("EndTidalCarbonDioxidePressure_cmH2O")]
    double EndTidalCarbonDioxidePressure_cmH2O { get; set; }

    [JsonProperty("EndTidalOxygenFraction")]
    double EndTidalOxygenFraction { get; set; }

    [JsonProperty("EndTidalOxygenPressure_cmH2O")]
    double EndTidalOxygenPressure_cmH2O { get; set; }

    [JsonProperty("Initializing")] bool Initializing { get; set; }
    [JsonProperty("InspirationTime_s")] double InspirationTime_s { get; set; }

    [JsonProperty("InspiratoryFlow_L_Per_s")]
    double InspiratoryFlow_L_Per_s { get; set; }

    [JsonProperty("LimitReached")] bool LimitReached { get; set; }

    [JsonProperty("MeanAirwayPressure_cmH2O")]
    RunningAverageData MeanAirwayPressure_cmH2O { get; set; }

    [JsonProperty("PreviousDriverFlow_L_Per_s")]
    double PreviousDriverFlow_L_Per_s { get; set; }

    [JsonProperty("PreviousConnectionPressure_cmH2O")]
    double PreviousConnectionPressure_cmH2O { get; set; }

    [JsonProperty("PreviousDriverPressure_cmH2O")]
    double PreviousDriverPressure_cmH2O { get; set; }

    [JsonProperty("PreviousYPieceToConnectionFlow_L_Per_s")]
    double PreviousYPieceToConnectionFlow_L_Per_s { get; set; }

    [JsonProperty("PositiveEndExpiratoryPressure_cmH2O")]
    double PositiveEndExpiratoryPressure_cmH2O { get; set; }
}