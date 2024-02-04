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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sing_in enter = new Sing_in();
            enter.Show();
            this.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Admin_login enter = new Admin_login();
            enter.Show();
            this.Hide();
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            Manager_login enter = new Manager_login();
            enter.Show();
            this.Hide();
        }

        private void btn_wclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
