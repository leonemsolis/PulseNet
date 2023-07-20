using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public enum eMergeType
{
    Append = 0,
    Replace = 1
}

public enum eAppliedRespiratoryCycle
{
    Expiration = 0,
    Inspiration = 1,
    Instantaneous = 2
}

public class ActionData
{
    [JsonProperty("Comment")] public string Comment { get; set; }
}

public class EquipmentActionData
{
    [JsonProperty("Action")] public ActionData Action { get; set; }
}

public class AdvanceTimeData
{
    [JsonProperty("Action")] public ActionData Action { get; set; }
    [JsonProperty("Time")] public ScalarTimeData Time { get; set; }
}

public class SerializeStateData
{
    public enum EType
    {
        Save = 0,
        Load = 1
    }

    [JsonProperty("Action")] public ActionData Action { get; set; }
    [JsonProperty("Type")] EType Type { get; set; }
    [JsonProperty("Filename")] string Filename { get; set; }
}

public class OverridesData
{
    [JsonProperty("Action")] public ActionData Action { get; set; }
    [JsonProperty("ScalarProperties")] public Dictionary<string, ScalarData> ScalarProperties { get; set; }
}