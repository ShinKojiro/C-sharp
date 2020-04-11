using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_C_sharp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string myString = "Hello World!";

            //String functions
            //Length ==> returns number of characters in string
            //toUpper() ==> converters all characters in string to upper case
            //toLower() ==> "" to lower case
            //indexOf("". otional starting point) ==> returns index of first occorance of character or string
            //replace("", "") ==> Replaces all occurances of either char or string with other char or string

            lblOutput.Text = myString.Replace('l', 'g').ToString();
        }
    }
}
