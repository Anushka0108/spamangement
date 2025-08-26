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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace spamangement
{
    public partial class Form10 : Form
    {
        public Form10(String username)
        {
            InitializeComponent();
            label5.Text= username;
            SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from customer where customername='"+username+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spamanDataSet2.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.spamanDataSet2.customer);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form3 Check = new Form3(label5.Text);
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "cancel appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete from customer where bookid=@bookid", con);
                cmd.Parameters.AddWithValue("@bookid", int.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();
                SqlCommand cma = new SqlCommand("Select * from customer where customername='" + label5.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cma);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            
        }
    }
}
