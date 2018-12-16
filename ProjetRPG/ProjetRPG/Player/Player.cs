using System;

namespace ProjetRPG.Player
{
    class Player
    {
        public enum PocketMonster { Saicho, Glouglou};
        public enum Objet { Pickle, Pepper, Friendzone, Viagra}

        public string Name;
        public PocketMonster Pet;
        public Objet Item;
        protected int PV;
        protected int Energie;
        protected int Level;

        public Object.Inventaire[] Inventaire;

        public Player(string n, PocketMonster p, Objet i)
        {
            Name = n;
            Pet = p;
            Item = i;

            if (p == PocketMonster.Saicho)
            {
                PV = 100;
                Energie = 15;
                Level = 1;

                if (i == Objet.Pickle)
                {
                    Inventaire = new Object.Inventaire[10];

                }

            } 
            else if (p == PocketMonster.Glouglou)
            {
                PV = 150;
                Energie = 15;
                Level = 1;
            }

        }
    }
}
