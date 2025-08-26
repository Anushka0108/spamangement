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
using System.Drawing.Imaging;

namespace spamangement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Focus();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private bool isValid()
        {
            if(textBox1.Text==string.Empty|| textBox2.Text==string.Empty)
            {
                MessageBox.Show("Enter valid username and password");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "pass")
            {
                Form9 Check = new Form9();
                Check.Show();
                Hide();
            }
            else
            {

                if (isValid())
                {
                    using (SqlConnection con = new SqlConnection("Data Source=ANUSHKA;Initial Catalog=spaman;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
                    {
                        con.Open();
                        String Querry = "Select * from login where name=@name AND password=@password";
                        using (SqlCommand cmd = new SqlCommand(Querry, con))
                        {
                            cmd.Parameters.AddWithValue("@name", textBox1.Text);
                            cmd.Parameters.AddWithValue("@password", textBox2.Text);

                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dttable = new DataTable();
                            sda.Fill(dttable);
                            if (dttable.Rows.Count == 1)
                            {
                                Form3 Check = new Form3(textBox1.Text);
                                Check.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("The username or password entered was incorrect");
                                textBox1.Clear();
                                textBox2.Clear();
                            }
                        }
                    }
                }

            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form11 Check = new Form11();
            Check.Show();
            Hide();
        }
    }

   
}
