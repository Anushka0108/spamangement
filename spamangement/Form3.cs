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
    public partial class Form3 : Form
    {
        public Form3(String Username)
        {
            InitializeComponent();
            label4.Text = Username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Height==299)
            {
                panel1.Height = 42;
            }
            else
            {
                panel1.Height = 299;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Height = 42;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Check=new Form4(label4.Text);
            Check.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 Check=new Form5(label4.Text);
            Check.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 Check=new Form6(label4.Text);
            Check.Show();   
            Hide(); 
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form10 Check = new Form10(label4.Text);
            Check.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            Hide();
        }
    }
}
