using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace KlientTCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            string host = Adres.Text;
            int port = System.Convert.ToInt32(Port_p.Value);  

            try
            {
                TcpClient klient = new TcpClient(host, port);

                listBox1.Items.Add("Nawiązano połączenie z " + host + " na porcie: " + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Błąd: Nie udało się nawiązać połączenia!");
                MessageBox.Show(ex.ToString(), "Błąd");

            }

        }

        private void Port_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
