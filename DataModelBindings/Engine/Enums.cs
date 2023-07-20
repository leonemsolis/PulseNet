namespace PulseNet.DataModelBindings.Engine;

public enum eModelType
{
    HumanAdultWholeBody = 0,
    HumanAdultVentilationMechanics = 1,
    HumanAdultHemodynamics = 2,
}

public enum eAirwayMode
{
    Free = 0,
    AnesthesiaMachine = 1,
    BagValveMask = 2,
    Inhaler = 3,
    MechanicalVentilation = 4,
    MechanicalVentilator = 5,
    NasalCannula = 6,
    NonRebreatherMask = 7,
    SimpleMask = 8,
}