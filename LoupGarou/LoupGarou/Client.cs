using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{
    public class Client
    {
        Socket leSocket;
        IPEndPoint leIPEP;
        TextReader leTR;
        TextWriter leTW;
        Thread leTread;
        string lAdresseS;
        string lAdresseC;
        int lePortS;
        Plateforme laPlatforme;
        string leLogin;
        public Client(string adresseS, int portS, string login)
        {
            leSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            leIPEP = new IPEndPoint(IPAddress.Parse(adresseS), portS);
            leSocket.Connect(leIPEP);
        }

        public void Run()
        {
            NetworkStream leNS = new NetworkStream(leSocket);
            leTR = new StreamReader(leNS);
            leTW = new StreamWriter(leNS);

            leTread = new Thread(EcouteReponse);
            leTread.Start();
        }
        public void EcouteReponse()
        {
            while (true)
            {
                string leMessageObtenu = leTR.ReadLine();
                MessageBox.Show("Le message obtenu est :" + leMessageObtenu);
                leTW.WriteLine("OK");
                leTW.Flush();
            }
        }
    }
}