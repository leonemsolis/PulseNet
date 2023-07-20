using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class NutritionData
{
    [JsonProperty("Carbohydrate")] public ScalarMassData Carbohydrate;
    [JsonProperty("CarbohydrateDigestionRate")] public ScalarMassPerTimeData CarbohydrateDigestionRate { get; set; }
    [JsonProperty("Fat")] public ScalarMassData Fat { get; set; }
    [JsonProperty("FatDigestionRate")] public ScalarMassPerTimeData FatDigestionRate { get; set; }
    [JsonProperty("Protein")] public ScalarMassData Protein { get; set; }
    [JsonProperty("ProteinDigestionRate")] public ScalarMassPerTimeData ProteinDigestionRate { get; set; }
    [JsonProperty("Calcium")] public ScalarMassData Calcium { get; set; }
    [JsonProperty("Sodium")] public ScalarMassData Sodium { get; set; }
    [JsonProperty("Water")] public ScalarVolumeData Water { get; set; }
}

public class MealData
{
    [JsonProperty("Nutrition")] public NutritionData Nutrition { get; set; }
    [JsonProperty("ElapsedTime")] private ScalarTimeData ElapsedTime { get; set; }
}