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
    public partial class Remove : Form
    {
        public Remove()
        {
            InitializeComponent();
        }

        private void btn_rback_Click(object sender, EventArgs e)
        {
            Add_item back = new Add_item();
            back.Show();
            this.Hide();
        }

        private void btn_rclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create a connection with MS SQL Server
            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Create a command
            String delete_sql = "DELETE FROM tblitem WHERE icode=@icode";

            SqlCommand com = new SqlCommand(delete_sql, con);
            com.Parameters.AddWithValue("@icode", this.txt_rpno.Text);
         

            //Execute command
            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records deleted: " + ret, "Information");

            //Disconnect
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
