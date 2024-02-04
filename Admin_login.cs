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

namespace Course_Work_GAD
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_aclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aback_Click(object sender, EventArgs e)
        {
            welcome back = new welcome();
            back.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //connection

            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //command

            string sql = "SELECT * FROM tbladmin where auname=@auname AND apword=@apword";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@auname", this.txt_un.Text);
            com.Parameters.AddWithValue("@apword", this.txt_pw.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                //valid un and pw
                Add_item home = new Add_item();
                home.Show();
                this.Hide();
            }
            else
            {
                //invalid un and pw
                this.lbl_msg.Text = "invalid user name or password";
            }
        }
    }
}
