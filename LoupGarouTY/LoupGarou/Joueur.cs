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
    public class Joueur : Client
    {
        public bool estActif = false;
        public bool estMort = false;
        public string leLogin;
        public int leNbreVote = 0;
        public Role leRole;

        //Constructeur pour le test en mode console
        public Joueur(string login, int num) : base(num)
        {
            this.leLogin = login;
        }
        //Constructeur pour le test avec la création du joueur provenant du serveur.
        public Joueur(string login, string lAdresseS, string lAdresseC, int num, TextReader leTR, TextWriter leTW) : base(lAdresseS, lAdresseC, num, leTR, leTW)
        {
            this.numero = num;
            this.leLogin = login;
        }

        //Constructeur pour la création du joueur provenant du client.
        public Joueur(string login, string lAdresseS, int lePortS, string lAdresseC, int num, Plateforme laPlateforme) : base(lAdresseS, lePortS, lAdresseC, num, laPlateforme)
        {
            this.numero = num;
            this.leLogin = login;
        }
    }
}
