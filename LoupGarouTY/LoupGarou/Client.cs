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
        public Socket leSocket;
        public IPEndPoint leIPEP;
        public TextReader leTR;
        public TextWriter leTW;
        public NetworkStream leNS;
        public string lAdresseS;
        public string lAdresseC;
        public int lePortS;
        public Plateforme laPlateforme;
        public string leLogin;
        public int numero = 0;
        
        //Constructeur pour les tests en mode console
        public Client(int num)
        {
            this.numero = num;
        }

        //Constructeur A partir de la plateforme
        public Client(string adresseS, int port, string adresseC, int num = 0, Plateforme laPlateforme = null)
        {
            
                this.numero = num;
                this.lAdresseS = adresseS;
                this.lAdresseC = adresseC;
                this.lePortS = port;
                this.laPlateforme = laPlateforme;
                this.leSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.leIPEP = new IPEndPoint(IPAddress.Parse(adresseS), port);
                this.leSocket.Connect(leIPEP);
                leNS = new NetworkStream(this.leSocket);
                leTR = new StreamReader(this.leNS);
                leTW = new StreamWriter(this.leNS);
        }

        //Constructeur pour le client
        public Client(string adresseS, string adresseC, int num, TextReader TR, TextWriter TW)
        {
            this.lAdresseS = adresseS;
            this.lAdresseC = adresseC;
            this.numero = num;
            this.leTR = TR;
            this.leTW = TW;
        }
        
        public void Run()
        {
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
