Namespace LabelsOverlap
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("A", New Object() { (DirectCast(12.25R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("B", New Object() { (DirectCast(13.76R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("C", New Object() { (DirectCast(13.13R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("D", New Object() { (DirectCast(12.14R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("E", New Object() { (DirectCast(14.68R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("F", New Object() { (DirectCast(15.27R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("G", New Object() { (DirectCast(14.12R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("H", New Object() { (DirectCast(15.34R, Object))})
            Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.label1 = New System.Windows.Forms.Label()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.chartControl1.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisualRange.Auto = False
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "15.34"
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "10"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(12, 38)
            Me.chartControl1.Name = "chartControl1"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.View = lineSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(268, 167)
            Me.chartControl1.TabIndex = 2
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.comboBoxEdit1.EditValue = "Default"
            Me.comboBoxEdit1.Location = New System.Drawing.Point(143, 12)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.Items.AddRange(New Object() { "Default", "HideOverlapped", "JustifyAroundPoint", "JustifyAllAroundPoint", "Disable Resolving"})
            Me.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit1.Size = New System.Drawing.Size(137, 20)
            Me.comboBoxEdit1.TabIndex = 7
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(1, 15)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(136, 13)
            Me.label1.TabIndex = 6
            Me.label1.Text = "ResolveOverlapping Mode:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(292, 217)
            Me.Controls.Add(Me.comboBoxEdit1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.comboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private WithEvents comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
        Private label1 As System.Windows.Forms.Label

    End Class
End Namespace

