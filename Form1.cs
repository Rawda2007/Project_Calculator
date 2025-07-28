using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        { 
            //textBox1.Text += "=";
         
            string expression = textBox1.Text.ToLower();


            try
            {
                string input = textBox1.Text.ToLower();

                // نحسب أي دالة sin/cos/tan
                input = Regex.Replace(input, @"sin\(([^)]+)\)", match =>
                {
                    double angle = double.Parse(match.Groups[1].Value);
                    double rad = angle * Math.PI / 180;
                    return Math.Sin(rad).ToString();
                });

                input = Regex.Replace(input, @"cos\(([^)]+)\)", match =>
                {
                    double angle = double.Parse(match.Groups[1].Value);
                    double rad = angle * Math.PI / 180;
                    return Math.Cos(rad).ToString();
                });

                input = Regex.Replace(input, @"tan\(([^)]+)\)", match =>
                {
                    double angle = double.Parse(match.Groups[1].Value);
                    double rad = angle * Math.PI / 180;
                    return Math.Tan(rad).ToString();
                });

                // بعد استبدال الدوال، نحسب المعادلة العادية
                var result = new DataTable().Compute(input, null);
                textBox1.Text += "= " + result.ToString();
            }
            catch
            {
                textBox1.Text = "Invalid!";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "sin(";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text += "*";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text += ")";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text += "/";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text += "-";

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text += "+";


        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            textBox1.Text += "cos(";

        }
        private void tan_Click(object sender, EventArgs e)
        {
            textBox1.Text += "tan(";

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string Text;
            if (textBox1.Text.EndsWith("sin(")|| textBox1.Text.EndsWith("tan(") || textBox1.Text.EndsWith("cos(") )
                {
                 Text = textBox1.Text.Substring(0, textBox1.Text.Length - 4);

            }
            else
                Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            textBox1.Text = Text;
        }
    }
}
