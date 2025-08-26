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
using System.Data.SqlClient;

namespace spamangement
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spamanDataSet6.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.spamanDataSet6.login);
            // TODO: This line of code loads data into the 'spamanDataSet3.reviews' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.spamanDataSet4.customer);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into customer values(@procname,@day,@cost,@customername)", con);
                cmd.Parameters.AddWithValue("@procname", textBox2.Text);
                cmd.Parameters.AddWithValue("@customername", textBox4.Text);
                cmd.Parameters.AddWithValue("@day", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@cost", int.Parse(textBox3.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                if (MessageBox.Show("Added successfully") == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox4.Clear();
                }
            }
            else
            {
                MessageBox.Show("Do not enter booking id");
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from customer where bookid=@bookid", con);
            cmd.Parameters.AddWithValue("@bookid", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            if (MessageBox.Show("Deleted successfully") == DialogResult.OK)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update customer set procname=@procname,day=@day,cost=@cost ,customername=@customername where bookid=@bookid", con);
            cmd.Parameters.AddWithValue("@bookid", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@procname", textBox2.Text);
            cmd.Parameters.AddWithValue("@day", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@customername", textBox4.Text);
            cmd.Parameters.AddWithValue("@cost", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            con.Close();
           if( MessageBox.Show("Updated successfully")==DialogResult.OK)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
