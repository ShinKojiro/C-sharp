using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_C_sharp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = "Type Here";

            //focus ==> Select() or Focus()
            txtInput.Select();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //formatting: f (float), n (number), p (percentages), c (currency)
            double input = Convert.ToDouble(txtInput.Text);
            lblOutput.Text = input.ToString("c");

            MessageBox.Show("User Input: " + Environment.NewLine + input.ToString(), "Input", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            txtInput.Text = "Type Here";
            txtInput.Focus();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            char userInput = Convert.ToChar(txtInput.Text);
            

            switch (userInput)
            {
                case 'A':
                case 'a':
                    lblOutput.Text = "Perfect Score!";
                    break;
                case 'f':
                    lblOutput.Text = "Too Bad!";
                    break;
                default:
                    lblOutput.Text = "Not expected";
                    break;
            }
        }
    }
}
