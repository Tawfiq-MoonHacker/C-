using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;


namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Red");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] words = textBox1.Text.Split(',');

            foreach (string word in words)
            {
                int startindex = 0;
                while (startindex < richTextBox1.TextLength)
                {
                    int wordstartIndex = richTextBox1.Find(word, startindex, RichTextBoxFinds.None);
                    if (wordstartIndex != -1)
                    {
                        richTextBox1.SelectionStart = wordstartIndex;
                        richTextBox1.SelectionLength = word.Length;
                        richTextBox1.SelectionBackColor = Color.Red;
                    }
                    else
                        break;
                    startindex += wordstartIndex + word.Length;
                }
            }
        }
        bool i = true;
        private void button3_Click(object sender, EventArgs e)
        {

            if (i)
            {
                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = Color.Yellow;
            }
            else
            {
                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectAll();
                richTextBox1.SelectionBackColor = Color.White;
            }
            i = !i;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //counting the words
            string s = text; 
            string[] words = s.Split(' ');
            label4.Text = ""+ (words.Length);

            //counting the char
            double countChar = 0.0;
            string[] character = s.Split();
            label5.Text = s.Length + " ";

            //counting the lines
            double x = s.Length;
            label6.Text = Convert.ToString(Math.Ceiling(x / 41));



        }
        string currentfont;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            if (comboBox1.SelectedIndex == 0){
                richTextBox1.SelectionFont = new Font("Tahoma",14);
                currentfont = "Tahoma";
            }
                if(comboBox1.SelectedIndex == 1)
            {
                richTextBox1.SelectionFont = new Font("Technic", 14);
                currentfont = "Technic";
            }
                if(comboBox1.SelectedIndex == 2)
            {
                richTextBox1.SelectionFont = new Font("TechnicBold", 14);
                currentfont = "TechnicBold";
            }
                if(comboBox1.SelectedIndex == 3)
            {
                richTextBox1.SelectionFont = new Font("TechnicLite", 14);
                currentfont = "TechnicLite";
            }
                if(comboBox1.SelectedIndex == 4)
            {
                richTextBox1.SelectionFont = new Font("AcadEref", 14);
                currentfont = "AcadEref";
            }
                if(comboBox1.SelectedIndex == 5)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 14);
                currentfont = "Times New Roman";
            }
        }
        string text = "";
        private void button4_Click(object sender, EventArgs e)
        {
            text += textBox2.Text;
            richTextBox1.AppendText(textBox2.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                richTextBox1.SelectionStart = 0;
                richTextBox1.SelectAll();
                richTextBox1.SelectionColor = Color.Black;
            }
            if(comboBox2.SelectedIndex == 1)
            {
                richTextBox1.SelectionColor = Color.Green;
            }
            if(comboBox2.SelectedItem == "Red")
            {
                richTextBox1.SelectionColor = Color.Red;
            }
            if(comboBox2.SelectedIndex == 2)
            {
                richTextBox1.SelectionColor = Color.Blue;
            }
            if(comboBox2.SelectedIndex == 3)
            {
                richTextBox1.SelectionColor = Color.Orange;
            }

        }
        int fontsize;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = 0;
            richTextBox1.SelectAll();
            if (comboBox3.SelectedIndex == (Convert.ToInt32(comboBox3.SelectedItem) - 8))
            {
                fontsize = Convert.ToInt32(comboBox3.SelectedItem);
                richTextBox1.Font = new Font(currentfont, fontsize);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string repTxt = text.Replace(textBox3.Text, textBox4.Text);
            richTextBox1.Clear();
            richTextBox1.AppendText(repTxt);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        string txtold;
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        string txtnew;
        public void textBox3_TextChanged(object sender, EventArgs e)
        {
            txtnew = textBox3.Text;
        }
    }
}
