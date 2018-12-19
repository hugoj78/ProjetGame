using System;

namespace ProjetRPG
{
    // Class Game
    class Game
    {
        public Object.Inventaire[] inventaire;

        public Story.Story story;

        public Player.Player P1;

        // Constructeur de Game
        public Game()
        {
            inventaire = new Object.Inventaire[10];

            story = new Story.Story(this);

        }


        // fonction Load Game 
        // On recupère les informations provenant de Menu lors de la recuperation d'informations
        // Puis on relance la partie avec les informations recuperés
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

            // On reprend l'histoire ou le joueur s'est arrete en relancant Histoire
            // Les variables de P1 étant mis a jour
            Histoire();
        }

        // Fonction ChoiceGame : Lors creation nouvelle partie on créer le nouveau Player avec les parametres
        // choisi. Puis on lance le jeu
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

            Console.Clear();

            // On lance le jeu

            story.StartMap();

            story.Story1();

            Histoire();

        }


        // Fonction PrintMenuBattle : Affiche les choix lors d'un combat
        public void PrintMenuBattle()
        {
            Console.WriteLine("[1] ATTACK\t[2] ITEM" + "\n[3] RUN");
        }


        // Fonction ChoiceBattle : Demande à l'utilisateur ce qu'il veut et verifie ses choix
        public int Choicebattle()
        {
            PrintMenuBattle();
            Console.Write("Your Choice : ");
            int choix = Menu.AskChoice(1, 3);

            switch (choix)
            {
                // Case 1 : Attaque : Selon le pocket monster et l'attaque choisie return un nombre different
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

                            int Att2 = PocketMonster.Saicho.AttackSaicho(AskAtt2);
                            return Att2;
                    }
                    return 0;
                
                // CASE 2 : Objet : Si le joueur a des objets utilisable
                // Affiche les objet qu'il peut utiliser
                // Sinon lui redemande son choix
                case 2:
                    bool test = false;

                    while (test != true)
                    {
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
                            test = true;
                        }
                        else
                        {
                            Console.WriteLine("You can't use something You don't have");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }

                    System.Threading.Thread.Sleep(2000);

                    Console.Clear();

                    return 0;

                // Case 3 : RUN : le joueur a 30% de chance de fuir et d'eviter le combat
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

        // Fonction Run : Calcule si le joueur peut fuir ou non (30% de chance de s'enfuir)
        public bool Run()
        {
            Random r = new Random();

            if (r.Next(0,100) < 30)
            {
                return true;
            }

            return false;
        }

        // Fonction AddItemHeal : Ajoute un Iteam Heal a l'inventaire
        public void AddItemHeal()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("Heal", "Common Item : Heal Your PocketMonster 10pv ", 1, Object.Item.ItemType.Heal);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        // Fonction AddItemHealUp : Ajoute un Iteam HealUp a l'inventaire
        public void AddItemHealUp()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("HealUp", "Common Item : Restore ALL PV Of Your PocketMonster ", 1, Object.Item.ItemType.HealUp);

            inventaire[P1.Count_Inventaire].PickUp();
        }

        // Fonction Level : Ajoute un Iteam Level a l'inventaire
        public void AddItemLevel()
        {
            P1.Count_Inventaire += 1;

            inventaire[P1.Count_Inventaire] = new Object.Item("Level Up", "Rare Item : Level-Up your PocketMonster ", 1, Object.Item.ItemType.Level);

            inventaire[P1.Count_Inventaire].PickUp();
        }


        // Fonction Damage : Selon les degats recu : return les PV restant ou Affiche GAME OVER et ferme le jeu
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

        // Fonction PV : return les PV du pocket monster
        public int PV()
        {
            return P1.PV;
        }

        // Fonction Level : return les level du pocket monster
        public int Level()
        {
            return P1.Level;
        }

        // Fonction LevelUp : Fait level up le pocket monster et return son nouveau level
        public int LevelUp()
        {
            return P1.Level++;
        }

        // Fonction StoryChoice : Demande joueur ce qu'il veut faire selon sa position
        // Il peut passer une position, aller a la suivante, utiliser un objet, sauvegarder sa partie 
        public void StoryChoice()
        {

            int choice = Menu.AskChoice(1, 4);

            switch (choice)
            {
                // Passe une position
                case 1:
                    P1.Position += 2;
                    break;
                // Passe a la position suivante
                case 2:
                    P1.Position += 1;
                    break;
                // Affiche les objets, leur description
                case 3:
                    bool test = false;

                    while (test != true)
                    {
                        for (int i = 0; i <= P1.Count_Inventaire; i++)
                        {
                            Console.Write((i + 1) + ". ");
                            inventaire[i].Print();
                        }

                        // Demande a l'utilisateur de choisir quelle objet utiliser
                        Console.WriteLine("Your choice : ");


                        int x = (P1.Count_Inventaire + 1);
                        int choiceobject = Menu.AskChoice(1, x);

                        int y = (choiceobject - 1);

                        // Si le joueur a encore cette objet dans son inventaire
                        if (Math.Abs(inventaire[y].Value) > 0)
                        {
                            // Utilise cette objet et descend sa valeur(nombre de fois que le joueur a cette item) de 1
                            inventaire[y].Use(P1);
                            inventaire[y].Value--;
                            test = true;
                        }
                        else
                        {
                            // Sinon on informe le joueur qu'il ne peut pas utiliser cet objet
                            Console.WriteLine("You can't use something You don't have");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }

                    System.Threading.Thread.Sleep(2000);

                    Console.Clear();
                    break;
                // Sauvegarde la partie
                case 4:
                    Menu.SaveGame(P1);
                    break;
                default:
                    break;
            }
        }

        // Fonction StoryChoice20 : StoryChoice mais particulière car il y a 21 postion donc le joueur ne peut
        // passer une position a la 20 eme position
        // On lui propose seulement de se battre contre le boss final,
        // d'utiliser un objet avant ou de sauvegarder sa partie.
        public void StoryChoice20()
        {

            int choice = Menu.AskChoice(1, 3);

            switch (choice)
            {
                case 1:
                    P1.Position += 1;
                    break;
                case 2:

                    bool test = false;

                    while (test != true)
                    {
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
                            test = true;
                        }
                        else
                        {
                            Console.WriteLine("You can't use something You don't have");
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                        }
                    }

                    System.Threading.Thread.Sleep(2000);

                    Console.Clear();
                    break;
                case 3:
                    Menu.SaveGame(P1);
                    break;
                default:
                    break;
            }
        }



        // Fonction Histoire : Permet de lancer des fonction selon la position jusqu'a la derniere postion
        // et de leur demande ce que l'utilisateur veut faire entre les positions
        public void Histoire()
        {

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
