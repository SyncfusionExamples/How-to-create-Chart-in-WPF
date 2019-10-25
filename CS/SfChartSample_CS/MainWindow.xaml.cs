using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.UI.Xaml.Charts;

namespace SfChartSample_CS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SfChart chart = new SfChart();

            // Setting header for the SfChart.
            chart.Header = "Chart";

            // Setting DataContext for SfChart.
            chart.DataContext = new ViewModel();

            // Adding Legend to the SfChart.
            chart.Legend = new ChartLegend();

            // Initialize the horizontal axis for SfChart.
            CategoryAxis primaryAxis = new CategoryAxis();
            primaryAxis.Header = "Name";
            primaryAxis.FontSize = 14;
            chart.PrimaryAxis = primaryAxis;

            // Initialize the vertical axis for SfChart.
            NumericalAxis secondaryAxis = new NumericalAxis();
            secondaryAxis.Header = "Height(in cm)";
            secondaryAxis.FontSize = 14;
            chart.SecondaryAxis = secondaryAxis;

            // Initialize the series for SfChart.
            ColumnSeries columnSeries = new ColumnSeries();
            columnSeries.XBindingPath = "Name";
            columnSeries.YBindingPath = "Height";
            columnSeries.ItemsSource = (chart.DataContext as ViewModel).Data;
            columnSeries.Label = "Height";
            chart.Series.Add(columnSeries);

            //Setting chart as Window's Content. 
            Content = chart;
        }
    }
}
