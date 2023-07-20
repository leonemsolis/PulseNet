using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class AnyPatientConditionData
{
    [JsonProperty("AcuteRespiratoryDistressSyndrome")]
    AcuteRespiratoryDistressSyndromeData AcuteRespiratoryDistressSyndrome { get; set; }

    [JsonProperty("ChronicAnemia")] ChronicAnemiaData ChronicAnemia { get; set; }

    [JsonProperty("ChronicObstructivePulmonaryDisease")]
    ChronicObstructivePulmonaryDiseaseData ChronicObstructivePulmonaryDisease { get; set; }

    [JsonProperty("ChronicPericardialEffusion")]
    ChronicPericardialEffusionData ChronicPericardialEffusion { get; set; }

    [JsonProperty("ChronicRenalStenosis")] ChronicRenalStenosisData ChronicRenalStenosis { get; set; }

    [JsonProperty("ChronicVentricularSystolicDysfunction")]
    ChronicVentricularSystolicDysfunctionData ChronicVentricularSystolicDysfunction { get; set; }

    [JsonProperty("ConsumeMeal")] ConsumeMealData ConsumeMeal { get; set; }

    [JsonProperty("ImpairedAlveolarExchange")]
    ImpairedAlveolarExchangeData ImpairedAlveolarExchange { get; set; }

    [JsonProperty("LobarPneumonia")] LobarPneumoniaData LobarPneumonia { get; set; }
    [JsonProperty("PulmonaryFibrosis")] PulmonaryFibrosisData PulmonaryFibrosis { get; set; }
    [JsonProperty("PulmonaryShunt")] PulmonaryShuntData PulmonaryShunt { get; set; }
    [JsonProperty("Sepsis")] SepsisData Sepsis { get; set; }
}

public class PatientConditionData
{
    [JsonProperty("Condition")] ConditionData Condition { get; set; }
}

/** @brief A type of respiratory failure characterized by rapid onset of widespread inflammation in the lungs. */
public class AcuteRespiratoryDistressSyndromeData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
    [JsonProperty("LeftLungAffected")] Scalar0To1Data LeftLungAffected { get; set; }
    [JsonProperty("RightLungAffected")] Scalar0To1Data RightLungAffected { get; set; }
}

/** @brief Condition characterized by reduced red blood cells, which leads to reduced oxygen carrying capacity. Implemented by reducing the amount of hemoglobin in the blood. */
public class ChronicAnemiaData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("ReductionFactor")] Scalar0To1Data ReductionFactor { get; set; }
}

/** @brief Impairment of the ventricular contraction, reducing the ability of the heart to pump blood. */
public class ChronicVentricularSystolicDysfunctionData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
}

/** @brief Chronic Obstructive Pulmonary Disease (COPD) is an obstructive lung disease characterized by chronically reduced airflow into the lungs. Unlike asthma, the reduction in airflow does not generally improve with medication. When tissue damage occurs primarily in the airways, the condition is called chronic bronchitis. When tissue destruction is focused in the alveoli, the condition is called emphysema. COPD is a manifestation of both conditions, although one condition may dominate. */
public class ChronicObstructivePulmonaryDiseaseData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("BronchitisSeverity")] Scalar0To1Data BronchitisSeverity { get; set; }
    [JsonProperty("EmphysemaSeverity")] Scalar0To1Data EmphysemaSeverity { get; set; }
}

/** @brief Pericardial effusion ("fluid around the heart") is an abnormal accumulation of fluid in the pericardial cavity. Because of the limited amount of space in the pericardial cavity, fluid accumulation leads to an increased intrapericardial pressure which can negatively affect heart function. A pericardial effusion with enough pressure to adversely affect heart function is called cardiac tamponade. Pericardial effusion usually results from a disturbed equilibrium between the production andre-absorption of pericardial fluid, or from a structural abnormality that allows fluid to enter the pericardial cavity. Normal levels of pericardial fluid are from 15 to 50 mL. */
public class ChronicPericardialEffusionData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("AccumulatedVolume")] ScalarVolumeData AccumulatedVolume { get; set; }
}

/** @brief Narrowing of the renal artery. */
public class ChronicRenalStenosisData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("LeftKidneySeverity")] Scalar0To1Data LeftKidneySeverity { get; set; }
    [JsonProperty("RightKidneySeverity")] Scalar0To1Data RightKidneySeverity { get; set; }
}

/** @brief Consume nutrients into the body along with a time elapsed since this meal. */
public class ConsumeMealData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("Meal")] MealData Meal { get; set; }
    [JsonProperty("MealFile")] string MealFile { get; set; }
}

/** @brief Generic way to specify the effectiveness of alveolar exchange. */
public class ImpairedAlveolarExchangeData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("ImpairedSurfaceArea")] ScalarAreaData ImpairedSurfaceArea { get; set; }
    [JsonProperty("ImpairedFraction")] Scalar0To1Data ImpairedFraction { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

/** @brief Lobar pneumonia is a form of pneumonia that affects one or more lobes of the lungs. As fluid fills portions of the lung it becomes more difficult to breath and the gas diffusion surface area in the alveoli is reduced. */
public class LobarPneumoniaData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
    [JsonProperty("LeftLungAffected")] Scalar0To1Data LeftLungAffected { get; set; }
    [JsonProperty("RightLungAffected")] Scalar0To1Data RightLungAffected { get; set; }
}

/** @brief Pulmonary Fibrosis is a restrictive lung disease that results in increase in the connective tissue of the lung. This reduces the lung compliance making it difficult to expand the lung during inspiration. */
public class PulmonaryFibrosisData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

/** @brief Pulmonary shunt is when the alveoli of the lungs are perfused with blood as normal, but ventilation (the supply of air) fails to supply the perfused region */
public class PulmonaryShuntData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}

/** @brief A potentially life-threatening condition caused by the body's response to an infection. */
public class SepsisData
{
    [JsonProperty("PatientCondition")] PatientConditionData PatientCondition { get; set; }
    [JsonProperty("Severity")] Scalar0To1Data Severity { get; set; }
}