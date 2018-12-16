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

        public Player(int level)
        {
            Level = level;

        }

        public int Damage(int degats)
        {
            PV =- degats;

            if (PV == 0)
            {
                Console.WriteLine(@"   _____          __  __ ______    ______      ________ _____  
                                      / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
                                     | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
                                     | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
                                     | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
                                      \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
                                                               
                                                               ");
            }
            return PV;
        }

        public int Heal(int heal)
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
    }
}
