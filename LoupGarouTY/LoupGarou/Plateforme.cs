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
            InitializeComponent();
            Thread leTread = new Thread(new ThreadStart(CommunicationClient));
            leTread.Start();
        }
        public void CommunicationClient()
        {
            Client l = new Client("192.168.1.179",2021,"de");
            l.Run();
        }
            private void Plateforme_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Tb_AdresseSRS_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_narration_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bt_Salle_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_PortCRs_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_leMessageR_TextChanged(object sender, EventArgs e)
        {
                    }

        private void RichTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
