using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_C_sharp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            try
            {
                //declaring a variable
                //DataType nameOfVariable;

                /* Integer data types: int, unsigned int
                 * */

                int sampleVariable = 334;

                lblOutput.Text = sampleVariable.ToString();
            }
            catch
            {
                MessageBox.Show("This is the main text", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Convert.ToInt32(txtInput.Text);

                input += 5;

                lblOutput.Text = input.ToString();
            }
            catch
            {
                MessageBox.Show("This is not a number", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
