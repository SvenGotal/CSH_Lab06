using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSH_Lab06
{
    public partial class Greska : UserControl
    {

        public event delegat fail;

        public Greska()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fail("User not found"); 
        }
        public string SetLabelText
        {
            set
            {
                label1.Text = value;
            }
        }
    }
}
