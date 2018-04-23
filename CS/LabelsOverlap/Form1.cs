using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace LabelsOverlap {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void comboBoxEdit1_Properties_SelectedValueChanged(object sender, EventArgs e) {
            switch (comboBoxEdit1.SelectedIndex) {
                case 0:
                    SetOverlappingMode(true, ResolveOverlappingMode.Default);
                    break;
                case 1:
                    SetOverlappingMode(true, ResolveOverlappingMode.HideOverlapped);
                    break;
                case 2:
                    SetOverlappingMode(true, ResolveOverlappingMode.JustifyAroundPoint);
                    break;
                case 3:
                    SetOverlappingMode(true, ResolveOverlappingMode.JustifyAllAroundPoint);
                    break;
                case 4:
                    SetOverlappingMode(false, ResolveOverlappingMode.Default);
                    break;
            }
        }

        private void SetOverlappingMode(bool resolve, ResolveOverlappingMode mode) {
            SeriesLabelBase label = chartControl1.Series[0].Label;
            label.OverlappingOptions.ResolveOverlapping = resolve;
            if (resolve)
                label.OverlappingOptions.Mode = mode;
        }

    }
}