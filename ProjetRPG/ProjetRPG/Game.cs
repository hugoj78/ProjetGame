using System;

namespace ProjetRPG
{
    class Game
    {
        public Object.Inventaire[] inventaire;

        public Story.Story story;

        Player.Player P1;

        public Game()
        {
            inventaire = new Object.Inventaire[10];

            story = new Story.Story(this);

        }


        public void ChoiceGame(string name, int pet, int weapon)
        {

            if (pet == 1 && weapon == 1)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pickle);
                inventaire[0] = new Object.ItemStart("Pickle", "Item Legendaire : Full Health ", 1, Object.ItemStart.ItemType.Pickle);
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

            Histoire();

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


        public int Choicebattle()
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

                            int AskAtt = Menu.AskChoice(1, Player.Player.AskAttack(P1.Level));

                            int Att = PocketMonster.Glouglou.AttackGlouglou(AskAtt);
                            return Att;

                        case Player.Player.PocketMonster.Saicho:

                            PocketMonster.Saicho.PrintSaichoAttack(P1.Level);

                            int AskAtt2 = Menu.AskChoice(1, Player.Player.AskAttack(P1.Level));

                            int Att2 = PocketMonster.Saicho.AttackGlouglou(AskAtt2);
                            return Att2;
                    }
                    return 0;

                case 2:
                    for (int i = 0; i <= P1.Count_Inventaire; i++)
                    {
                        Console.Write((i + 1 ) + ". ");
                        inventaire[i].Print();
                    }

                    // TODO ASKCHOICE QUELLE POTION UTILISER
                    // TODO FONCTION USE QUI EXISTE DEJA
                    // TODO FUnction POUR VIRER UNE VALUE;
                    // SI VALUE == 0 alors delete objet
                    Console.ReadLine();
                    Console.ReadLine();
                    Console.Clear();

                    return 0;

                case 3:

                    if (Run())
                    {
                        // TODO QUITTE LE COMBAT
                        // TODO MAIS NE l'EVITE PAS PLUS TARD
                        return 0;
                    }
                    else
                    {
                        Console.Write("You try to run away ! But your ennemie block you !" +
                        	"\nPress Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                        Choicebattle();
                    }
                    return 0;

                default:
                    return 0;
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

        public void AddItemHeal()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("Heal", "Item Commun : Heal Your Friend 10pv ", 1, Object.Item.ItemType.Heal);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        public void AddItemHealUp()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("HealUp", "Item Commun : Restore ALL PV Of Your PocketMonster ", 1, Object.Item.ItemType.HealUp);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        public void AddItemDmg()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("Damage", "Item Rare : Make 20 dmg to your oppenent ", 1, Object.Item.ItemType.Dmg);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        public void AddItemLevel()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("Level Up", "Item Rare : Level Up your PocketMonster ", 1, Object.Item.ItemType.Level);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        public void AddItemBlock()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("Block", "Item Epic : Block your ennemies Attack ", 1, Object.Item.ItemType.Dmg);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        public int Damage(int degats)
        {
            P1.PV -= degats;

            if (P1.PV <= 0)
            {
                Console.WriteLine(@"
   _____          __  __ ______    ______      ________ _____  
  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
                                                               
                                                               ");
            }
            return P1.PV;
        }

        public int PV()
        {
            return P1.PV;
        }

        public void StoryChoice()
        {

            int choice = Menu.AskChoice(1, 3);

            switch (choice)
            {
                case 1:
                    P1.Position += 2;
                    break;
                case 2:
                    P1.Position += 1;
                    break;
                case 3:

                    for (int i = 0; i <= P1.Count_Inventaire; i++)
                    {
                        Console.Write((i + 1) + ". ");
                        inventaire[i].Print();
                    }

                    // TODO ASKCHOICE QUELLE POTION UTILISER
                    // TODO FONCTION USE QUI EXISTE DEJA
                    // TODO FUnction POUR VIRER UNE VALUE;
                    // SI VALUE == 0 alors delete objet
                    break;
                default:
                    break;
            }
        }

        public void StoryChoice20()
        {

            int choice = Menu.AskChoice(1, 2);

            switch (choice)
            {
                case 1:
                    P1.Position += 1;
                    break;
                case 2:
                    for (int i = 0; i <= P1.Count_Inventaire; i++)
                    {
                        Console.Write((i + 1) + ". ");
                        inventaire[i].Print();
                    }

                    // TODO ASKCHOICE QUELLE POTION UTILISER
                    // TODO FONCTION USE QUI EXISTE DEJA
                    // TODO FUnction POUR VIRER UNE VALUE;
                    // SI VALUE == 0 alors delete objet
                    break;
                default:
                    break;
            }
        }

        public void Histoire()
        {

            story.StartMap();

            story.Story1();

            while (P1.Position != 21)
            {

                story.MoveChoice(P1.Position);

                if (P1.Position == 20)
                {
                    StoryChoice20();
                }
                else
                {
                    StoryChoice();
                }

                story.StartStory(P1.Position);

            }
        }

    }
}
