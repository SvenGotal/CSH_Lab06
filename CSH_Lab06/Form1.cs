using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSH_Lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            login1.LoginSuccessful += Login1_LoginSuccessful;
            login1.LoginFailed += Login1_LoginFailed;
            greska1.fail += Greska1_fail;
            bookView1.EndWork += BookView1_EndWork;
        }

        private void BookView1_EndWork(string message)
        {
            bookView1.Visible = false;
            login1.Visible = true;
        }

        private void Greska1_fail(string message)
        {
            greska1.Visible = false;
            login1.Visible = true;
        }

        private void Login1_LoginFailed(string message)
        {
            greska1.Visible = true;
            bookView1.Visible = false;
            greska1.SetLabelText = message;
        }

        private void Login1_LoginSuccessful(string message)
        {
            bookView1.Visible = true;
            greska1.Visible = false;
            login1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookView1.Visible = false;
            greska1.Visible = false;
        }
    }
}
