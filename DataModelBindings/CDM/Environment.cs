using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class EnvironmentalConditionsData
{
    public enum eSurroundingType
    {
        NullSurrounding = 0,
        Air = 1,
        Water = 2
    }

    [JsonProperty("SurroundingType")] eSurroundingType SurroundingType { get; set; }

    [JsonProperty("AirDensity")] ScalarMassPerVolumeData AirDensity { get; set; }
    [JsonProperty("AirVelocity")] ScalarLengthPerTimeData AirVelocity { get; set; }
    [JsonProperty("AmbientTemperature")] ScalarTemperatureData AmbientTemperature { get; set; }
    [JsonProperty("AtmosphericPressure")] ScalarPressureData AtmosphericPressure { get; set; }
    [JsonProperty("ClothingResistance")] ScalarHeatResistanceAreaData ClothingResistance { get; set; }
    [JsonProperty("Emissivity")] Scalar0To1Data Emissivity { get; set; }

    [JsonProperty("MeanRadiantTemperature")]
    ScalarTemperatureData MeanRadiantTemperature { get; set; }

    [JsonProperty("RelativeHumidity")] Scalar0To1Data RelativeHumidity { get; set; }

    [JsonProperty("RespirationAmbientTemperature")]
    ScalarTemperatureData RespirationAmbientTemperature { get; set; }

    [JsonProperty("AmbientGas")] List<SubstanceFractionData> AmbientGas { get; set; }
    [JsonProperty("AmbientAerosol")] List<SubstanceConcentrationData> AmbientAerosol { get; set; }
}

/** @brief Equipment or clothing activly changing the surounding environment of the patient. */
public class ActiveConditioningData
{
    [JsonProperty("Power")] ScalarPowerData Power { get; set; }
    [JsonProperty("SurfaceArea")] ScalarAreaData SurfaceArea { get; set; }
    [JsonProperty("SurfaceAreaFraction")] Scalar0To1Data SurfaceAreaFraction { get; set; }
}

/** @brief Equipment or clothing activly changing the skin temperature of the patient. */
public class AppliedTemperatureData
{
    [JsonProperty("State")] eSwitch State { get; set; }
    [JsonProperty("Temperature")] ScalarTemperatureData Temperature { get; set; }
    [JsonProperty("SurfaceArea")] ScalarAreaData SurfaceArea { get; set; }
    [JsonProperty("SurfaceAreaFraction")] Scalar0To1Data SurfaceAreaFraction { get; set; }
}

/** @brief The overall environment of the patient. */
public class EnvironmentData
{
    [JsonProperty("EnvironmentalConditions")]
    EnvironmentalConditionsData EnvironmentalConditions { get; set; }

    [JsonProperty("ActiveHeating")] ActiveConditioningData ActiveHeating { get; set; }
    [JsonProperty("ActiveCooling")] ActiveConditioningData ActiveCooling { get; set; }
    [JsonProperty("AppliedTemperature")] AppliedTemperatureData AppliedTemperature { get; set; }

    [JsonProperty("ConvectiveHeatLoss")] ScalarPowerData ConvectiveHeatLoss { get; set; }

    [JsonProperty("ConvectiveHeatTranferCoefficient")]
    ScalarHeatConductancePerAreaData ConvectiveHeatTranferCoefficient { get; set; }

    [JsonProperty("EvaporativeHeatLoss")] ScalarPowerData EvaporativeHeatLoss { get; set; }

    [JsonProperty("EvaporativeHeatTranferCoefficient")]
    ScalarHeatConductancePerAreaData EvaporativeHeatTranferCoefficient { get; set; }

    [JsonProperty("RadiativeHeatLoss")] ScalarPowerData RadiativeHeatLoss { get; set; }

    [JsonProperty("RadiativeHeatTranferCoefficient")]
    ScalarHeatConductancePerAreaData RadiativeHeatTranferCoefficient { get; set; }

    [JsonProperty("RespirationHeatLoss")] ScalarPowerData RespirationHeatLoss { get; set; }
    [JsonProperty("SkinHeatLoss")] ScalarPowerData SkinHeatLoss { get; set; }
}