using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class PatientData
{
  /** @brief Enumeration for patient sex */
  public enum eSex
  {
    Male=0,
    Female=1
  }
  
  /** Physical Characteristics */
  [JsonProperty("Name")] string                   Name                                  {get;set;}
  [JsonProperty("Sex")] eSex                     Sex                                   {get;set;}
  [JsonProperty("Age")] ScalarTimeData           Age                                   {get;set;}
  [JsonProperty("Weight")] ScalarMassData           Weight                                {get;set;}
  [JsonProperty("Height")] ScalarLengthData         Height                                {get;set;}
  [JsonProperty("BodyDensity")] ScalarMassPerVolumeData  BodyDensity                           {get;set;}
  [JsonProperty("BodyFatFraction")] Scalar0To1Data           BodyFatFraction                       {get;set;}
  [JsonProperty("BodyMassIndex")] ScalarData               BodyMassIndex                         {get;set;}
  [JsonProperty("LeanBodyMass")] ScalarMassData           LeanBodyMass                          {get;set;}
  [JsonProperty("IdealBodyWeight")] ScalarMassData           IdealBodyWeight                       {get;set;}
  /** Physical Characteristics that can change and should be change due to a condition */
  [JsonProperty("AlveoliSurfaceArea")] ScalarAreaData           AlveoliSurfaceArea                    {get;set;}
  [JsonProperty("RightLungRatio")] Scalar0To1Data           RightLungRatio                        {get;set;}
  [JsonProperty("SkinSurfaceArea")] ScalarAreaData           SkinSurfaceArea                       {get;set;}
  /** Systemic Targets to tune the engine to */
  [JsonProperty("BasalMetabolicRate")] ScalarPowerData          BasalMetabolicRate                    {get;set;}
  [JsonProperty("BloodVolumeBaseline")] ScalarVolumeData         BloodVolumeBaseline                   {get;set;}
  [JsonProperty("DiastolicArterialPressureBaseline")] ScalarPressureData       DiastolicArterialPressureBaseline     {get;set;}
  [JsonProperty("HeartRateBaseline")] ScalarFrequencyData      HeartRateBaseline                     {get;set;}
  [JsonProperty("MeanArterialPressureBaseline")] ScalarPressureData       MeanArterialPressureBaseline          {get;set;}
  [JsonProperty("PulsePressureBaseline")] ScalarPressureData       PulsePressureBaseline                 {get;set;}
  [JsonProperty("RespirationRateBaseline")] ScalarFrequencyData      RespirationRateBaseline               {get;set;}
  [JsonProperty("SystolicArterialPressureBaseline")] ScalarPressureData       SystolicArterialPressureBaseline      {get;set;}
  [JsonProperty("TidalVolumeBaseline")] ScalarVolumeData         TidalVolumeBaseline                   {get;set;}
  /** Cardiovascular Systemic Bounds, generally computed based on physical characteristics */
  [JsonProperty("HeartRateMaximum")] ScalarFrequencyData      HeartRateMaximum                      {get;set;}
  [JsonProperty("HeartRateMinimum")] ScalarFrequencyData      HeartRateMinimum                      {get;set;}
  /** Respiratory Systemic Bounds, generally computed based on physical characteristics */
  [JsonProperty("ExpiratoryReserveVolume")] ScalarVolumeData         ExpiratoryReserveVolume               {get;set;}
  [JsonProperty("FunctionalResidualCapacity")] ScalarVolumeData         FunctionalResidualCapacity            {get;set;}
  [JsonProperty("InspiratoryCapacity")] ScalarVolumeData         InspiratoryCapacity                   {get;set;}
  [JsonProperty("InspiratoryReserveVolume")] ScalarVolumeData         InspiratoryReserveVolume              {get;set;}
  [JsonProperty("ResidualVolume")] ScalarVolumeData         ResidualVolume                        {get;set;}
  [JsonProperty("TotalLungCapacity")] ScalarVolumeData         TotalLungCapacity                     {get;set;}
  [JsonProperty("VitalCapacity")] ScalarVolumeData         VitalCapacity                         {get;set;}
}
