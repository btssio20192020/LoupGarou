using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Jeu
    {
        public Dictionary<int, Joueur> lesJoueurs = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesJoueursEnBallotage = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesJoueursActifs = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesLoupsGarous = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesVillageois = new Dictionary<int, Joueur>();
        public List<Role> lesRoles = new List<Role>();
        public List<Jour> lesJours = new List<Jour>();
        public string laNarration;
        public Jour leJourEnCour;
        public Joueur leMaire;;


        public Jeu()
        {
            lesRoles.Add("Villageois");
            lesRoles.Add("Loup");
            lesRoles.Add("Maire");
        }
        public void init()
        {
            foreach (element in lesJoueurs)
            {
                lesJoueursActifs.Add(element.Key, element.Value);
            }
        }
        public void activerDesactiver(Dictionary<int, Joueur> laListe, bool etat)
        {
            foreach (element in laListe)
            {
                element.Value.estActif = etat;
            }
        }
        public void attribuerDesRoles()
        { 
            Dictionary<int, Joueur> temp = new Dictionary<int, Joueur>();
            var Random = new Random();
            int _Aleatoire;
            int nbreLoup;
            int nbreVillageois;
            int n;
            temp = new Dictionary<int, Joueur>();

            foreach(int element in lesJoueurs)
            {
                temp.Add(element.Key, element.Value);
            }

            nbreVillageois = lesJoueurs.Count / 2 + 1;
            nbreLoup = lesJoueurs.Count - nbreLoupVillageois;
            n = nbreVillageois - 1;

            for(int i = 0; i < nbreVillageois; i++)
            {
                _Aleatoire = Random.Next(0, n);
                lesJoueurs[temp.ElementAt(_Aleatoire).Key].leRole = lesRoles[0];
                temp.Remove(temp.ElementAt(_Aleatoire).Key);
                n--;
            }
            n = nbreLoup - 1;
            for (int i = 0; i < nbreLoup; i++)
            {
                _Aleatoire = Random.Next(0, n);
                lesJoueurs[temp.ElementAt(_Aleatoire).Key].leRole = lesRoles[0];
                temp.Remove(temp.ElementAt(_Aleatoire).Key);
                n--;
            }

        }
       
        public void setlaNarration(int option)
        {
            string leTexte;

            switch (option)
            {
                case 0:
                    laNarration = "Texte d'introduction";
                    break;
                case 1:
                    laNarration = "Texte d'introduction du jour";
                    break;

                case 2:
                    laNarration = "Texte d'introduction de la nuit";
                    break;
                case 3:
                    laNarration = "Texte d'introduction la levée du jour";
                    break;
                case 4:
                    laNarration = "Texte pour voter";
                    break;
                case 5:
                    laNarration = "Texte pour annoncer le résultat du vote général";
                    break;
                case 6:
                    laNarration = "Texte pour annoncer le ou les morts";
                    break;
                case 7:
                    laNarration = "Texte pour annoncer le vote du maire";
                    break;
                case 8:
                    laNarration = "Texte de fin de jeu";
                    break;
            }
           
        }
        public void voter(int choix)
        {
            if (/*SI lesJoueursEnBallotage contiennent la clé choix FAIRE*/)
            {
                lesJoueursEnBallotage[choix].leNbrVote = lesJoueursEnBallotage[choix].leNbrVote + 1;
            }
            else
            {
                lesJoueursEnBallotage.Add(choix, lesJoueursActifs[choix]);
                lesJoueursEnBallotage[choix].leNbrVote = lesJoueursEnBallotage[choix].leNbrVote + 1;
            }

        }
        public bool verifierVote(int choix)
        {
            Boolean result;
            result = false;
            if (validationVote() != 0)
            {
                result = true;
            }
            return result;

        }
        public int validationVote()
        {
            int result;
            result = 0;
            for (int i = 0; i < lesJoueursEnBallotage.Count; i++)
            {
                if (result < lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote)
                {
                    result = lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote;
                    if (i > 0)
                    {
                        lesJoueursEnBallotage.Remove(lesJoueursEnBallotage.ElementAt(i - 1).Key);
                    }
                }
                else if (result > lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote)
                {
                    lesJoueursEnBallotage.Remove(lesJoueursEnBallotage.ElementAt(i).Key);
                }
                if (lesJoueursEnBallotage.Count == 1)
                {
                    result = lesJouersEnBallotage.ElementAt(0).Key;
                }
                else
                {
                    result = 0;
                }
                return result;

            }

        }
        public bool verifierGagnant()
        {
            Boolean result;
            result = false;
            if (lesLoupsGarous.Count == 0 || lesVillageois.Count ==0)
            {
                result = true;
            }
            return result;
        }
        public void MAJlesJoueurs()
        {
            foreach(int element in lesJoueursActifs)
            {
                if (element.Value.leRole == lesRoles[0] || element.Value.leRole == lesRoles[2])
                {
                    lesVillageois.Add(element.key, element.Value);
                }
                else
                {
                    lesLoupsGarous.Add(element.key, element.Value);
                }
            }
        }
        public void initVote()
        {
            if (validationVote() != 0)
            {
                lesJoueurs[validationVote()].estActif = false;
                lesJoueurs[validationVote()].estMort = true;
                lesJoueursActifs.Remove(validationVote());
                MAJLesJoueurs;
            }

               //Vider lesJoueursEnBallotage


            for(int i = 0; i < lesJoueursActifs.Count; i++)
            {
                lesJoueursActifs.ElementAt(i).Value.leNbrVote = 0;
            }
        }
    }
}