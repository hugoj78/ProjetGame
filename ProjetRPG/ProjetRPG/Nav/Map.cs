using System;
namespace ProjetRPG.Nav
{
    public class Map
    {
        public int Largeur;
        public int Longueur;
        public string Nom;
        public Case[,] Plateau;


        public Map(int largeur, int longueur)
        {
            Largeur = largeur;
            Longueur = longueur;
            Plateau = new Case[largeur, Longueur];

            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    Plateau[i, j] = new Case();
                }
            }

        }
        public string GetDescription(int x, int y)
        {
            string s = Plateau[x, y].Description;
            return s;
        }
    }
}
