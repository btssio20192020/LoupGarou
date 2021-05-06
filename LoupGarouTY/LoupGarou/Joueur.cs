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

        public Joueur(string adresseS, int portS, string login) : base(adresseS, portS, login)
        {
            this.leLogin = login;
        }
    }
}
