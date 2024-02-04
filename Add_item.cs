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
using System.Xml;

namespace Course_Work_GAD
{
    public partial class Add_item : Form
    {
        String imageUrl = null;
        SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=CLSHOP;Integrated Security=True");
        public Add_item()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Update item= new Update();
            item.Show();
            this.Hide();
        }

        private void btn_removeS_Click(object sender, EventArgs e)
        {
            Remove item = new Remove();
            item.Show();
            this.Hide();
        }

        private void lbl_pname_Click(object sender, EventArgs e)
        {

        }

        private void btn_iback_Click(object sender, EventArgs e)
        {
            Admin_login iback= new Admin_login();
            iback.Show();
            this.Hide();
        }

        private void btn_iclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img =pictureBox1.Image;
            byte[] arr;
            ImageConverter converter= new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            
            con.Open();

            //Create a command
            String save_sql = "INSERT INTO tblitem(name,icode,category,qty,price,Photo,photoUrl)" + "VALUES(@name,@icode,@category,@qty,@price,@Photo,@photoUrl)"; 
            SqlCommand com = new SqlCommand(save_sql, con);
            com.Parameters.AddWithValue("@name", this.txt_pname.Text);
            com.Parameters.AddWithValue("@icode", this.txt_pno.Text);
            com.Parameters.AddWithValue("@category", this.cmb_category.Text);
            com.Parameters.AddWithValue("@qty", this.numericUpDown_qty.Text);
            com.Parameters.AddWithValue("@price", this.txt_price.Text);
            com.Parameters.AddWithValue("@Photo", arr);
            com.Parameters.AddWithValue("@PhotoUrl", imageUrl);

            //Execute command
            int ret = com.ExecuteNonQuery();
            MessageBox.Show("No of records inserted: " + ret, "Information");

               


            //Disconnect
            con.Close();

        }

        private void btnviwe_Click(object sender, EventArgs e)
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


            this.dataGridView1.DataSource = ds.Tables[0];


            //disconnect from the server
            con.Close();
        }

        private void Add_item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cLSHOPDataSet.tblitem' table. You can move, or remove it, as needed.
            this.tblitemTableAdapter.Fill(this.cLSHOPDataSet.tblitem);

        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl= ofd.FileName;
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                  }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
