using System;
namespace ProjetRPG
{
    class Game
    {
        //public Player player;
        //public Map plateau;

        public Game()
        {
            //TODO Construteur game a faire
        }

        public void StartGame()
        {

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
