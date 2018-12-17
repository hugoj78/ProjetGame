using System;
namespace ProjetRPG
{
    class Game
    {
        //public Player.Player player;
        //public Nav.Map plateau;

        Player.Player P1;

        public Game()
        {
            //TODO Construteur game a faire
        }

        public void ChoiceGame(string name, int pet, int weapon)
        {
           if (pet == 1 && weapon == 1)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pickle);
            }
           else if (pet == 1 && weapon == 2)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pepper);
            }
           else if (pet == 1 && weapon == 3)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Friendzone);
            }
           else if (pet == 1 && weapon == 4)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Viagra);
            }
           else if (pet == 2 && weapon == 1)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Pickle);
            }
            else if (pet == 2 && weapon == 2)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Pepper);
            }
            else if (pet == 2 && weapon == 3)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Friendzone);
            }
            else if (pet == 2 && weapon == 4)
            {
                P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Viagra);
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
            int choix = Menu.AskChoice(1, 3);

            switch (choix)
            {
                case 1:
                    if (P1.Pet == Player.Player.PocketMonster.Glouglou)
                    {
                        PocketMonster.Glouglou.PrintGlouGlouAttack(P1.Level);
                    }
                    else if (P1.Pet == Player.Player.PocketMonster.Saicho)
                    {
                        PocketMonster.Saicho.PrintSaichoAttack(P1.Level);
                    }
                    break;

                case 2:
                    break;

                default:
                    break;
            }



           
        }
    }
}
