using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Client
    {
        Socket leSocket;
        IPEndPoint leIPEP;
        TextReader leTR;
        TextWriter leTW;
        string lAdresseS;
        string lAdresseC;
        int lePortS;
        Plateforme laPlateforme;
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

            Thread leThread = new Thread(EcouteReponse);
            leThread.Start();
        }

        public void EcouteReponse()
        {
            while(true)
            {
                string leMessageObtenu = leTR.ReadLine();
                leTW.WriteLine("Le message obtenu est :" + leMessageObtenu);
                leTW.Flush();
            }
        }
        
    }
}
