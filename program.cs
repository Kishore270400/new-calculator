using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double data1, data2;
        string operations;
        public bool TextWasChanged = false;
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
                
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = ".";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = ".";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "0";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
               textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
            TextWasChanged = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "8";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
            TextWasChanged = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "7";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
            TextWasChanged = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "4";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
            TextWasChanged = true;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "5";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
            TextWasChanged = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
             if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "6";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
            TextWasChanged = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "1";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
            TextWasChanged = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "2";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
            TextWasChanged = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "3";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
            TextWasChanged = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            
            operations = "add";
            data1 = double.Parse(textBox1.Text);
            if (textBox2.ToString().EndsWith("+"))
            {
                if(TextWasChanged == true)
                {
                    data1 = data1 + double.Parse(textBox2.Text.ToString().Split('+')[0]);
                    textBox2.Text = data1.ToString() + "+";
                    textBox1.Text = data1.ToString();
                }
               
            }
            else
            {
                textBox2.Text = data1.ToString() + "+";

                textBox1.Clear();
                
            }
            
            textBox1.Focus();
            TextWasChanged = false;
        }

     
        

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            operations = "sub";
            data1 = double.Parse(textBox1.Text);
            if (textBox2.ToString().EndsWith("-"))
            {
                if (TextWasChanged == true)
                {
                    data1 = data1 + double.Parse(textBox2.Text.ToString().Split('-')[0]);
                    textBox2.Text = data1.ToString() + "-";
                    textBox1.Text = data1.ToString();
                }

            }
            else
            {
                textBox2.Text = data1.ToString() + "-";

                textBox1.Clear();

            }
           
            textBox1.Focus();
            TextWasChanged = false;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            operations = "mul";
            data1 = double.Parse(textBox1.Text);
            if (textBox2.ToString().EndsWith("*"))
            {
                if (TextWasChanged == true)
                {
                    data1 = data1 + double.Parse(textBox2.Text.ToString().Split('*')[0]);
                    textBox2.Text = data1.ToString() + "*";
                    textBox1.Text = data1.ToString();
                }

            }
            else
            {
                textBox2.Text = data1.ToString() + "*";

                textBox1.Clear();

            }

            textBox1.Focus();
            TextWasChanged = false;
        }
    
        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Clear();
            operations = null;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Clear();
            operations = null;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            operations = "div";
            data1 = double.Parse(textBox1.Text);
            if (textBox2.ToString().EndsWith("/"))
            {
                if (TextWasChanged == true)
                {
                    data1 = data1 + double.Parse(textBox2.Text.ToString().Split('/')[0]);
                    textBox2.Text = data1.ToString() + "/";
                    textBox1.Text = data1.ToString();
                }

            }
            else
            {
                textBox2.Text = data1.ToString() + "/";

                textBox1.Clear();

            }

            textBox1.Focus();
            TextWasChanged = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
       
             if (operations == "add")
             {
                if (textBox1.Text == "")
                {
                    textBox1.Text = data1.ToString();
                }
                 data2 = data1 + double.Parse(textBox1.Text);             
                 textBox2.Text = data1.ToString() + "+" + double.Parse(textBox1.Text) + "=";
                 textBox1.Text = data2.ToString();
             }
            if (operations == "sub")
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = data1.ToString();
                }
                data2 = data1 - double.Parse(textBox1.Text);
                textBox2.Text = data1.ToString() + "-" + double.Parse(textBox1.Text) + " = ";
                textBox1.Text = data2.ToString();
            }
            if (operations == "mul")
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = data1.ToString();
                }
                data2 = data1 * double.Parse(textBox1.Text);
                textBox2.Text = data1.ToString() + "*" + double.Parse(textBox1.Text) + " = ";
                textBox1.Text = data2.ToString();
            }
            if (operations == "div")
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = data1.ToString();
                }
                if (double.Parse(textBox1.Text) == 0)
                {
                    textBox2.Text = data1.ToString() + "/";
                    textBox1.Text = "cannot div zero";
                }
                else
                {
                    data2 = data1 / double.Parse(textBox1.Text);
                    textBox2.Text = data1.ToString() + "/" + double.Parse(textBox1.Text) + " = ";
                    textBox1.Text = data2.ToString();
                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            {
                data2 = double.Parse(textBox1.Text);
                data2 = data2 * -1;
                textBox1.Text = data2.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            var textBox = (System.Windows.Forms.TextBox)sender;
            string text = textBox.Text;
            int count = text.Count(c => c == '.');
            if (count > 1)
            {
                int lastIndex = text.LastIndexOf('.');
                textBox.Text = text.Substring(0, lastIndex) + text.Substring(lastIndex + 1);
            }

            {

                if (textBox1.Text.Length > 15)
                {
                    textBox1.Text = textBox1.Text.Substring(0, 15);
                }
               
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9.,-]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
           

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString().Contains("="))
            {
                textBox1.Text = "9";
                textBox2.Text = "";
            }
            else if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
            TextWasChanged = true;
        }

    }
}
