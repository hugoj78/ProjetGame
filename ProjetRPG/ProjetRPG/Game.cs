using System;

namespace ProjetRPG
{
    class Game
    {
        public Object.Inventaire[] inventaire;

        public Story.Story story;

        public Player.Player P1;

        public Game()
        {
            inventaire = new Object.Inventaire[10];

            story = new Story.Story(this);

        }

        public void LoadGame(string name, string pet, string weapon, int position, int level, int Pv)
        {
            if (pet == "Saicho" && weapon == "Pickle")
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pickle);
                inventaire[0] = new Object.ItemStart("Pickle", "Legendary Item : Full Health ", 1, Object.ItemStart.ItemType.Pickle);
                P1.Position = position;
                P1.Level = level;
                P1.PV = Pv;
            }
            else if (pet == "Saicho" && weapon == "Viagra")
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Viagra);
                inventaire[0] = new Object.ItemStart("Viagra", "Legendary Item : Level-Up Directly ", 1, Object.ItemStart.ItemType.Viagra);
                P1.Position = position;
                P1.Level = level;
                P1.PV = Pv;
            }
            else if (pet == "Glouglou" && weapon == "Pickle")
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Pickle);
                inventaire[0] = new Object.ItemStart("Pickle", "Legendary Item : Full Health ", 1, Object.ItemStart.ItemType.Pickle);
                P1.Position = position;
                P1.Level = level;
                P1.PV = Pv;
            }
            else if (pet == "Glouglou" && weapon == "Viagra")
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Viagra);
                inventaire[0] = new Object.ItemStart("Viagra", "Legendary Item : Level-Up Directly ", 1, Object.ItemStart.ItemType.Viagra);
                P1.Position = position;
                P1.Level = level;
                P1.PV = Pv;

            }

            Histoire();
        }


        public void ChoiceGame(string name, int pet, int weapon)
        {

            if (pet == 1 && weapon == 1)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pickle);
                inventaire[0] = new Object.ItemStart("Pickle", "Legendary Item : Full Health ", 1, Object.ItemStart.ItemType.Pickle);
            }
            else if (pet == 1 && weapon == 2)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Viagra);
                inventaire[0] = new Object.ItemStart("Viagra", "Legendary Item : Level-Up Directly ", 1, Object.ItemStart.ItemType.Viagra);

            }
            else if (pet == 2 && weapon == 1)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Pickle);
                inventaire[0] = new Object.ItemStart("Pickle", "Legendary Item : Full Health ", 1, Object.ItemStart.ItemType.Pickle);

            }
            else if (pet == 2 && weapon == 2)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Viagra);
                inventaire[0] = new Object.ItemStart("Viagra", "Legendary Item : Level-Up Directly ", 1, Object.ItemStart.ItemType.Viagra);

            }

            Histoire();

        }

        public void PrintMenuBattle()
        {
            Console.WriteLine("[1] ATTACK\t[2] ITEM" + "\n[3] RUN");
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
                        Console.Write((i + 1) + ". ");
                        inventaire[i].Print();
                    }
                    Console.WriteLine("Your choice : ");
                    int x = (P1.Count_Inventaire + 1);
                    int choiceobject = Menu.AskChoice(1, x);

                    int y = (choiceobject - 1);

                    if (Math.Abs(inventaire[y].Value) > 0)
                    {
                        inventaire[y].Use(P1);
                        inventaire[y].Value--;
                    }
                    else
                    {
                        Console.WriteLine("You can't use something You don't have");
                    }

                    System.Threading.Thread.Sleep(2000);

                    Console.Clear();

                    return 0;

                case 3:

                    if (Run())
                    {
                        Console.WriteLine("You Run Away ...");
                        return 1000;
                    }
                    else
                    {
                        Console.Write("You try to run away ! But your ennemie block you ! What a pity !" +
                        	"\nPress Enter To Continue...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    return 0;

                default:
                    return 0;
            }
        }

        public bool Run()
        {
            Random r = new Random();

            if (r.Next(0,100) < 30)
            {
                return true;
            }

            return false;
        }

        public void AddItemHeal()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("Heal", "Common Item : Heal Your PocketMonster 10pv ", 1, Object.Item.ItemType.Heal);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        public void AddItemHealUp()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("HealUp", "Common Item : Restore ALL PV Of Your PocketMonster ", 1, Object.Item.ItemType.HealUp);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        public void AddItemLevel()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("Level Up", "Rare Item : Level-Up your PocketMonster ", 1, Object.Item.ItemType.Level);

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
                Console.Write("Press Enter To Quit...");
                Console.ReadLine();
                Environment.Exit(0);

            }
            return P1.PV;
        }

        public int PV()
        {
            return P1.PV;
        }

        public int Level()
        {
            return P1.Level;
        }

        public int LevelUp()
        {
            return P1.Level++;
        }

        public void StoryChoice()
        {

            int choice = Menu.AskChoice(1, 4);

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
                    Console.WriteLine("Your choice : ");
                    int x = (P1.Count_Inventaire + 1);
                    int choiceobject = Menu.AskChoice(1, x);

                    int y = (choiceobject - 1);

                    if (Math.Abs(inventaire[y].Value) > 0)
                    {
                        inventaire[y].Use(P1);
                        inventaire[y].Value--;
                    }

                    System.Threading.Thread.Sleep(2000);

                    Console.Clear();
                    break;
                case 4:
                    Menu.SaveGame(P1);
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
                    Console.WriteLine("Your choice : ");
                    int x = (P1.Count_Inventaire + 1);
                    int choiceobject = Menu.AskChoice(1, x);

                    int y = (choiceobject - 1);

                    if (Math.Abs(inventaire[y].Value) > 0)
                    {
                        inventaire[y].Use(P1);
                        inventaire[y].Value--;
                    }

                    System.Threading.Thread.Sleep(2000);

                    Console.Clear();
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
