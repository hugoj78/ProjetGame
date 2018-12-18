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
      
        public int PV;
        public int Level;
        public int Count_Inventaire;
        public int Position;
       
        private int n;

        public Player(string na, PocketMonster p, Objet i)
        {
            Name = na;
            Pet = p;
            Item = i;

            Count_Inventaire = 0;
            Position = 1;


            if (p == PocketMonster.Saicho)
            {
                PV = 100;
                Level = 1;

            } 
            else if (p == PocketMonster.Glouglou)
            {
                PV = 150;
                Level = 1;
            }
        }

        public Player(int n)
        {
            this.n = n;
        }

        public int FullHeal(int heal)
        {
            PV = 150;
            {
                Console.WriteLine(@"
                  ______ _    _ _      _        _______      __         
                 |  ____| |  | | |    | |      |  __ \ \    / /    _    
                 | |__  | |  | | |    | |      | |__) \ \  / /   _| |_  
                 |  __| | |  | | |    | |      |  ___/ \ \/ /   |_   _| 
                 | |    | |__| | |____| |____  | |      \  /      |_|   
                 |_|     \____/|______|______| |_|       \/             

                ");
            }
            return PV;
        }

       public static int AskAttack(int level)
        {
            if (level >= 3 && level < 5)
            {
                return 3;
            }
            if (level >= 5)
            {
                return 4;
            }

            return 2;

        }
    }
}
