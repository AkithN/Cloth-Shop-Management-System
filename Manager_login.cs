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
    public partial class Manager_login : Form
    {
        public Manager_login()
        {
            InitializeComponent();
        }

        private void btn_mback_Click(object sender, EventArgs e)
        {
            welcome back = new welcome();
            back.Show();
            this.Hide();
        }

        private void btn_aclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mlogin_Click(object sender, EventArgs e)
        {
            //connection

            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //command

            string sql = "SELECT * FROM tblmanager where muname=@muname AND mpword=@mpword";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@muname", this.txt_mun.Text);
            com.Parameters.AddWithValue("@mpword", this.txt_mpw.Text);

            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                //valid un and pw
                manage_users home = new manage_users();
                home.Show();
                this.Hide();
            }
            else
            {
                //invalid un and pw
                this.lbl_msg.Text = "invalid user name or password";
            }
        }

        private void btn_mclose_Click(object sender, EventArgs e)
        {

        }

        private void Manager_login_Load(object sender, EventArgs e)
        {

        }
    }
}
