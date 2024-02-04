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
    public partial class manage_users : Form
    {
        DataSet ds;
        public manage_users()
        {
            InitializeComponent();
        }

        private void btn_reback_Click(object sender, EventArgs e)
        {
            Manager_login backmli = new Manager_login();
            backmli.Show();
            this.Hide();
        }

        private void btn_muclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create a connection with ms sql server
            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //create a command
            string sql = "SELECT * FROM tblcustomer";
            SqlCommand com = new SqlCommand(sql, con);

            //execute 
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];


            //disconnect from the server
            con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            //create a connection with ms sql server
            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //create a command
            string delete_sql = "DELETE FROM tblcustomer WHERE name=@name";
            SqlCommand com = new SqlCommand(delete_sql, con);
            com.Parameters.AddWithValue("@name", this.txt_dcn.Text);



            //execute a command
            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records deleted : " + ret, "Information");

            //disconnect
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //create a connection with ms sql server
            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //create a command
            string sql = "SELECT * FROM tbladmin";
            SqlCommand com = new SqlCommand(sql, con);

            //execute 
            SqlDataAdapter dap = new SqlDataAdapter(com);
            ds = new DataSet();
            dap.Fill(ds);

            this.dataGridView1.DataSource = ds.Tables[0];


            //disconnect from the server
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //create a connection with ms sql server
            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //create a command
            string delete_sql = "DELETE FROM tbladmin WHERE auname=@auname";
            SqlCommand com = new SqlCommand(delete_sql, con);
            com.Parameters.AddWithValue("@auname", this.txt_dan.Text);



            //execute a command
            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records deleted : " + ret, "Information");

            //disconnect
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            add_admin add= new add_admin();
            add.Show();
            this.Hide();
        }

        private void btn_preport_Click(object sender, EventArgs e)
        {
           Preport add = new Preport();
            add.Show();
           
        }

        private void btn_creport_Click(object sender, EventArgs e)
        {
            Sreport add = new Sreport();
            add.Show();
            
        }

        private void btn_areport_Click(object sender, EventArgs e)
        {
            Areport add = new Areport();
            add.Show();
            
        }
    }
}
