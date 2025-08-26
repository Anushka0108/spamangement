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

namespace spamangement
{
    public partial class Form7 : Form
    {
        public Form7(string SourceForName,string cost,string username)
        {
            InitializeComponent();
            textBox3.Text=username;
            textBox1.Text= SourceForName;
            textBox2.Text= cost;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into customer values(@procname,@day,@cost,@customername)",con);
            cmd.Parameters.AddWithValue("@customername", textBox3.Text);
            cmd.Parameters.AddWithValue("@procname",textBox1.Text);
            cmd.Parameters.AddWithValue("@day",dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@cost", int.Parse(textBox2.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            if(MessageBox.Show("Booking successfull") == DialogResult.OK)
            {
                Form10 Check= new Form10(textBox3.Text);
                Check.Show();
                Hide();
            }
            
            
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
