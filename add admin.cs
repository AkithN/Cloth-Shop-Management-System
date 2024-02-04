using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Course_Work_GAD
{
    public partial class add_admin : Form
    {
        public add_admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create a connection with ms sql server
            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //create a command
            string save_sql = "INSERT INTO tbladmin(auname,apword)" + "VALUES(@auname,@apword)";
            SqlCommand com = new SqlCommand(save_sql, con);
            com.Parameters.AddWithValue("@auname", this.txt_aan.Text);
            com.Parameters.AddWithValue("@apword", this.txt_aap.Text);

            
            
               

            //execute a command
            int ret = com.ExecuteNonQuery();
            MessageBox.Show("Add Admin : " + ret, "Information");

            //disconnect
            con.Close();
        }

        private void btn_uback_Click(object sender, EventArgs e)
        {
            manage_users backmu = new manage_users();
            backmu.Show();
            this.Hide();
        }

        private void lbl_dcn_Click(object sender, EventArgs e)
        {

        }
    }
}
