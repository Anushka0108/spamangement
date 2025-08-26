using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace spamangement
{
    public partial class Form8 : Form
    {
        public Form8(string username)
        {
            InitializeComponent();
            textBox2.Text = username;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into reviews values(@name,@facility,@comment)", con);
            cmd.Parameters.AddWithValue("@facility",comboBox1.Text);
            cmd.Parameters.AddWithValue("@name",textBox2.Text);
            cmd.Parameters.AddWithValue("@comment",textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            if(MessageBox.Show("Added Successfully") == DialogResult.OK)
            {
                Form6 Check = new Form6(textBox2.Text);
                Check.Show();
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
