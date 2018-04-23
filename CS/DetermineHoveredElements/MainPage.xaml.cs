using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Xpf.Charts;
using System.Text;

namespace DetermineHoveredElements
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void chartControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // Obtain hit information under the test point.
            ChartHitInfo hitInfo = chartControl1.CalcHitInfo(e.GetPosition(chartControl1));
            StringBuilder builder = new StringBuilder();

            // Check  whether the chart element is under the test point and if so - obtain the element's content.
            if (hitInfo.InDiagram)
                builder.AppendLine("In diagram");
            if (hitInfo.InAxis)
                builder.AppendLine("In axis:" + hitInfo.Axis.Name);
            if (hitInfo.AxisLabel != null)
                builder.AppendLine("Axis Label:\n" + hitInfo.AxisLabel.Name);
            if (hitInfo.AxisTitle != null)
                builder.AppendLine("Axis title:\n" + hitInfo.AxisTitle.Content);
            if (hitInfo.InTitle)
                builder.AppendLine("In chart title:\n " + hitInfo.Title.Content);
            if (hitInfo.InLegend)
                builder.AppendLine("In legend");
            if (hitInfo.InSeries)
                builder.AppendLine("In series: " + hitInfo.Series.Name);
            if (hitInfo.InSeriesLabel)
            {
                builder.AppendLine("In series label");
                builder.AppendLine("Series Label:" + hitInfo.SeriesLabel.Name);
            }
            if (hitInfo.SeriesPoint != null)
            {
                builder.AppendLine("Argument: " + hitInfo.SeriesPoint.Argument);
                builder.AppendLine("Value: " + hitInfo.SeriesPoint.Value);
            }

            // Show hit-testing results 
            if (builder.Length > 0)
                text1.Content = string.Format("Hit-testing results:\n" + builder.ToString());
            else
                text1.Content = "Move the mouse\n pointer over\n the chart to see\n information on\n hovered chart\n elements.";
        }
    }
}

