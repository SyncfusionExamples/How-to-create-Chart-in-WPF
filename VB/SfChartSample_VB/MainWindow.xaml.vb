Imports Syncfusion.UI.Xaml.Charts

Class MainWindow

    Public Sub New()

        InitializeComponent()

        Dim chart As SfChart = New SfChart()

        ' Setting header for the SfChart.
        chart.Header = "Chart"

        ' Setting DataContext for SfChart.
        chart.DataContext = New ViewModel()

        ' Adding Legend to the SfChart.
        chart.Legend = New ChartLegend()

        ' Initialize the horizontal axis for SfChart.
        Dim primaryAxis As CategoryAxis = New CategoryAxis()
        primaryAxis.Header = "Name"
        primaryAxis.FontSize = 14
        chart.PrimaryAxis = primaryAxis

        ' Initialize the vertical axis for SfChart.
        Dim secondaryAxis As NumericalAxis = New NumericalAxis()
        secondaryAxis.Header = "Height(in cm)"
        secondaryAxis.FontSize = 14
        chart.SecondaryAxis = secondaryAxis

        ' Initialize the series for SfChart.
        Dim ColumnSeries As ColumnSeries = New ColumnSeries()
        ColumnSeries.XBindingPath = "Name"
        ColumnSeries.YBindingPath = "Height"
        ColumnSeries.ItemsSource = TryCast(chart.DataContext, ViewModel).Data
        ColumnSeries.Label = "Height"
        chart.Series.Add(ColumnSeries)

        ' Setting chart as Window's Content. 
        Content = chart

    End Sub

End Class
