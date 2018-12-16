using System;
namespace ProjetRPG
{
    class Game
    {
        public Player.Player player;
        public Nav.Map plateau;

        public Game()
        {
            //TODO Construteur game a faire
        }

        public static void ChoiceGame(string name, int pet, int weapon)
        {
           if (pet == 1 && weapon == 1)
            {
                Player.Player P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pickle);
            }
           else if (pet == 1 && weapon == 2)
            {
                Player.Player P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Pepper);
            }
           else if (pet == 1 && weapon == 3)
            {
                Player.Player P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Friendzone);
            }
           else if (pet == 1 && weapon == 4)
            {
                Player.Player P1 = new Player.Player(name, Player.Player.PocketMonster.Saicho, Player.Player.Objet.Viagra);
            }
           else if (pet == 2 && weapon == 1)
            {
                Player.Player P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Pickle);
            }
            else if (pet == 2 && weapon == 2)
            {
                Player.Player P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Pepper);
            }
            else if (pet == 2 && weapon == 3)
            {
                Player.Player P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Friendzone);
            }
            else if (pet == 2 && weapon == 4)
            {
                Player.Player P1 = new Player.Player(name, Player.Player.PocketMonster.Glouglou, Player.Player.Objet.Viagra);
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
    }
}
