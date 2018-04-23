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
                    SetOverlappingMode(ResolveOverlappingMode.Default)
                Case 1
                    SetOverlappingMode(ResolveOverlappingMode.HideOverlapped)
                Case 2
                    SetOverlappingMode(ResolveOverlappingMode.JustifyAroundPoint)
                Case 3
                    SetOverlappingMode(ResolveOverlappingMode.JustifyAllAroundPoint)
                Case 4
                    SetOverlappingMode(ResolveOverlappingMode.Default)
            End Select
        End Sub

        Private Sub SetOverlappingMode(ByVal mode As ResolveOverlappingMode)
            chartControl1.Series(0).Label.ResolveOverlappingMode = mode
        End Sub

    End Class
End Namespace