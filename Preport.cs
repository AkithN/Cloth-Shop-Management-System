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
    public partial class Preport : Form
    {
        public Preport()
        {
            InitializeComponent();
        }

        private void Preport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"C:\Users\AKITH\Desktop\CW\Course Work GAD\Course Work GAD\Course Work GAD\Course Work GAD\CrystalReport1.rpt";
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
