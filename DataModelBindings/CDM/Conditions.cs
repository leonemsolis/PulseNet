using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class ConditionData
{
    [JsonProperty("Comment")] string Comment { get; set; }
}