using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace MemoryMatchingGame
{

    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Zmeura.rtf");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Afinele.rtf");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Lamaile.rtf");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Ananasul.rtf");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Avocado.rtf");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Capsunile.rtf");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Kiwi.rtf");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Mango.rtf");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Merele.rtf");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Portocalele.rtf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new GameWindow();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        { int c = 0;

            if (radioButton2.Checked == true) c++;
            if (radioButton4.Checked == true) c++;
            if (radioButton7.Checked == true) c++;

            
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int c = 0;

            if (radioButton2.Checked == true) c++;
            if (radioButton4.Checked == true) c++;
            if (radioButton7.Checked == true) c++;

            
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        { int c = 0;

            if (radioButton2.Checked == true) c++;
            if (radioButton4.Checked == true) c++;
            if (radioButton7.Checked == true) c++;
            if (radioButton10.Checked == true) c++;
            if (radioButton14.Checked == true) c++;
            if (radioButton18.Checked == true) c++;
          

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label11.Visible = true;
            label13.Visible = true;
          


        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pictureBox19_Click(object sender, EventArgs e)
        {

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "yeet.wav";
            player.Play();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Afinele.rtf");
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Avocado.rtf");
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Merele.rtf");
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Lamaile.rtf");
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Ananasul.rtf");
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Kiwi.rtf");
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Portocalele.rtf");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Zmeura.rtf");
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Mango.rtf");
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Capsunile.rtf");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f1 = new GameWindow();
            f1.Show();
            this.Hide();
        }
        int c = 0;
        private void button2_Click_2(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked == true) c++; //2 4 7 10 14 18
            if (radioButton4.Checked == true) c++;
            if (radioButton7.Checked == true) c++;
            if (radioButton10.Checked == true) c++;
            if (radioButton14.Checked == true) c++;
            if (radioButton18.Checked == true) c++;
       

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label11.Visible = true;
            label13.Visible = true;

           

        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox19_Click_1(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "yeet.wav";
            player.Play();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true) c++; //2 4 7 10 14 18
            if (radioButton4.Checked == true) c++;
            if (radioButton7.Checked == true) c++;
            if (radioButton10.Checked == true) c++;
            if (radioButton14.Checked == true) c++;
            if (radioButton18.Checked == true) c++;
            






            Form3 frm2 = new Form3(c);
            frm2.Show();
            this.Hide();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
