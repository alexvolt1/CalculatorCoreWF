using Calculator.Processor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCoreWF
{
    public partial class Form1 : Form
    {
        private string tempValue;
        private double result;
        ICalculationsProcessor processor;
        public string TempValue
        {
            get
            {
                return tempValue;
            }
            set
            {
                tempValue = value;
                labelResult.Text = value;
            }
        }

        public double Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                label1.Text = value.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
            processor = new CalculationsProcessor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempValue += button1.Text;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (TempValue!=null)
            {
                if (!TempValue.Contains("."))
                {
                    TempValue += buttonDot.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TempValue += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TempValue += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TempValue += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TempValue += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TempValue += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TempValue += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TempValue += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TempValue += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (TempValue!=null)
            {
                TempValue += button0.Text;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int i = 0;
            processor.AddMethod(TempValue, i);
            Result = processor.TempResult;
            TempValue = null;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {

        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
