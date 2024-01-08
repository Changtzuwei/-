using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "0";
            label2.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += '.';
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.Substring(0, 1) == "-")
                {
                    textBox1.Text = textBox1.Text.Substring(1, textBox1.Text.Length - 1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text == "O")
            {
                label1.Text = "+";
                label2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else
            {
                label2.Text = Compute(label1.Text, label2.Text, textBox1.Text).ToString();
                textBox1.Text = "";
                label1.Text = "+";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text == "O")
            {
                label1.Text = "-";
                label2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else
            {
                label2.Text = Compute(label1.Text, label2.Text, textBox1.Text).ToString();
                textBox1.Text = "";
                label1.Text = "-";

            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text == "O")
            {
                label1.Text = "*";
                label2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else
            {
                label2.Text = Compute(label1.Text, label2.Text, textBox1.Text).ToString();
                textBox1.Text = "";
                label1.Text = "*";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text == "O")
            {
                label1.Text = "/";
                label2.Text = textBox1.Text;
                textBox1.Text = "";
            }
            else
            {
                label2.Text = Compute(label1.Text, label2.Text, textBox1.Text).ToString();
                textBox1.Text = "";
                label1.Text = "/";
            }
        }

        private double Compute(string o, string a, string b)
        {
            double n = double.Parse(a);
            double m = double.Parse(b);
            if (o == "+")
            {
                return n + m;
            }
            else if (o == "-")
            {
                return n - m;
            }
            else if (o == "*")
            {
                return n * m;
            }
            else if (o == "/")
            {
                return (n / m);
            }
            else { return 0; }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label1.Text != "O")
            {
                textBox1.Text = Compute(label1.Text, label2.Text, textBox1.Text).ToString();
                label1.Text = "O";
                label2.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double z = double.Parse(textBox1.Text);
            textBox1.Text = Math.Pow(z, 0.5).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double f = double.Parse(textBox1.Text);
            textBox1.Text = Math.Pow(f,2).ToString();
        }
    }
}