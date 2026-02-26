using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryMatchingGame
{
    public partial class Form3 : Form
    {
        

        public Form3(int c)
        {
            InitializeComponent();
            label1.Text = c.ToString();
        }

        int c2 = 0;
       
        private void Form3_Load(object sender, EventArgs e)
        {

            c2 = Convert.ToInt32(label1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "fruct") c2++;
            if (textBox2.Text == "rosia") c2++;
            if (textBox3.Text == "banana") c2++;
            if (c2>=5) pictureBox14.Visible = true;
            label19.Visible = true;
            label19.Text = "Ai obtinut " + c2 + " puncte";
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
            label13.Visible = true;
            label2.Visible = true;



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
            this.Hide();

        }
    }
}
