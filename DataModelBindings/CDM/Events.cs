using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class ActiveEventData
{
    [JsonProperty("Event")] eEvent Event { get; set; }
    [JsonProperty("Duration")] ScalarTimeData Duration { get; set; }
}

public class ActiveEventListData
{
    [JsonProperty("ActiveEvent")] List<ActiveEventData> ActiveEvent { get; set; }
}

public class EventChangeData
{
    [JsonProperty("Event")] eEvent Event { get; set; }
    [JsonProperty("SimTime")] ScalarTimeData SimTime { get; set; }
    [JsonProperty("Active")] bool Active { get; set; }
}

public class EventChangeListData
{
    [JsonProperty("Change")] List<EventChangeData> Change { get; set; }
}

public enum eEvent
{
    Antidiuresis = 0,
    Bradycardia = 1,
    Bradypnea = 2,
    BrainOxygenDeficit = 3,
    CardiacArrest = 4,
    CardiogenicShock = 5,
    CardiovascularCollapse = 6,
    CriticalBrainOxygenDeficit = 7,
    Dehydration = 8,
    Diuresis = 9,
    Fasciculation = 10,
    Fatigue = 11,
    FunctionalIncontinence = 12,
    Hypercapnia = 13,
    Hyperglycemia = 14,
    Hyperthermia = 15,
    Hypoglycemia = 16,
    Hypothermia = 17,
    Hypoxia = 18,
    HypovolemicShock = 19,
    IntracranialHypertension = 20,
    IntracranialHypotension = 21,
    IrreversibleState = 22,
    Ketoacidosis = 23,
    LacticAcidosis = 24,
    MassiveHemothorax = 25,
    MaximumPulmonaryVentilationRate = 26,
    MediumHemothorax = 27,
    MetabolicAcidosis = 28,
    MetabolicAlkalosis = 29,
    MinimalHemothorax = 30,
    ModerateHyperoxemia = 31,
    ModerateHypocapnia = 32,
    MyocardiumOxygenDeficit = 33,
    Natriuresis = 34,
    NutritionDepleted = 35,
    RenalHypoperfusion = 36,
    RespiratoryAcidosis = 37,
    RespiratoryAlkalosis = 38,
    SevereHyperoxemia = 39,
    SevereHypocapnia = 40,
    StartOfCardiacCycle = 41,
    StartOfExhale = 42,
    StartOfInhale = 43,
    Tachycardia = 44,
    Tachypnea = 45,

    // Equipment
    AnesthesiaMachineOxygenBottleOneExhausted = 1000,
    AnesthesiaMachineOxygenBottleTwoExhausted = 1001,
    AnesthesiaMachineReliefValveActive = 1002,
    MechanicalVentilatorReliefValveActive = 1003,
    SupplementalOxygenBottleExhausted = 1004,
    NonRebreatherMaskOxygenBagEmpty = 1005,
}