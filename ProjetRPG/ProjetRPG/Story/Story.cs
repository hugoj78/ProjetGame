using System;
namespace ProjetRPG.Story
{   
    class Story
    {

        public Game g;

        public Story(Game game)
        {
            g = game;
        }

        public void MoveChoice()
        {
            Console.Write("You can skip the next position and skip a monster :) or an object :/" +
                "\n Becareful ! You need to Level Up your PocketMonster and skip a position won't give you experience" +
                "\n\n1.Skip Position" +
                "\n2. Continue" +
                "\nYour choice : ");
        }

        public void StartMap()
        {
            Console.Clear();
            Console.WriteLine(@"
  _____                   _             _       __  __                         _                 
 |  __ \                 | |           | |     |  \/  |                       | |                
 | |__) |   ___     ___  | | __   ___  | |_    | \  / |   ___    _ __    ___  | |_    ___   _ __ 
 |  ___/   / _ \   / __| | |/ /  / _ \ | __|   | |\/| |  / _ \  | '_ \  / __| | __|  / _ \ | '__|
 | |      | (_) | | (__  |   <  |  __/ | |_    | |  | | | (_) | | | | | \__ \ | |_  |  __/ | |   
 |_|       \___/   \___| |_|\_\  \___|  \__|   |_|  |_|  \___/  |_| |_| |___/  \__|  \___| |_|   
                                                                                                 
                                                                                                 
");
            Nav.Map.PrintMap();

            Console.WriteLine("\nWelcome to wolrd of Pocketmonster " +
                "\nTo move you need to enter the number of the position you want to go !" +
                "\nBecareful You can't fight against the FINAL BOSS now or dodge some Positon");

            Console.WriteLine("Press enter to go to position 1.");
            Console.ReadLine();

        }

        public void Story1()
        {
            Console.Clear();
            Nav.Map.PrintMap();

            Console.WriteLine("\nYour Postion : 1");

            Console.WriteLine("Congratulations");

            g.AddItem();

            MoveChoice();

        }

        public void Story2(int level)
        {
            int PV = 30;

            Monster.Monster.PrintMonsterStory2();
            Monster.Monster.PrintMonsterPV(PV);


            g.Choicebattle();

            int AskAtt = Menu.AskChoice(1, Player.Player.AskAttack(level));

            int Att = PocketMonster.Glouglou.AttackGlouglou(AskAtt);




            MoveChoice();

            int choice = Menu.AskChoice(1, 2);

            switch (choice)
            {
                case 1:
                    Story4();
                    break;
                case 2:
                    Story3();
                    break;
                default:
                    break;
            }
        }

        public void Story3()
        {

        }
        public void Story4()
        {

        }
        public void Story5()
        {

        }
        public void Story6()
        {

        }
        public void Story7()
        {

        }
        public void Story8()
        {

        }
        public void Story9()
        {

        }
        public void Story10()
        {

        }
        public void Story11()
        {

        }

    }
}
