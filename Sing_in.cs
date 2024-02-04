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
    public partial class Sing_in : Form
    {
        public Sing_in()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //connection

            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //command

            string sql = "SELECT * FROM tblcustomer where uname=@uname AND pword=@pword";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@uname", this.txt_un.Text);
            com.Parameters.AddWithValue("@pword", this.txt_pw.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                //valid un and pw
                Buy home = new Buy();
                home.Show();
                this.Hide();
            }
            else
            {
                //invalid un and pw
                this.lbl_msg.Text = "invalid user name or password";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            c_registration regi = new c_registration();
            regi.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            welcome back = new welcome();
            back.Show();
            this.Hide();
        }

        private void Sing_in_Load(object sender, EventArgs e)
        {

        }
    }
}
