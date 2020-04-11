using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_C_Sharp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            int score = Convert.ToInt32(txtScore.Text);

            if((score <= 2400) ^ (score >= 2000))
            {
                lblOutput.Text = "Great Score!";
            }
            else
            {
                lblOutput.Text = "Oooo!";
            }
        }
    }
}
