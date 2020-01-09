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
    public partial class BookView : UserControl
    {

        private XDocument popis;
        public event delegat EndWork;

        public BookView()
        {
            InitializeComponent();
            popis = XDocument.Load(@"C:\Users\esvegot\source\repos\CSH_Lab06\popisKnjiga.xml");

            var k = from y in popis.Descendants("knjiga")
                    select new
                    {
                        autor = y.Descendants("autor").First().Value,
                        naslov = y.Descendants("naslov").First().Value
                    };

            dataGridView1.DataSource = k.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EndWork("Thank you for using the library");
        }
    }
}
