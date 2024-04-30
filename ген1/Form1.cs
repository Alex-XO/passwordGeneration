using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passwordGeneration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contexExitBtn(object sender, EventArgs e)
        {
        
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        int k;
        public void button1_Click(object sender, EventArgs e)
        {
            var length = Convert.ToInt32(textBox1.Text);

            var useSymvols = new List<int>();

            

            if (checkBox1.Checked)
            {
                useSymvols.Add(1);
                k++;
            }

            if (checkBox2.Checked)
            {
                useSymvols.Add(2);
                k++;
            }

            if (checkBox3.Checked)
            {
                useSymvols.Add(3);
                k++;
            }

            if (checkBox4.Checked)
            {
                useSymvols.Add(4);
                k++;
            }

            textBox2.Text = generatePassword(length, useSymvols);

            if ((k == 4) && (length >= 8))
            {
                textBox3.Text = "Very reliable";
            }
            else if ((k < 4) && (length >= 8))
            {
                textBox3.Text = "Reliable";
            }
            else
            {
                textBox3.Text = "Unreliable";
            }
        }
        static string generatePassword(int length, List<int> useSymvols)

        {


            StringBuilder sb = new StringBuilder();

            Random rnd = new Random();

            int i = 0;

            while (i < length)

            {
                var currentCheckBox = useSymvols[rnd.Next(0, useSymvols.Count())];

                switch (currentCheckBox)
                {
                    case 1:
                        {
                            sb.Append((char)rnd.Next(0x41, 0x5A));
                            break;
                        }
                    case 2:
                        {
                            sb.Append((char)rnd.Next(0x61, 0x7A));
                            break;
                        }
                    case 3:
                        {
                            string specSymvol = "!@#$%^&*_+'\")(?/";
                            sb.Append(specSymvol[rnd.Next(0, specSymvol.Length)]);
                            break;
                        }
                    case 4:
                        {
                            sb.Append(rnd.Next(0, 10));
                            break;
                        }
                }

                i++;

            }

            return sb.ToString();

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
