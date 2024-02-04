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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btn_uclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_uback_Click(object sender, EventArgs e)
        {
            Add_item back= new Add_item();
            back.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

                //Create a connection with MS SQL Server
                string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //Create a command
                String update_sql = "UPDATE tblitem SET name=@name,icode=@icode,category=@category,qty=@qty,price=@price WHERE icode=@icode";
                SqlCommand com = new SqlCommand(update_sql, con);
                com.Parameters.AddWithValue("@name", this.txt_upname.Text);
                com.Parameters.AddWithValue("@icode", this.txt_upno.Text);
                com.Parameters.AddWithValue("@category", this.cmb_ucategory.Text);
                com.Parameters.AddWithValue("@qty", this.numericUpDown_uqty.Text);
                com.Parameters.AddWithValue("@price", this.txt_uprice.Text);

                //Execute command
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records updated: " + ret, "Information");

                //Disconnect
                con.Close();

          
        }
    }
}
