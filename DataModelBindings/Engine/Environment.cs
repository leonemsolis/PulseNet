using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.Engine;

public class EnvironmentData
{
    [JsonProperty("Common")] EnvironmentData Common { get; set; }

    [JsonProperty("PatientEquivalentDiameter_m")]
    double PatientEquivalentDiameter_m { get; set; }
}