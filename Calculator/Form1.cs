using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string Choice;
        int step_1_data;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
                Choice = "+";
                step_1_data = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
        }
        private void Minus_Click(object sender, EventArgs e)
        {
            try
            {
                Choice = "-";
                step_1_data = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        private void Multiplay_Click(object sender, EventArgs e)
        {
            Choice = "X";
            step_1_data = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
        }
    
    
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            Choice = " ";
            step_1_data = 0;
        }
    
      
        private void button5_Click(object sender, EventArgs e)
        {
            Choice_Selector();
        }


        /* Funtion To Perform The Operation*/
        private void Choice_Selector()
        {
            if (Choice == "+")
            {
                int Temp = Convert.ToInt32(textBox1.Text);
                int result = step_1_data + Temp;
                textBox1.Text = result.ToString();
            }
            else if (Choice == "-")
            {
                int Temp = Convert.ToInt32(textBox1.Text);
                int result = step_1_data - Temp;
                textBox1.Text = result.ToString();
            }
            else if (Choice == "X")
            {
                int Temp = Convert.ToInt32(textBox1.Text);
                int result = step_1_data * Temp;
                textBox1.Text = result.ToString();
            }
        }
        /*Calculaton Function Ending Here....*/
        
    }
}
