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
    public partial class Buy : Form
    {
        double total;
        double price;
        double qty;
        double finalbill;
        public Buy()
        {
            InitializeComponent();
        }

        private void btnc_logout_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnc_logout_Click_1(object sender, EventArgs e)
        {
            Sing_in logout = new Sing_in();
            logout.Show();
            this.Hide();
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Create a connection with MS SQL Server
            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //Create a command
            String sql = "SELECT icode,name,category,price,Photo FROM tblitem WHERE icode = @icode";
            SqlCommand com = new SqlCommand(sql, con);
            com.Parameters.AddWithValue("@icode", this.textBox4.Text);

            //Execute the command
            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                //Bind data with Controls
                this.textBox2.Text = dr.GetValue(0).ToString();
                this.textBox3.Text = dr.GetValue(1).ToString();
                this.textBox5.Text = dr.GetValue(2).ToString();
                this.textBox6.Text = dr.GetValue(3).ToString();
               
            }
            else
            {
                MessageBox.Show("No records found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Disconnect from the server
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //create a connection with ms sql server
            string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            //create a command
            string sql = "SELECT * FROM tblitem";
            SqlCommand com = new SqlCommand(sql, con);

            //execute 
            SqlDataAdapter dap = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            dap.Fill(ds);

            //bind data with controls


            this.dataadp.DataSource = ds.Tables[0];


            //disconnect from the server
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if(this.checkBox1.Checked== true)
            {
                price = Convert.ToDouble(this.textBox6.Text);
                qty = Convert.ToDouble(this.numericUpDown1.Text); 
                total = price* qty;
                finalbill = finalbill + total;
                finalbill = finalbill - (finalbill * 0.05);
                this.textBox1.Text = finalbill.ToString("C");

            }
            else
            {
                price = Convert.ToDouble(this.textBox6.Text);
                qty = Convert.ToDouble(this.numericUpDown1.Text);
                total = price * qty;
                finalbill = finalbill + total;

                this.textBox1.Text = finalbill.ToString("C");
            }
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox5.Clear();
            this.textBox6.Clear();  
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
