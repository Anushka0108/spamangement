using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spamangement
{
    public partial class Form4 : Form
    {
        public Form4(String Username)
        {
            InitializeComponent();
            label5.Text= Username;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.Height = 42;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel1.Height == 299)
            {
                panel1.Height = 42;
            }
            else
            {
                panel1.Height = 299;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 Check = new Form3(label5.Text);
            Check.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 Check = new Form5(label5.Text);
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 Check = new Form7("Pedicure", "1000",label5.Text);
            Check.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 Check = new Form7("Manicure", "1000",label5.Text);
            Check.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Check = new Form6(label5.Text);
            Check.Show();   
            Hide(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 Check = new Form8(label5.Text);
            Check.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form10 Check = new Form10(label5.Text);
            Check.Show();
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            Hide();
        }
    }
}
