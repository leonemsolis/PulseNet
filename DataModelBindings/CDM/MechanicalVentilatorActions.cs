using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class MechanicalVentilatorActionData
{
    [JsonProperty("EquipmentAction")] EquipmentActionData EquipmentAction { get; set; }
}

/** @brief The configuration of the mechanical ventilator to use. */
public class MechanicalVentilatorConfigurationData
{
    [JsonProperty("MechanicalVentilatorAction")]
    MechanicalVentilatorActionData MechanicalVentilatorAction { get; set; }

    [JsonProperty("Settings")] MechanicalVentilatorSettingsData Settings { get; set; }
    [JsonProperty("SettingsFile")] string SettingsFile { get; set; }
    [JsonProperty("MergeType")] eMergeType MergeType { get; set; }
}

public class MechanicalVentilatorHoldData
{
    [JsonProperty("MechanicalVentilatorAction")]
    MechanicalVentilatorActionData MechanicalVentilatorAction { get; set; }

    [JsonProperty("State")] eSwitch State { get; set; }

    [JsonProperty("AppliedRespiratoryCycle")]
    eAppliedRespiratoryCycle AppliedRespiratoryCycle { get; set; }
}

public class MechanicalVentilatorLeakData
{
    [JsonProperty("MechanicalVentilatorAction")]
    MechanicalVentilatorActionData MechanicalVentilatorAction { get; set; }

    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

public class MechanicalVentilatorModeData
{
    [JsonProperty("MechanicalVentilatorAction")]
    MechanicalVentilatorActionData MechanicalVentilatorAction { get; set; }

    [JsonProperty("Connection")] eSwitch Connection { get; set; }
}

public class MechanicalVentilatorContinuousPositiveAirwayPressureData
{
    [JsonProperty("MechanicalVentilatorMode")]
    MechanicalVentilatorModeData MechanicalVentilatorMode { get; set; }

    [JsonProperty("DeltaPressureSupport")] ScalarPressureData DeltaPressureSupport { get; set; }

    /** If no expiration cycle is provided we will start expiration based on the respiratory model. */
    [JsonProperty("ExpirationCycleFlow")]
    ScalarVolumePerTimeData ExpirationCycleFlow { get; set; }

    [JsonProperty("ExpirationCyclePressure")]
    ScalarPressureData ExpirationCyclePressure { get; set; }

    [JsonProperty("ExpirationWaveform")] eDriverWaveform ExpirationWaveform { get; set; }

    [JsonProperty("FractionInspiredOxygen")]
    Scalar0To1Data FractionInspiredOxygen { get; set; }

    /** If no patient trigger is provided we will trigger based on the respiratory model. */
    [JsonProperty("InspirationPatientTriggerFlow")]
    ScalarVolumePerTimeData InspirationPatientTriggerFlow { get; set; }

    [JsonProperty("InspirationPatientTriggerPressure")]
    ScalarPressureData InspirationPatientTriggerPressure { get; set; }

    [JsonProperty("InspirationWaveform")] eDriverWaveform InspirationWaveform { get; set; }

    [JsonProperty("PositiveEndExpiredPressure")]
    ScalarPressureData PositiveEndExpiredPressure { get; set; }

    [JsonProperty("Slope")] ScalarTimeData Slope { get; set; }
}

public class MechanicalVentilatorPressureControlData
{
    public enum eMode
    {
        AssistedControl = 0,
        ContinuousMandatoryVentilation = 1
    }

    [JsonProperty("MechanicalVentilatorMode")]
    MechanicalVentilatorModeData MechanicalVentilatorMode { get; set; }

    [JsonProperty("Mode")] eMode Mode { get; set; }

    [JsonProperty("FractionInspiredOxygen")]
    Scalar0To1Data FractionInspiredOxygen { get; set; }

    /** If no patient trigger is provided we will trigger based on the respiratory model. */
    [JsonProperty("InspirationPatientTriggerFlow")]
    ScalarVolumePerTimeData InspirationPatientTriggerFlow { get; set; }

    [JsonProperty("InspirationPatientTriggerPressure")]
    ScalarPressureData InspirationPatientTriggerPressure { get; set; }

    [JsonProperty("InspirationWaveform")] eDriverWaveform InspirationWaveform { get; set; }
    [JsonProperty("InspiratoryPeriod")] ScalarTimeData InspiratoryPeriod { get; set; }
    [JsonProperty("InspiratoryPressure")] ScalarPressureData InspiratoryPressure { get; set; }

    [JsonProperty("PositiveEndExpiredPressure")]
    ScalarPressureData PositiveEndExpiredPressure { get; set; }

    [JsonProperty("RespirationRate")] ScalarFrequencyData RespirationRate { get; set; }
    [JsonProperty("Slope")] ScalarTimeData Slope { get; set; }
}

public class MechanicalVentilatorVolumeControlData
{
    public enum eMode
    {
        AssistedControl = 0,
        ContinuousMandatoryVentilation = 1
    }

    [JsonProperty("MechanicalVentilatorMode")]
    MechanicalVentilatorModeData MechanicalVentilatorMode { get; set; }

    [JsonProperty("Mode")] eMode Mode { get; set; }
    [JsonProperty("Flow")] ScalarVolumePerTimeData Flow { get; set; }

    [JsonProperty("FractionInspiredOxygen")]
    Scalar0To1Data FractionInspiredOxygen { get; set; }

    /** If no patient trigger is provided we will trigger based on the respiratory model. */
    [JsonProperty("InspirationPatientTriggerFlow")]
    ScalarVolumePerTimeData InspirationPatientTriggerFlow { get; set; }

    [JsonProperty("InspirationPatientTriggerPressure")]
    ScalarPressureData InspirationPatientTriggerPressure { get; set; }

    [JsonProperty("InspirationWaveform")] eDriverWaveform InspirationWaveform { get; set; }
    [JsonProperty("InspiratoryPeriod")] ScalarTimeData InspiratoryPeriod { get; set; }

    [JsonProperty("PositiveEndExpiredPressure")]
    ScalarPressureData PositiveEndExpiredPressure { get; set; }

    [JsonProperty("RespirationRate")] ScalarFrequencyData RespirationRate { get; set; }
    [JsonProperty("Slope")] ScalarTimeData Slope { get; set; }
    [JsonProperty("TidalVolume")] ScalarVolumeData TidalVolume { get; set; }
}