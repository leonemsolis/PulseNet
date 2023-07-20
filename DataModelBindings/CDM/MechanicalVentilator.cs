using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class MechanicalVentilatorSettingsData
{
  [JsonProperty("Connection")] eSwitch                             Connection                                {get;set;}
  [JsonProperty("ConnectionVolume")] ScalarVolumeData                    ConnectionVolume                          {get;set;}
  [JsonProperty("Compliance")] ScalarVolumePerPressureData         Compliance                                {get;set;}
  [JsonProperty("DriverDampingParameter")] ScalarFrequencyData                 DriverDampingParameter                    {get;set;}
  
    [JsonProperty("PositiveEndExpiredPressure")] ScalarPressureData                PositiveEndExpiredPressure                {get;set;}
    [JsonProperty("FunctionalResidualCapacity")] ScalarPressureData                FunctionalResidualCapacity                {get;set;}
    [JsonProperty("ExpirationCycleFlow")] ScalarVolumePerTimeData           ExpirationCycleFlow                       {get;set;}
    [JsonProperty("ExpirationCyclePressure")] ScalarPressureData                ExpirationCyclePressure                   {get;set;}
    [JsonProperty("ExpirationCycleTime")] ScalarTimeData                    ExpirationCycleTime                       {get;set;}
    [JsonProperty("ExpirationCycleVolume")] ScalarVolumeData                  ExpirationCycleVolume                     {get;set;}
    [JsonProperty("ExpirationCycleRespiratoryModel")] eSwitch                           ExpirationCycleRespiratoryModel           {get;set;}
  
  [JsonProperty("ExpirationLimbVolume")] ScalarVolumeData                    ExpirationLimbVolume                      {get;set;}
  [JsonProperty("ExpirationTubeResistance")] ScalarPressureTimePerVolumeData     ExpirationTubeResistance                  {get;set;}
  [JsonProperty("ExpirationValveResistance")] ScalarPressureTimePerVolumeData     ExpirationValveResistance                 {get;set;}
  [JsonProperty("ExpirationValveVolume")] ScalarVolumeData                    ExpirationValveVolume                     {get;set;}
  [JsonProperty("ExpirationWaveform")] eDriverWaveform                     ExpirationWaveform                        {get;set;}
  [JsonProperty("ExpirationWaveformPeriod")] ScalarTimeData                      ExpirationWaveformPeriod                  {get;set;}
  
    [JsonProperty("InspirationLimitFlow")] ScalarVolumePerTimeData           InspirationLimitFlow                      {get;set;}
    [JsonProperty("InspirationLimitPressure")] ScalarPressureData                InspirationLimitPressure                  {get;set;}
    [JsonProperty("InspirationLimitVolume")] ScalarVolumeData                  InspirationLimitVolume                    {get;set;}
  
  [JsonProperty("InspirationPauseTime")] ScalarTimeData                      InspirationPauseTime                      {get;set;}
  
    [JsonProperty("InspirationTargetFlow")] ScalarVolumePerTimeData           InspirationTargetFlow                     {get;set;}
    [JsonProperty("PeakInspiratoryPressure")] ScalarPressureData                PeakInspiratoryPressure                   {get;set;}
  
    [JsonProperty("InspirationMachineTriggerTime")] ScalarTimeData                    InspirationMachineTriggerTime             {get;set;}
  
    [JsonProperty("InspirationPatientTriggerFlow")] ScalarVolumePerTimeData           InspirationPatientTriggerFlow             {get;set;}
    [JsonProperty("InspirationPatientTriggerPressure")] ScalarPressureData                InspirationPatientTriggerPressure         {get;set;}
    [JsonProperty("InspirationPatientTriggerRespiratoryModel")] eSwitch                           InspirationPatientTriggerRespiratoryModel {get;set;}
  
  [JsonProperty("InspirationLimbVolume")] ScalarVolumeData                    InspirationLimbVolume                     {get;set;}
  [JsonProperty("InspirationTubeResistance")] ScalarPressureTimePerVolumeData     InspirationTubeResistance                 {get;set;}
  [JsonProperty("InspirationValveResistance")] ScalarPressureTimePerVolumeData     InspirationValveResistance                {get;set;}
  [JsonProperty("InspirationValveVolume")] ScalarVolumeData                    InspirationValveVolume                    {get;set;}
  [JsonProperty("InspirationWaveform")] eDriverWaveform                     InspirationWaveform                       {get;set;}
  [JsonProperty("InspirationWaveformPeriod")] ScalarTimeData                      InspirationWaveformPeriod                 {get;set;}
  
  [JsonProperty("ReliefValveThreshold")] ScalarPressureData                  ReliefValveThreshold                      {get;set;}
  [JsonProperty("YPieceVolume")] ScalarVolumeData                    YPieceVolume                              {get;set;}
  
  [JsonProperty("FractionInspiredGas")] List<SubstanceFractionData>      FractionInspiredGas                       {get;set;}
  [JsonProperty("ConcentrationInspiredAerosol")] List<SubstanceConcentrationData> ConcentrationInspiredAerosol              {get;set;}
}

