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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace spamangement
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into login values(@name,@password)", con);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                if(MessageBox.Show("Registration successfull")==DialogResult.OK)
                {
                    Form2 Check = new Form2();
                    Check.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Try again");
                textBox1.Clear();
                textBox2.Clear();   
                textBox3.Clear();
            }
        }
    }
}
