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
    public partial class Areport : Form
    {
        public Areport()
        {
            InitializeComponent();
        }

        private void Areport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer3.ReportSource = @"C:\Users\AKITH\Desktop\CW\Course Work GAD\Course Work GAD\Course Work GAD\Course Work GAD\CrystalReport3.rpt";
        }
    }
}
