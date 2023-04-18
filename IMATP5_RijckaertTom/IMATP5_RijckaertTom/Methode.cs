using System;
using System.Collections.Generic;
using System.Text;

namespace IMATP5_RijckaertTom
{
    public struct Methode
    {
        public void Etape1(int _taille, out int[,] _Matrice)
        {
            _Matrice  = new int[_taille, _taille];
            _Matrice[1, 1] = 1;
            for (int ligne = 1; ligne < _taille; ligne++)
            {
                for (int colonne = 1; colonne < _taille; colonne++)
                {
                    _Matrice[ligne, colonne] = _Matrice[ligne - 1, colonne - 2] + _Matrice[ligne - 1, colonne - 2];
                }
            }
        }

        public void Etape2(int[,] _Matrice, int _taille, out string _StringMatrice)
        {
            int nbLigne = _Matrice.GetLength(0);
            int nbColonne = _Matrice.GetLength(1);
            _StringMatrice = "(a + b)^" + _taille + " =";
            for (int ligne = 1; ligne < nbLigne; ligne++)
            {
                for (int colonne = 1; colonne < nbColonne; colonne++)
                {
                    _StringMatrice += "" + _Matrice[ligne, colonne] + "a^" + _taille + "b";
                }
            }
        }
        public void String_Tableau(int[,] Tab, out string stringTab)
        {
            // instanciation de la variable stringTab
            stringTab = "";
            // boucle pour se balades dans les lignes de la matrice
            for (int ligne = 0; ligne < Tab.GetLength(0); ligne++)
            {
                // boucle pour se balader dans les colonnes de la matrice
                for (int colonne = 0; colonne < Tab.GetLength(1); colonne++)
                {
                    // mise des données de la matrice dans la variable string stringTab
                    stringTab += Tab[ligne, colonne] + "|";
                }
                // passage à la ligne
                stringTab += "\n";
            }
        }

    }
}