public class MechanicalVentilatorData
{
  [JsonProperty("AirwayPressure")] ScalarPressureData                  AirwayPressure                            {get;set;}
  [JsonProperty("BreathState")] eBreathState                        BreathState                               {get;set;}
  [JsonProperty("DynamicPulmonaryCompliance")] ScalarVolumePerPressureData         DynamicPulmonaryCompliance                {get;set;}
  [JsonProperty("EndTidalCarbonDioxideFraction")] Scalar0To1Data                      EndTidalCarbonDioxideFraction             {get;set;}
  [JsonProperty("EndTidalCarbonDioxidePressure")] ScalarPressureData                  EndTidalCarbonDioxidePressure             {get;set;}
  [JsonProperty("EndTidalOxygenFraction")] Scalar0To1Data                      EndTidalOxygenFraction                    {get;set;}
  [JsonProperty("EndTidalOxygenPressure")] ScalarPressureData                  EndTidalOxygenPressure                    {get;set;}
  [JsonProperty("ExpiratoryFlow")] ScalarVolumePerTimeData             ExpiratoryFlow                            {get;set;}
  [JsonProperty("ExpiratoryTidalVolume")] ScalarVolumeData                    ExpiratoryTidalVolume                     {get;set;}
  [JsonProperty("InspiratoryExpiratoryRatio")] ScalarData                          InspiratoryExpiratoryRatio                {get;set;}
  [JsonProperty("InspiratoryFlow")] ScalarVolumePerTimeData             InspiratoryFlow                           {get;set;}
  [JsonProperty("InspiratoryTidalVolume")] ScalarVolumeData                    InspiratoryTidalVolume                    {get;set;}
  [JsonProperty("IntrinsicPositiveEndExpiredPressure")] ScalarPressureData                  IntrinsicPositiveEndExpiredPressure       {get;set;}
  [JsonProperty("LeakFraction")] Scalar0To1Data                      LeakFraction                              {get;set;}
  [JsonProperty("MeanAirwayPressure")] ScalarPressureData                  MeanAirwayPressure                        {get;set;}
  [JsonProperty("PeakInspiratoryPressure")] ScalarPressureData                  PeakInspiratoryPressure                   {get;set;}
  [JsonProperty("PlateauPressure")] ScalarPressureData                  PlateauPressure                           {get;set;}
  [JsonProperty("PositiveEndExpiratoryPressure")] ScalarPressureData                  PositiveEndExpiratoryPressure             {get;set;}
  [JsonProperty("PulmonaryResistance")] ScalarPressureTimePerVolumeData     PulmonaryResistance                       {get;set;}
  [JsonProperty("RespirationRate")] ScalarFrequencyData                 RespirationRate                           {get;set;}
  [JsonProperty("StaticPulmonaryCompliance")] ScalarVolumePerPressureData         StaticPulmonaryCompliance                 {get;set;}
  [JsonProperty("TidalVolume")] ScalarVolumeData                    TidalVolume                               {get;set;}
  [JsonProperty("TotalLungVolume")] ScalarVolumeData                    TotalLungVolume                           {get;set;}
  [JsonProperty("TotalPulmonaryVentilation")] ScalarVolumePerTimeData             TotalPulmonaryVentilation                 {get;set;}

  [JsonProperty("Settings")] MechanicalVentilatorSettingsData    Settings                                  {get;set;}
}
