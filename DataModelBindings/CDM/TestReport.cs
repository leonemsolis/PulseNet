using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class PropertyValidationData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("ExpectedValue")] double ExpectedValue { get; set; }
    [JsonProperty("ComputedValue")] double ComputedValue { get; set; }
    [JsonProperty("Error")] double Error { get; set; }
    [JsonProperty("PatientSpecific")] bool PatientSpecific { get; set; }
}

public class PropertyValidationListData
{
    [JsonProperty("Property")] List<PropertyValidationData> Property { get; set; }
}

public class TestErrorStatisticsData
{
    [JsonProperty("PropertyName")] string PropertyName { get; set; }
    [JsonProperty("PercentTolerance")] double PercentTolerance { get; set; }
    [JsonProperty("NumberOfErrors")] uint NumberOfErrors { get; set; }
    [JsonProperty("ComputedPropertyID")] string ComputedPropertyID { get; set; }
    [JsonProperty("ExpectedPropertyID")] string ExpectedPropertyID { get; set; }

    [JsonProperty("MinimumError")] double MinimumError { get; set; }
    [JsonProperty("MaximumError")] double MaximumError { get; set; }
    [JsonProperty("AverageError")] double AverageError { get; set; }
    [JsonProperty("StandardDeviation")] double StandardDeviation { get; set; }

    [JsonProperty("PercentToleranceVsNumErrors")]
    FunctionData PercentToleranceVsNumErrors { get; set; }

    [JsonProperty("Differences")] List<string> Differences { get; set; }
}

public class TestCaseData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Duration")] ScalarTimeData Duration { get; set; }
    [JsonProperty("Failure")] List<string> Failure { get; set; }
    [JsonProperty("ErrorStats")] List<TestErrorStatisticsData> ErrorStats { get; set; }
}

public class TestSuiteData
{
    [JsonProperty("Name")] string Name { get; set; }
    [JsonProperty("Performed")] bool Performed { get; set; }
    [JsonProperty("Errors")] uint Errors { get; set; }
    [JsonProperty("Tests")] uint Tests { get; set; }

    [JsonProperty("Requirement")] List<string> Requirement { get; set; }
    [JsonProperty("ErrorStats")] List<TestErrorStatisticsData> ErrorStats { get; set; }
    [JsonProperty("TestCase")] List<TestCaseData> TestCase { get; set; }
}

public class TestReportData
{
    [JsonProperty("TestSuite")] List<TestSuiteData> TestSuite { get; set; }
}