using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Calculator;
using CalculatorApp.Model;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public string setExp { get; set; }
        public double setRes { get; set; }
        public string setLastExp { get; set; }

        string input = string.Empty; //Store user input

        double result = 0.0; //Get result

        public Form1()
        {
            InitializeComponent();
            txtResult.Enabled = false;

            textBox1.Text = "";
        }

        public Form1(string exp, double res, string lastExp) : this()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            input += ".";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "*";
            this.textBox1.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "/";
            this.textBox1.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "-";
            this.textBox1.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "+";
            this.textBox1.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            var parser = new ExpressionParser();

            try
            {
                Form2 obj = (Form2)Application.OpenForms["Form2"];

                if (obj != null)
                {
                    //Form2 obj = (Form2)Application.OpenForms["Form2"];
                    obj.Close();
                }

                txtResult.Text = parser.Execute(textBox1.Text).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "(";
            this.textBox1.Text += input;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ")";
            this.textBox1.Text += input;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "pi";
            this.textBox1.Text += input;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "^";
            this.textBox1.Text += input;
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        List<DataMem> aLst = new List<DataMem>();
        private void button23_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0 && textBox1.Text.Length > 0)
            {
                string exp = textBox1.Text;
                double val = Convert.ToDouble(txtResult.Text);

                DataMem obj = new DataMem();

                bool found = aLst.Any(c => c.Expression == exp && c.Result == val);

                if (found == false)
                {
                    obj.Expression = this.textBox1.Text;
                    obj.Result = Convert.ToDouble(txtResult.Text);

                    aLst.Add(obj);
                }
            }
            else
            {
                MessageBox.Show("Make sure expression and results are there!");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if(aLst.Count > 0)
            {
                Form2 frm = new Form2(aLst, input);
                frm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
