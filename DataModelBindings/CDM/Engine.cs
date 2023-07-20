using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class DecimalFormatData
{
    public enum eType
    {
        SystemFormatting = 0,
        DefaultFloat = 1,
        FixedMantissa = 2,
        SignificantDigits = 3
    }

    [JsonProperty("Type")] eType Type { get; set; }
    [JsonProperty("Precision")] uint Precision { get; set; }
}

public class DataRequestData
{
    public enum eCategory
    {
        Patient = 0,
        Physiology = 1,
        Environment = 2,
        Action = 3,
        GasCompartment = 4,
        LiquidCompartment = 5,
        ThermalCompartment = 6,
        TissueCompartment = 7,
        Substance = 8,
        AnesthesiaMachine = 9,
        BagValveMask = 10,
        ECG = 11,
        ECMO = 12,
        Inhaler = 13,
        MechanicalVentilator = 14
    }

    [JsonProperty("DecimalFormat")] DecimalFormatData DecimalFormat { get; set; }
    [JsonProperty("Category")] eCategory Category { get; set; }
    [JsonProperty("ActionName")] string ActionName { get; set; }
    [JsonProperty("CompartmentName")] string CompartmentName { get; set; }
    [JsonProperty("SubstanceName")] string SubstanceName { get; set; }
    [JsonProperty("PropertyName")] string PropertyName { get; set; }
    [JsonProperty("Unit")] string Unit { get; set; }
}

public class DataRequestManagerData
{
    [JsonProperty("ResultsFilename")] string ResultsFilename { get; set; }
    [JsonProperty("SamplesPerSecond")] double SamplesPerSecond { get; set; }

    [JsonProperty("DefaultDecimalFormatting")]
    DecimalFormatData DefaultDecimalFormatting { get; set; }

    [JsonProperty("OverrideDecimalFormatting")]
    DecimalFormatData OverrideDecimalFormatting { get; set; }

    [JsonProperty("DataRequest")] List<DataRequestData> DataRequest { get; set; }
    [JsonProperty("ValidationTarget")] List<ValidationTargetData> ValidationTarget { get; set; }
}

public class DataRequestListData
{
    [JsonProperty("DataRequest")] List<DataRequestData> DataRequest { get; set; }
}

public class DataRequestedData
{
    [JsonProperty("ID")] int ID { get; set; }
    [JsonProperty("IsActive")] bool IsActive { get; set; }
    [JsonProperty("Value")] List<double> Value { get; set; }
    [JsonProperty("EventChange")] List<EventChangeData> EventChange { get; set; }
    [JsonProperty("LogMessages")] LogMessagesData LogMessages { get; set; }
}

public class ValidationTargetData
{
    public enum eType
    {
        Mean = 0,
        Min = 1,
        Max = 2
    }

    [JsonProperty("Type")] eType Type { get; set; }
    [JsonProperty("DataRequest")] DataRequestData DataRequest { get; set; }
    [JsonProperty("RangeMin")] double RangeMin { get; set; }
    [JsonProperty("RangeMax")] double RangeMax { get; set; }
}

public class DataRequestedListData
{
    [JsonProperty("DataRequested")] List<DataRequestedData> DataRequested { get; set; }
}

public class AnyConditionData
{
    [JsonProperty("PatientCondition")] AnyPatientConditionData PatientCondition { get; set; }
    [JsonProperty("EnvironmentCondition")] AnyEnvironmentConditionData EnvironmentCondition { get; set; }
}

public class ConditionListData
{
    [JsonProperty("AnyCondition")] List<AnyConditionData> AnyCondition { get; set; }
}

public class AnyActionData
{
    [JsonProperty("AdvanceTime")] AdvanceTimeData AdvanceTime { get; set; }
    [JsonProperty("Serialize")] SerializeStateData Serialize { get; set; }
    [JsonProperty("Overrides")] OverridesData Overrides { get; set; }
    [JsonProperty("PatientAction")] AnyPatientActionData PatientAction { get; set; }
    [JsonProperty("EnvironmentAction")] AnyEnvironmentActionData EnvironmentAction { get; set; }
    [JsonProperty("EquipmentAction")] AnyEquipmentActionData EquipmentAction { get; set; }
}

