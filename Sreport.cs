using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_GAD
{
    public partial class Sreport : Form
    {
        public Sreport()
        {
            InitializeComponent();
        }

        private void Sreport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer2.ReportSource = @"C:\Users\AKITH\Desktop\CW\Course Work GAD\Course Work GAD\Course Work GAD\Course Work GAD\CrystalReport2.rpt";
        }
    }
}
