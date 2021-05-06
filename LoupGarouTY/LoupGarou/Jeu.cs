using System;
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
        public Dictionary<int, Joueur> lesLoupsGarou = new Dictionary<int, Joueur>();
        public Dictionary<int, Joueur> lesVillageois = new Dictionary<int, Joueur>();
        public List<Role> lesRoles = new List<Role>();
        public List<Jour> lesJours = new List<Jour>();
        public string laNarration;
        public Jour leJourEnCour;
        public Joueur leMaire;
        public string narration;
        public int jours;


        public void attribuerDesRoles()
        { 
            Dictionary<int, Joueur> temp;
            Random _Random = new Random();
            int _Aleatoire;
            int _nbreLoup;
            int _nbreVillageois;
            int n;

            temp = new Dictionary<int, Joueur>();
            foreach(KeyValuePair<int, Joueur> element in lesJoueurs)
            {
                temp.Add(element.Key, element.Value);
            }

            _nbreVillageois = lesJoueurs.Count / 2 + 1;
            _nbreLoup = lesJoueurs.Count - _nbreVillageois;
            n = _nbreVillageois - 1;
            for( int i=0; i < _nbreVillageois; i++)
            {
                _Aleatoire = _Random.Next(0, n);
                lesJoueurs[temp.ElementAt(_Aleatoire).Key].leRole = lesRoles[0];
                lesJoueurs.Remove(temp.ElementAt(_Aleatoire).Key);
                n = n - 1;
            }

            n = _nbreLoup - 1;
            for(int i=0; i < _nbreLoup; i++)
            {
                _Aleatoire = _Random.Next(0, n);
                lesJoueurs[temp.ElementAt(_Aleatoire).Key].leRole = lesRoles[0];
                lesJoueurs.Remove(temp.ElementAt(_Aleatoire).Key);
                n = n - 1;
            }

        }

        public void jeu()
        { 

        }

        public void init()
        {
            foreach(KeyValuePair<int, Joueur> element in lesJoueurs)
            {
                lesJoueursActifs.Add(element.Key, element.Value);
            }
        }

        public void activerDesactiver(Dictionary<int, Joueur> laListe, bool etat)
        {
            foreach(KeyValuePair<int, Joueur> element in laListe)
            {
                etat = element.Value.estActif;
            }
        }
            public void setLaNarration(int Option)
        {
            string leTexte;

            switch(Option)
            {
                case 0:
                    laNarration = "Texte d'introduction du jeu";
                    break;

                case 1:
                    laNarration = "Texte d'introduction du jour";
                    break;

                case 2:
                    laNarration = "Texte d'introduction de la nuit";
                    break;

                case 3:
                    laNarration = "Texte D'introduction de la levée de la nuit";
                    break;

                case 4:
                    laNarration = "Texte pour voter";
                    break;

                case 5:
                    laNarration = "Texte pour annoncer le résultat du vote général";
                    break;

                case 6:
                    laNarration = "Text pour annoncer le ou les morts";
                    break;

                case 7:
                    laNarration = "Texte pour annoncer le vote du maire";
                    break;

                case 8:
                    laNarration = "Texte de fin de jeu";
                    break;

                case 9:
                    laNarration = "Texte pour annoncer le vote des loups";
                    break;
            }
        }

        public void voter(int choix)
        {
            if(lesJoueursEnBallotage.ContainsKey(choix))
            {
                lesJoueursEnBallotage[choix].leNbreVote = lesJoueursEnBallotage[choix].leNbreVote - 1;
            }else
            {
                lesJoueursEnBallotage.Add(choix, lesJoueursActifs[choix]);
            }
        }
        public int validationVote()
        {
            int result = 0;
            for(int i = 0; i < lesJoueursEnBallotage.Count; i++)
            {
                if(result == lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote)
                {
                    result = lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote;

                    if(i>0)
                    {
                        lesJoueursEnBallotage.Remove(lesJoueursEnBallotage.ElementAt(i - 1).Key);
                    }else if(result > lesJoueursEnBallotage.ElementAt(i).Value.leNbreVote)
                    {
                        lesJoueursEnBallotage.Remove(lesJoueursEnBallotage.ElementAt(i).Key);
                    }
                }
            }
            if(lesJoueursEnBallotage.Count == 1)
            {
                result = lesJoueursEnBallotage.ElementAt(0).Key;
            }
            else
            {
                result = 0;
            }

            return result;
           
        }

        public bool verifierGagnant()
        {
            bool result = false;
            if(lesLoupsGarou.Count == 0 || lesVillageois.Count == 0)
            {
                result = true;
            }
            return result;
        }

        public bool verifierVote(int choix)
        {
            bool result;
            result = false;
            if(validationVote() != 0)
            {
                result = true;
            }
            return result;
        }

        public void MAJlesJoueurs()
        {
            for (int i = 0; i < lesLoupsGarou.Count; i++)
            {
                lesLoupsGarou.Remove(i);
            }

            for (int i = 0; i < lesVillageois.Count; i++)
            {
                lesVillageois.Remove(i);
            }
            foreach (KeyValuePair<int, Joueur> element in lesJoueursActifs)
            {
                if (element.Value.leRole == lesRoles[0] || element.Value.leRole == lesRoles[1])
                {
                    lesVillageois.Add(element.Key, element.Value);
                }
                else
                {
                    lesLoupsGarou.Add(element.Key, element.Value);
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

            }
            lesJoueursEnBallotage.Clear();
            for(int i = 0; i<lesJoueursActifs.Count; i++)
            {
                lesJoueursActifs.ElementAt(i).Value.leNbreVote = 0;
            }
        }
    }
}