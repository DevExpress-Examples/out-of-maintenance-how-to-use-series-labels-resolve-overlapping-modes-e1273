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
                    SetOverlappingMode(ResolveOverlappingMode.Default);
                    break;
                case 1:
                    SetOverlappingMode(ResolveOverlappingMode.HideOverlapped);
                    break;
                case 2:
                    SetOverlappingMode(ResolveOverlappingMode.JustifyAroundPoint);
                    break;
                case 3:
                    SetOverlappingMode(ResolveOverlappingMode.JustifyAllAroundPoint);
                    break;
                case 4:
                    SetOverlappingMode(ResolveOverlappingMode.Default);
                    break;
            }
        }

        private void SetOverlappingMode(ResolveOverlappingMode mode) {
            chartControl1.Series[0].Label.ResolveOverlappingMode = mode;
        }

    }
}