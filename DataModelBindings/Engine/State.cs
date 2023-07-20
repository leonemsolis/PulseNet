using System.Collections.Generic;
using Newtonsoft.Json;
using PulseNet.DataModelBindings.CDM;

namespace PulseNet.DataModelBindings.Engine;

public class StateData
{
    [JsonProperty("Version")] string Version { get; set; }
    [JsonProperty("AirwayMode")] eAirwayMode AirwayMode { get; set; }
    [JsonProperty("Intubation")] eSwitch Intubation { get; set; }
    [JsonProperty("SimulationTime")] ScalarTimeData SimulationTime { get; set; }
    [JsonProperty("CurrentPatient")] PatientData CurrentPatient { get; set; }
    [JsonProperty("InitialPatient")] PatientData InitialPatient { get; set; }
    [JsonProperty("Conditions")] ConditionListData Conditions { get; set; }
    [JsonProperty("ActiveActions")] ActionListData ActiveActions { get; set; }
    [JsonProperty("ActiveEvents")] ActiveEventListData ActiveEvents { get; set; }
    [JsonProperty("BloodChemistry")] BloodChemistryData BloodChemistry { get; set; }
    [JsonProperty("Cardiovascular")] CardiovascularData Cardiovascular { get; set; }
    [JsonProperty("Drug")] DrugData Drug { get; set; }
    [JsonProperty("Endocrine")] EndocrineData Endocrine { get; set; }
    [JsonProperty("Energy")] EnergyData Energy { get; set; }
    [JsonProperty("Gastrointestinal")] GastrointestinalData Gastrointestinal { get; set; }
    [JsonProperty("Hepatic")] HepaticData Hepatic { get; set; }
    [JsonProperty("Nervous")] NervousData Nervous { get; set; }
    [JsonProperty("Renal")] RenalData Renal { get; set; }
    [JsonProperty("Respiratory")] RespiratoryData Respiratory { get; set; }
    [JsonProperty("Tissue")] TissueData Tissue { get; set; }
    [JsonProperty("Environment")] EnvironmentData Environment { get; set; }
    [JsonProperty("AnesthesiaMachine")] AnesthesiaMachineData AnesthesiaMachine { get; set; }
    [JsonProperty("BagValveMask")] BagValveMaskData BagValveMask { get; set; }
    [JsonProperty("ECMO")] ECMOData ECMO { get; set; }
    [JsonProperty("ElectroCardioGram")] ElectroCardioGramData ElectroCardioGram { get; set; }
    [JsonProperty("Inhaler")] InhalerData Inhaler { get; set; }
    [JsonProperty("MechanicalVentilator")] MechanicalVentilatorData MechanicalVentilator { get; set; }
    [JsonProperty("CompartmentManager")] CompartmentManagerData CompartmentManager { get; set; }
    [JsonProperty("CircuitManager")] CircuitManagerData CircuitManager { get; set; }
    [JsonProperty("ActiveSubstance")] List<string> ActiveSubstance { get; set; }
    [JsonProperty("ActiveCompound")] List<string> ActiveCompound { get; set; }
    [JsonProperty("Substance")] List<SubstanceData> Substance { get; set; }
    [JsonProperty("Compound")] List<SubstanceCompoundData> Compound { get; set; }
    [JsonProperty("Configuration")] ConfigurationData Configuration { get; set; }
    [JsonProperty("DataRequestManager")] DataRequestManagerData DataRequestManager { get; set; }
}