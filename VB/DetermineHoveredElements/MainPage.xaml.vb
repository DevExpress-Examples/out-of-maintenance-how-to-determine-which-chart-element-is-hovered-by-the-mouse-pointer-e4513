Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports System.Windows.Input
Imports DevExpress.Xpf.Charts
Imports System.Text

Namespace DetermineHoveredElements
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chartControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			' Obtain hit information under the test point.
			Dim hitInfo As ChartHitInfo = chartControl1.CalcHitInfo(e.GetPosition(chartControl1))
			Dim builder As New StringBuilder()

			' Check  whether the chart element is under the test point and if so - obtain the element's content.
			If hitInfo.InDiagram Then
				builder.AppendLine("In diagram")
			End If
			If hitInfo.InAxis Then
				builder.AppendLine("In axis:" & hitInfo.Axis.Name)
			End If
			If hitInfo.AxisLabel IsNot Nothing Then
				builder.AppendLine("Axis Label:" & Constants.vbLf + hitInfo.AxisLabel.Name)
			End If
			If hitInfo.AxisTitle IsNot Nothing Then
				builder.AppendLine("Axis title:" & Constants.vbLf + hitInfo.AxisTitle.Content)
			End If
			If hitInfo.InTitle Then
				builder.AppendLine("In chart title:" & Constants.vbLf & " " & hitInfo.Title.Content)
			End If
			If hitInfo.InLegend Then
				builder.AppendLine("In legend")
			End If
			If hitInfo.InSeries Then
				builder.AppendLine("In series: " & hitInfo.Series.Name)
			End If
			If hitInfo.InSeriesLabel Then
				builder.AppendLine("In series label")
				builder.AppendLine("Series Label:" & hitInfo.SeriesLabel.Name)
			End If
			If hitInfo.SeriesPoint IsNot Nothing Then
				builder.AppendLine("Argument: " & hitInfo.SeriesPoint.Argument)
				builder.AppendLine("Value: " & hitInfo.SeriesPoint.Value)
			End If

			' Show hit-testing results 
			If builder.Length > 0 Then
				text1.Content = String.Format("Hit-testing results:" & Constants.vbLf + builder.ToString())
			Else
				text1.Content = "Move the mouse" & Constants.vbLf & " pointer over" & Constants.vbLf & " the chart to see" & Constants.vbLf & " information on" & Constants.vbLf & " hovered chart" & Constants.vbLf & " elements."
			End If
		End Sub
	End Class
End Namespace