public class ActionListData
{
    [JsonProperty("AnyAction")] List<AnyActionData> AnyAction { get; set; }
}

public class ActionMapData
{
    [JsonProperty("ActionMap")] Dictionary<int, ActionListData> ActionMap { get; set; }
}

public class PatientConfigurationData
{
    [JsonProperty("DataRoot")] string DataRoot { get; set; }
    [JsonProperty("Patient")] PatientData Patient { get; set; }
    [JsonProperty("PatientFile")] string PatientFile { get; set; }
    [JsonProperty("Conditions")] ConditionListData Conditions { get; set; }
}

public class EngineInitializationData
{
    [JsonProperty("ID")] int ID { get; set; }
    [JsonProperty("PatientConfiguration")] PatientConfigurationData PatientConfiguration { get; set; }
    [JsonProperty("StateFilename")] string StateFilename { get; set; }
    [JsonProperty("State")] string State { get; set; }
    [JsonProperty("DataRequestManager")] DataRequestManagerData DataRequestManager { get; set; }
    [JsonProperty("LogFilename")] string LogFilename { get; set; }
    [JsonProperty("KeepLogMessages")] bool KeepLogMessages { get; set; }
    [JsonProperty("KeepEventChanges")] bool KeepEventChanges { get; set; }
}

public class EngineInitializationListData
{
    [JsonProperty("EngineInitialization")] List<EngineInitializationData> EngineInitialization { get; set; }
}

public class TimedStabilizationData
{
    [JsonProperty("TrackingStabilization")]
    eSwitch TrackingStabilization { get; set; }

    [JsonProperty("RestingStabilizationTime")]
    ScalarTimeData RestingStabilizationTime { get; set; }

    [JsonProperty("FeedbackStabilizationTime")]
    ScalarTimeData FeedbackStabilizationTime { get; set; }

    [JsonProperty("ConditionStabilization")]
    Dictionary<string, ScalarTimeData> ConditionStabilization { get; set; }
}

public class DynamicStabilizationPropertyConvergenceData
{
    [JsonProperty("DataRequest")] DataRequestData DataRequest { get; set; }
    [JsonProperty("PercentDifference")] double PercentDifference { get; set; }
}

public class DynamicStabilizationEngineConvergenceData
{
    [JsonProperty("ConvergenceTime")] ScalarTimeData ConvergenceTime { get; set; }
    [JsonProperty("MinimumReactionTime")] ScalarTimeData MinimumReactionTime { get; set; }

    [JsonProperty("MaximumAllowedStabilizationTime")]
    ScalarTimeData MaximumAllowedStabilizationTime { get; set; }

    [JsonProperty("PropertyConvergence")]
    List<DynamicStabilizationPropertyConvergenceData> PropertyConvergence { get; set; }
}

public class DynamicStabilizationData
{
    [JsonProperty("TrackingStabilization")]
    eSwitch TrackingStabilization { get; set; }

    [JsonProperty("RestingConvergence")] DynamicStabilizationEngineConvergenceData RestingConvergence { get; set; }
    [JsonProperty("FeedbackConvergence")] DynamicStabilizationEngineConvergenceData FeedbackConvergence { get; set; }

    [JsonProperty("ConditionConvergence")]
    Dictionary<string, DynamicStabilizationEngineConvergenceData> ConditionConvergence { get; set; }
}

public class LogMessagesData
{
    [JsonProperty("DebugMessages")] List<string> DebugMessages { get; set; }
    [JsonProperty("InfogMessages")] List<string> InfogMessages { get; set; }
    [JsonProperty("WarningMessages")] List<string> WarningMessages { get; set; }
    [JsonProperty("ErrorMessages")] List<string> ErrorMessages { get; set; }
    [JsonProperty("FatalMessages")] List<string> FatalMessages { get; set; }
}