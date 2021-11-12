using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webservice.WebServiceSoapClient client = new webservice.WebServiceSoapClient();

            /*webservice.CPays[] tmp = client.GetAllPays();
            foreach(webservice.CPays p in tmp)
            {
                textBox1.Text += "\r\n" + p.Id + " - " + p.Nom;
            }*/

            client.GetAllPaysCompleted += Client_GetAllPaysCompleted;
            client.GetAllPaysAsync();
        }

        private void Client_GetAllPaysCompleted(object sender, webservice.GetAllPaysCompletedEventArgs e)
        {
            foreach (webservice.CPays p in e.Result)
            {
                textBox1.Text += "\r\n" + p.Id + " - " + p.Nom;
            }
        }
    }
}

