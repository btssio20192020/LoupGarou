using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoupGarou
{
    public class Jour
    {
        /*int auto;
        int lesMorts;
        bool lEtat;
        int lid;*/
        public int lEtat = 0;
        public static int auto = 0;
        public int lId;
        public List<Joueur> lesMorts;

        public Jour()
        {
            auto++;
            this.lId = auto;
            lesMorts = new List<Joueur>();
        }
    }
}