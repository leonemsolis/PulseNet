using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public enum eElectroCardioGramWaveformType
{
    Sinus = 0,
    VentricularFibrillation = 1,
    VentricularTachycardia = 2
}

public enum eElectroCardioGramWaveformLead
{
    NullLead = 0,
    Lead1 = 1,
    Lead2 = 2,
    Lead3 = 3,
    Lead4 = 4,
    Lead5 = 5,
    Lead6 = 6,
    Lead7 = 7,
    Lead8 = 8,
    Lead9 = 9,
    Lead10 = 10,
    Lead11 = 11,
    Lead12 = 12
}

public class ElectroCardioGramWaveformData
{
    [JsonProperty("Lead")] eElectroCardioGramWaveformLead Lead { get; set; }
    [JsonProperty("Type")] eElectroCardioGramWaveformType Type { get; set; }
    [JsonProperty("OriginalData")] ArrayElectricPotentialData OriginalData { get; set; }
    [JsonProperty("ActiveCycle")] ArrayElectricPotentialData ActiveCycle { get; set; }
    [JsonProperty("ActiveCycleIndex")] int ActiveCycleIndex { get; set; }
    [JsonProperty("Recycling")] bool Recycling { get; set; }
}

public class ElectroCardioGramData
{
    [JsonProperty("Lead1ElectricPotential")]
    ScalarElectricPotentialData Lead1ElectricPotential { get; set; }

    [JsonProperty("Lead2ElectricPotential")]
    ScalarElectricPotentialData Lead2ElectricPotential { get; set; }

    [JsonProperty("Lead3ElectricPotential")]
    ScalarElectricPotentialData Lead3ElectricPotential { get; set; }

    [JsonProperty("Lead4ElectricPotential")]
    ScalarElectricPotentialData Lead4ElectricPotential { get; set; }

    [JsonProperty("Lead5ElectricPotential")]
    ScalarElectricPotentialData Lead5ElectricPotential { get; set; }

    [JsonProperty("Lead6ElectricPotential")]
    ScalarElectricPotentialData Lead6ElectricPotential { get; set; }

    [JsonProperty("Lead7ElectricPotential")]
    ScalarElectricPotentialData Lead7ElectricPotential { get; set; }

    [JsonProperty("Lead8ElectricPotential")]
    ScalarElectricPotentialData Lead8ElectricPotential { get; set; }

    [JsonProperty("Lead9ElectricPotential")]
    ScalarElectricPotentialData Lead9ElectricPotential { get; set; }

    [JsonProperty("Lead10ElectricPotential")]
    ScalarElectricPotentialData Lead10ElectricPotential { get; set; }

    [JsonProperty("Lead11ElectricPotential")]
    ScalarElectricPotentialData Lead11ElectricPotential { get; set; }

    [JsonProperty("Lead12ElectricPotential")]
    ScalarElectricPotentialData Lead12ElectricPotential { get; set; }

    [JsonProperty("ActiveType")] eElectroCardioGramWaveformType ActiveType { get; set; }

    [JsonProperty("Waveforms")]
    List<ElectroCardioGramWaveformData> Waveforms { get; set; }
}