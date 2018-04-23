using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QualitativeScaleCustomSortOrderSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #QualitativeScaleComparer
        private void OnLoad(object sender, EventArgs e) {
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if (diagram == null) return;
            diagram.AxisX.QualitativeScaleComparer = new NumberComparer();
        }
        #endregion #QualitativeScaleComparer
    }
}
