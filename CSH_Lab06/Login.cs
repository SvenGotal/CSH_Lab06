using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSH_Lab06
{

    public delegate void delegat(string message);
    
    

    public partial class Login : UserControl
    {
        private XDocument korisnici;
        public event delegat LoginSuccessful;
        public event delegat LoginFailed;


        public Login()
        {

            InitializeComponent();
            korisnici = XDocument.Load(@"C:\Users\esvegot\source\repos\CSH_Lab06\CSH_Lab06\korisnici.xml");

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Boolean login = false;

            var k = from x in korisnici.Descendants("korisnik")
                    select new
                    {
                        korisnickoIme = x.Descendants("korisnickoIme").First().Value,
                        lozinka = x.Descendants("lozinka").First().Value
                    };

            foreach (var x in k)
            {
                if( textBoxUser.Text.Equals(x.korisnickoIme) && textBoxPass.Text.Equals(x.lozinka))
                {
                    login = true;
                }
            }

            if(login)
            {
                LoginSuccessful(textBoxUser.Text);
                textBoxUser.Text = "";
                textBoxPass.Text = "";

            }
            else if (textBoxUser.Text.Equals("") || textBoxPass.Text.Equals(""))
            {
                LoginFailed("Enter username and password");

            }
            else
            {
                LoginFailed("User not found");
            }
        }
    }
}
