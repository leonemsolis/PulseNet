using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public enum eSerializationFormat
{
    JSON = 0,
    BINARY = 1
}

public class ScenarioData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Description")] string Description { get; set; }

    [JsonProperty("EngineStateFile")] string EngineStateFile { get; set; }
    [JsonProperty("PatientConfiguration")] PatientConfigurationData PatientConfiguration { get; set; }
    [JsonProperty("DataRequestManager")] DataRequestManagerData DataRequestManager { get; set; }
    [JsonProperty("DataRequestFile")] List<string> DataRequestFile { get; set; }
    [JsonProperty("AnyAction")] List<AnyActionData> AnyAction { get; set; }
}

public class ScenarioExecData
{
    [JsonProperty("LogToConsole")] eSwitch LogToConsole { get; set; }
    [JsonProperty("DataRootDirectory")] string DataRootDirectory { get; set; }
    [JsonProperty("OutputRootDirectory")] string OutputRootDirectory { get; set; }

    [JsonProperty("OrganizeOutputDirectory")]
    eSwitch OrganizeOutputDirectory { get; set; }

    /** Used for testing that states are consistent around actions */
    [JsonProperty("AutoSerializeAfterActions")]
    eSwitch AutoSerializeAfterActions { get; set; }

    [JsonProperty("AutoSerializePeriod_s")]
    double AutoSerializePeriod_s { get; set; }

    [JsonProperty("TimeStampSerializedStates")]
    eSwitch TimeStampSerializedStates { get; set; }

    [JsonProperty("EngineConfigurationContent")]
    string EngineConfigurationContent { get; set; }

    [JsonProperty("EngineConfigurationFilename")]
    string EngineConfigurationFilename { get; set; }

    [JsonProperty("ScenarioContent")] string ScenarioContent { get; set; }
    [JsonProperty("ScenarioFilename")] string ScenarioFilename { get; set; }
    [JsonProperty("ScenarioDirectory")] string ScenarioDirectory { get; set; }
    [JsonProperty("ScenarioLogFilename")] string ScenarioLogFilename { get; set; }
    [JsonProperty("ScenarioLogDirectory")] string ScenarioLogDirectory { get; set; }

    [JsonProperty("ContentFormat")] eSerializationFormat ContentFormat { get; set; }
    [JsonProperty("ThreadCount")] int ThreadCount { get; set; }

    [JsonProperty("DataRequestFilesSearch")]
    List<string> DataRequestFilesSearch { get; set; }
}