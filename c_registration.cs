using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_GAD
{
    public partial class c_registration : Form
    {
        public c_registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Sing_in backsign = new Sing_in();
            backsign.Show();
            this.Hide();
        }

        private void btn_create_Click(object sender, EventArgs e)
        { 
        

       
            if (string.IsNullOrEmpty(txtname.Text))
            {
               MessageBox.Show(this, "Name can not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
            }
            if (txtname.Text.Any(char.IsDigit))
            {
                MessageBox.Show(this, "First Name cannot have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
            }
            else if (txtemail.Text.Length == 0)
            {
                MessageBox.Show(this, "Please Enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
            }

            else if (!Regex.IsMatch(txtemail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show(this, "Enter a valid email. Ex:name@gmail.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
            }
            else if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show(this, "Select Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else if (string.IsNullOrEmpty(txtun.Text))
            {
                MessageBox.Show(this, "Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtun.Focus();
            }
            else if (string.IsNullOrEmpty(txtpw.Text))
            {
                MessageBox.Show(this, "Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpw.Focus();
            }
            else if (string.IsNullOrEmpty(txtcpw.Text))
            {
                MessageBox.Show(this, "Enter Confirm Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcpw.Focus();
            }
            


            else if (txtpw.Text != txtcpw.Text)
            {
                this.lbl_msg.Text = "Did not match password";

            }
            else if(this.checkBox1.Checked == false)
            {
                this.label9.Text = "Please Prove you are not a robot";
            }
            else
            {
                
                string cs = "Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                //create a command
                string save_sql = "INSERT INTO tblcustomer(name,bday,email,uname,pword,gender)" + "VALUES(@name,@bday,@email,@uname,@pword,@gender)";
                SqlCommand com = new SqlCommand(save_sql, con);
                com.Parameters.AddWithValue("@name", this.txtname.Text);
                com.Parameters.AddWithValue("@bday", this.dateTimePicker1.Text);
                com.Parameters.AddWithValue("@email", this.txtemail.Text);
                com.Parameters.AddWithValue("@uname", this.txtun.Text);
                com.Parameters.AddWithValue("@pword", this.txtpw.Text);
                com.Parameters.AddWithValue("@gender", this.comboBox1.Text);



                //execute a command
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("Account Created : " + ret, "Information");

                //disconnect
                con.Close();
            }

        }

        private void btn_wclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void c_registration_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtcpw_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
