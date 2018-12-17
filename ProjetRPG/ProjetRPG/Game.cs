using System;


namespace ProjetRPG
{
    class Game
    {
        public Object.Inventaire[] inventaire;

        Player.Player P1;

        public Game()
        {
            //TODO Construteur game a faire
        }

        public void ChoiceGame(string name, int pet, int weapon)
        {
            inventaire = new Object.Inventaire[10];



            if (pet == 1 && weapon == 1)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pickle);
                inventaire[0] = new Object.ItemStart("Pickle", "Item Legendaire : Full Health ", 1, Object.ItemStart.ItemType.Pickle);

                Choicebattle();
            }
           else if (pet == 1 && weapon == 2)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pepper);
                inventaire[0] = new Object.ItemStart("Pepper", "Item Legendaire :Kill All Enemies ", 1, Object.ItemStart.ItemType.Pepper);

            }
            else if (pet == 1 && weapon == 3)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Friendzone);
                inventaire[0] = new Object.ItemStart("Friendzone", "Item Legendaire : Nobody Can Touch You ", 1, Object.ItemStart.ItemType.Friendzone);
            }
           else if (pet == 1 && weapon == 4)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Viagra);
                inventaire[0] = new Object.ItemStart("Viagra", "Item Legendaire : Level-Up Directly ", 1, Object.ItemStart.ItemType.Viagra);

            }
            else if (pet == 2 && weapon == 1)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Pickle);
                inventaire[0] = new Object.ItemStart("Pickle", "Item Legendaire : Full Health ", 1, Object.ItemStart.ItemType.Pickle);

            }
            else if (pet == 2 && weapon == 2)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Pepper);
                inventaire[0] = new Object.ItemStart("Pepper", "Item Legendaire : Kill All Enemies ", 1, Object.ItemStart.ItemType.Pepper);

            }
            else if (pet == 2 && weapon == 3)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Friendzone);
                inventaire[0] = new Object.ItemStart("Friendzone", "Item Legendaire : Nobody Can Touch You ", 1, Object.ItemStart.ItemType.Friendzone);
            }
            else if (pet == 2 && weapon == 4)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Viagra);
                inventaire[0] = new Object.ItemStart("Viagra", "Item Legendaire : Level-Up Directly ", 1, Object.ItemStart.ItemType.Viagra);

            }


        }

        public void Deplacement()
        {
            //printChoix();
            int choix = Menu.AskChoice(0, 4);
            //TODO recueper case plateau
            //TODO tester contenu case
            //TODO peut etre lancer combat
        }

        public void PrintMenuBattle()
        {
            Console.WriteLine("[1] ATTACK\t[2] OBJECT" + "\n[3] RUN");
        }


        public void Choicebattle()
        {
            PrintMenuBattle();
            Console.Write("Your Choice : ");
            int choix = Menu.AskChoice(1, 3);

            switch (choix)
            {
                case 1:
                    switch (P1.Pet)
                    {
                        case Player.Player.PocketMonster.Glouglou:
                            PocketMonster.Glouglou.PrintGlouGlouAttack(P1.Level);
   
                            Menu.AskChoice(1, Player.Player.AskAttack(P1.Level));

                            break;
                        case Player.Player.PocketMonster.Saicho:
                            PocketMonster.Saicho.PrintSaichoAttack(P1.Level);
                            break;
                    }
                    break;

                case 2:

                    for (int i = 0; i < inventaire.Rank; i++)
                    {
                        Console.Write((i + 1 ) + ". ");
                        inventaire[i].Print();
                    }

                    // TODO ASKCHOICE QUELLE POTION UTILISER
                    // TODO FONCTION USE QUI EXISTE DEJA
                    // TODO FUnction POUR VIRER UNE VALUE;
                    // SI VALUE == 0 alors delete objet
                    Console.ReadLine();
                    Console.Clear();
                    Choicebattle();

                    break;

                case 3:

                    if (Run())
                    {
                        // TODO QUITTE LE COMBAT
                        // TODO MAIS NE l'EVITE PAS PLUS TARD
                    }
                    else
                    {
                        Console.Write("You try to run away ! But your ennemie keep you !" +
                        	"\nPress Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        Choicebattle();
                    }
                    break;

                default:
                    break;
            }
        }

        public bool Run()
        {
            Random r = new Random();

            if (r.Next(0,100) < 10)
            {
                return true;
            }

            return false;
        }
    }
}
