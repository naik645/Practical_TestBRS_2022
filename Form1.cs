using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Add_Employe
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R41C1ND\\SQLEXPRESS;Initial Catalog=H_R;User ID=sa;Password=admin123");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Employee values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + checkedListBox1.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + Convert.ToInt32(textBox4.Text) + "'," + Convert.ToInt32(textBox5.Text) + ",'" + textBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record inserted sucessfully...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R41C1ND\\SQLEXPRESS;Initial Catalog=H_R;User ID=sa;Password=admin123");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Employee", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
