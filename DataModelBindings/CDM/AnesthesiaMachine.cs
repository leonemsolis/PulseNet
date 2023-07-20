using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class AnesthesiaMachineChamberData
{
    [JsonProperty("State")] public eSwitch State { get; set; }
    [JsonProperty("SubstanceFraction")] public Scalar0To1Data SubstanceFraction { get; set; }
    [JsonProperty("Substance")] public string Substance { get; set; }
}

public class AnesthesiaMachineOxygenBottleData
{
    [JsonProperty("Volume")] public ScalarVolumeData Volume { get; set; }
}

public class AnesthesiaMachineData
{
    public enum eOxygenSource
    {
        NullSource = 0,
        NoSource = 1,
        Wall = 2,
        BottleOne = 3,
        BottleTwo = 4
    }

    public enum ePrimaryGas
    {
        NullGas = 0,
        NoGas = 1,
        Air = 2,
        Nitrogen = 3
    }

    [JsonProperty("Connection")] public eSwitch Connection { get; set; }
    [JsonProperty("InletFlow")] public ScalarVolumePerTimeData InletFlow { get; set; }
    [JsonProperty("InspiratoryExpiratoryRatio")] public ScalarData InspiratoryExpiratoryRatio { get; set; }
    [JsonProperty("OxygenFraction")] public Scalar0To1Data OxygenFraction { get; set; }
    [JsonProperty("OxygenSource")] public eOxygenSource OxygenSource { get; set; }
    [JsonProperty("PeakInspiratoryPressure")] public ScalarPressureData PeakInspiratoryPressure { get; set; }
    [JsonProperty("PositiveEndExpiredPressure")] public ScalarPressureData PositiveEndExpiredPressure { get; set; }
    [JsonProperty("PrimaryGas")] public ePrimaryGas PrimaryGas { get; set; }
    [JsonProperty("ReliefValvePressure")] public ScalarPressureData ReliefValvePressure { get; set; }
    [JsonProperty("RespiratoryRate")] public ScalarFrequencyData RespiratoryRate { get; set; }
    [JsonProperty("LeftChamber")] public AnesthesiaMachineChamberData LeftChamber { get; set; }
    [JsonProperty("RightChamber")] public AnesthesiaMachineChamberData RightChamber { get; set; }
    [JsonProperty("OxygenBottleOne")] public AnesthesiaMachineOxygenBottleData OxygenBottleOne { get; set; }
    [JsonProperty("OxygenBottleTwo")] public AnesthesiaMachineOxygenBottleData OxygenBottleTwo { get; set; }
}