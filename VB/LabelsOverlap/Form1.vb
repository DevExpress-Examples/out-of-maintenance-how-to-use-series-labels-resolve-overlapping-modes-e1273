Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace LabelsOverlap
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub comboBoxEdit1_Properties_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.Properties.SelectedValueChanged
			Select Case comboBoxEdit1.SelectedIndex
				Case 0
					SetOverlappingMode(True, ResolveOverlappingMode.Default)
				Case 1
					SetOverlappingMode(True, ResolveOverlappingMode.HideOverlapped)
				Case 2
					SetOverlappingMode(True, ResolveOverlappingMode.JustifyAroundPoint)
				Case 3
					SetOverlappingMode(True, ResolveOverlappingMode.JustifyAllAroundPoint)
				Case 4
					SetOverlappingMode(False, ResolveOverlappingMode.Default)
			End Select
		End Sub

		Private Sub SetOverlappingMode(ByVal resolve As Boolean, ByVal mode As ResolveOverlappingMode)
			Dim label As SeriesLabelBase = chartControl1.Series(0).Label
			label.OverlappingOptions.ResolveOverlapping = resolve
			If resolve Then
				label.OverlappingOptions.Mode = mode
			End If
		End Sub

	End Class
End Namespace