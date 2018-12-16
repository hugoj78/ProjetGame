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
      
        protected int Energie;

        protected int PV;

        protected int Level;

        public Object.Inventaire[] Inventaire;

        public Player(string n, PocketMonster p, Objet i)
        {
            Name = n;
            Pet = p;
            Item = i;

            Inventaire = new Object.Inventaire[10];

            if (p == PocketMonster.Saicho)
            {
                PV = 100;
                Level = 1;

                if (i == Objet.Pickle)
                {


                }

            } 
            else if (p == PocketMonster.Glouglou)
            {
                PV = 150;
                Level = 1;
            }
        }

    }
}
