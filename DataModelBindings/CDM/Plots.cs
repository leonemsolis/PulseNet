using System.Collections.Generic;
using Newtonsoft.Json;

namespace PulseNet.DataModelBindings.CDM;

public class AnyPlotterData
{
    [JsonProperty("MultiHeaderSeriesPlotter")]
    MultiHeaderSeriesPlotterData MultiHeaderSeriesPlotter { get; set; }

    [JsonProperty("ComparePlotter")] ComparePlotterData ComparePlotter { get; set; }
}

public class PlotterListData
{
    [JsonProperty("Comment")] string Comment { get; set; }

    [JsonProperty("PlotConfig")] PlotConfigData PlotConfig { get; set; }
    [JsonProperty("Plotter")] List<AnyPlotterData> Plotter { get; set; }
}

/** @brief Data used to configure plots. */
public class PlotConfigData
{
    /** @brief Enumeration for legend modes. */
    public enum eLegendMode
    {
        AllLegends = 0,
        NoLegends = 1,
        HideActionEventLegend = 2,
        OnlyActionEventLegend = 3,
    }

    /** @brief Enumeration for percentage of baseline modes. */
    public enum ePercentageOfBaselineMode
    {
        Off = 0,
        All = 1,
        OnlyX = 2,
        OnlyY = 3,
    }

    /** @brief Enumeration for tick style. */
    public enum eTickStyle
    {
        Scientific = 0,
        Plain = 1,
    }

    /** @brief If scientific tick style is used, only apply scientific notation outside of the range 10^M to 10^N.*/
    public class SciLimitsData
    {
        [JsonProperty("M")] int M { get; set; }
        [JsonProperty("N")] int N { get; set; }
    }

    [JsonProperty("Disabled")] bool Disabled { get; set; }
    [JsonProperty("FillArea")] bool FillArea { get; set; }
    [JsonProperty("FontSize")] double FontSize { get; set; }
    [JsonProperty("Gridlines")] bool Gridlines { get; set; }
    [JsonProperty("ImageProperties")] ImagePropertyData ImageProperties { get; set; }
    [JsonProperty("LegendFontSize")] double LegendFontSize { get; set; }
    [JsonProperty("LegendMode")] eLegendMode LegendMode { get; set; }
    [JsonProperty("LogAxis")] bool LogAxis { get; set; }
    [JsonProperty("OmitActionsWith")] string OmitActionsWith { get; set; }
    [JsonProperty("OmitEventsWith")] string OmitEventsWith { get; set; }
    [JsonProperty("OutputPathOverride")] string OutputPathOverride { get; set; }

    [JsonProperty("PercentOfBaselineMode")]
    ePercentageOfBaselineMode PercentOfBaselineMode { get; set; }

    [JsonProperty("PlotActions")] bool PlotActions { get; set; }
    [JsonProperty("PlotEvents")] bool PlotEvents { get; set; }
    [JsonProperty("SciLimits")] SciLimitsData SciLimits { get; set; }
    [JsonProperty("TickStyle")] eTickStyle TickStyle { get; set; }
    [JsonProperty("ZeroAxis")] bool ZeroAxis { get; set; }
}

/** @brief Data used to configure a plot source. */
public class PlotSourceData
{
    [JsonProperty("CSVData")] string CSVData { get; set; }

    [JsonProperty("Label")] string Label { get; set; }
    [JsonProperty("LineFormat")] string LineFormat { get; set; }
    [JsonProperty("LineWidth")] double LineWidth { get; set; }
    [JsonProperty("StartRow")] int StartRow { get; set; }
    [JsonProperty("EndRow")] int EndRow { get; set; }
    [JsonProperty("RowSkip")] int RowSkip { get; set; }
    [JsonProperty("LogFile")] string LogFile { get; set; }
}

/** @brief Data used to configure x vs y plots. */
public class ComparePlotterData
{
    /** @brief Enumeration for plot types. */
    public enum ePlotType
    {
        NoPlot = 0,
        FullPlot = 1,
        FullPlotErrors = 2,
        FastPlot = 3,
        FastPlotErrors = 4,
        MemoryFastPlot = 5,
    }

    [JsonProperty("Comment")] string Comment { get; set; }

    [JsonProperty("PlotConfig")] PlotConfigData PlotConfig { get; set; }
    [JsonProperty("ComputedSource")] PlotSourceData ComputedSource { get; set; }
    [JsonProperty("ExpectedSource")] PlotSourceData ExpectedSource { get; set; }
    [JsonProperty("Failures")] List<string> Failures { get; set; }
    [JsonProperty("RMSValues")] Dictionary<string, double> RMSValues { get; set; }
    [JsonProperty("PlotType")] ePlotType PlotType { get; set; }
}

/** @brief Data used to configure x vs y plots. */
public class MultiHeaderSeriesPlotterData
{
    [JsonProperty("Comment")] string Comment { get; set; }

    [JsonProperty("PlotConfig")] PlotConfigData PlotConfig { get; set; }
    [JsonProperty("PlotSource")] List<PlotSourceData> PlotSource { get; set; }
    [JsonProperty("ValidationSource")] PlotSourceData ValidationSource { get; set; }

    [JsonProperty("Series")] List<SeriesData> Series { get; set; }

    public class SeriesData
    {
        [JsonProperty("Comment")] string Comment { get; set; }

        [JsonProperty("PlotConfig")] PlotConfigData PlotConfig { get; set; }
        [JsonProperty("OutputFilename")] string OutputFilename { get; set; }
        [JsonProperty("Title")] string Title { get; set; }
        [JsonProperty("XHeader")] string XHeader { get; set; }
        [JsonProperty("XLabel")] string XLabel { get; set; }
        [JsonProperty("XBounds")] BoundsData XBounds { get; set; }
        [JsonProperty("X2Header")] string X2Header { get; set; }
        [JsonProperty("YHeader")] List<string> YHeader { get; set; }
        [JsonProperty("YLabel")] string YLabel { get; set; }
        [JsonProperty("YBounds")] BoundsData YBounds { get; set; }
        [JsonProperty("Y2Header")] List<string> Y2Header { get; set; }
        [JsonProperty("Y2Label")] string Y2Label { get; set; }
        [JsonProperty("Y2Bounds")] BoundsData Y2Bounds { get; set; }
    }
}

/** @brief Data used to specify bounds. */
public class BoundsData
{
    [JsonProperty("LowerBound")] double LowerBound { get; set; }
    [JsonProperty("UpperBound")] double UpperBound { get; set; }
}

/** @brief Data used to specify image property data. */
public class ImagePropertyData
{
    /** @brief Dimension modes. */
    public enum eDimensionMode
    {
        Default = 0,
        Square = 1,
        Legend = 2,
        Unbound = 3,
    }

    [JsonProperty("DimensionMode")] eDimensionMode DimensionMode { get; set; }
    [JsonProperty("FileFormat")] string FileFormat { get; set; }
    [JsonProperty("Height_inch")] double Height_inch { get; set; }
    [JsonProperty("Width_inch")] double Width_inch { get; set; }
    [JsonProperty("DPI")] double DPI { get; set; }
}