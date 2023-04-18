using System;

namespace IMATP5_RijckaertTom
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Methode mesOutils = new Methode();
                Console.WriteLine("BIENVENUE !");

                Console.WriteLine("Quel est la taille du tableau ? ");
                int _taille = int.Parse(Console.ReadLine());

                //mesOutils.Etape1(_taille, out int[,] _Matrice);

                //mesOutils.String_Tableau(_Matrice, out string stringTab);
                //Console.WriteLine(stringTab);

                //Console.WriteLine("Voulez vous afficher l'étape de développement de l'analyse n°2 ? ");
                //string a = Console.ReadLine();
                //if (a == "oui")
                //{
                // mesOutils.Etape2(_Matrice, _taille, out string _StringMatrice);
                //}
                Console.WriteLine("Voulez-vous recommencer ?");
                string b = Console.ReadLine();
                if (b != "oui")
                {
                    break;
                }
            }
        }
    }
}
