using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{
    public partial class Plateforme : Form
    {
        public Plateforme()
        {
            Thread leTread = new Thread(new ThreadStart(CommunicationServer));
            leTread.Start();
        }



        public void CommunicationServer()
        {
            Server l = new Server(this, "127.0.0.1", 2021);
            l.Run();
        }

        private void Plateforme_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void tb_AdresseSRS_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
