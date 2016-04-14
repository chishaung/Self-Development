using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Hiragana
{
    public partial class Form1 : Form
    {
        private int start = 0;
        private int end = 95;
        private int test_loop = 0; 
        private bool Hiragana = false;
        private bool Katagana = false;
        private string[] c = { "a", "i", "u", "e", "o",
                               "ka", "ki", "ku", "ke", "ko",
                               "sa", "shi", "su", "se", "so",
                               "ta", "chi", "tsu", "te", "to",
                               "na", "ni", "nu", "ne", "no",
                               "ha", "hi", "fu", "he", "ho",
                               "ma", "mi", "mu", "me", "mo",
                               "ya", "yu","yo",
                               "ra", "ri", "ru", "re", "ro",
                               "wa", "wi", "ww", "wo",
                               "n",
                               "a", "i", "u", "e", "o",
                               "ka", "ki", "ku", "ke", "ko",
                               "sa", "shi", "su", "se", "so",
                               "ta", "chi", "tsu", "te", "to",
                               "na", "ni", "nu", "ne", "no",
                               "ha", "hi", "fu", "he", "ho",
                               "ma", "mi", "mu", "me", "mo",
                               "ya", "yu","yo",
                               "ra", "ri", "ru", "re", "ro",
                               "wa", "wi", "ww", "wo",
                               "n"
                              };
        private int index;

        public void Setrange() {
            if (Hiragana == true && Katagana == true) { start = 0; end = 95; }
            else if (Hiragana == false && Katagana == false) { start = 0; end = 95; }
            else if (Hiragana == true && Katagana == false) { start = 0; end = 47; }
            else if (Hiragana == false && Katagana == true) { start = 48; end = 95; }
        }

        public Form1()
        {
            InitializeComponent();
            Random Rnd = new Random();
            index = Rnd.Next(start, end);
            pictureBox1.Image = imageList1.Images[index];
            label2.Text = "";

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Next
        private void button1_Click(object sender, EventArgs e)
        {
            
            Random Rnd = new Random();
            index = Rnd.Next(start, end);
            pictureBox1.Image = imageList1.Images[index];
            label2.Text = "";
            test_loop++;
        }

        // Check
        private void Check_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == c[index])
            {
                label2.Text = c[index];
                label1.Text = "Right";
                label1.ForeColor = System.Drawing.Color.Green;
            }


            else
            {
                label2.Text = c[index];
                label1.Text = "Wrong";
                label1.ForeColor = System.Drawing.Color.Red;
            }
            
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { Hiragana = true; checkBox1.ForeColor = System.Drawing.Color.Green; }
            else { Hiragana = false; checkBox1.ForeColor = System.Drawing.Color.Black; }
            Setrange();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked) { Katagana = true; checkBox2.ForeColor = System.Drawing.Color.Green; }
            else { Katagana = false; checkBox2.ForeColor = System.Drawing.Color.Black; }
            Setrange();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("@Author: Chihsiang\n@Email: wang0162@vandals.uidaho.edu", "If you really want to know...", MessageBoxButtons.OK);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void hiraganaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void kataganaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }
    }
}
