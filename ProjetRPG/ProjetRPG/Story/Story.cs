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

        public void MoveChoice(int position)
        {
            Nav.Map.PrintMap();
            Console.WriteLine("\nYour Postion : " + position) ;

            Console.Write("You can skip the next position and skip a monster :) or an object :/" +
                "\nBecareful ! You need to Level Up your PocketMonster and skip a position won't give you experience" +
                "\n\n1. Skip Position" +
                "\n2. Continue" +
                "\n3. Use Object" +
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

        public void StartStory(int position)
        {
            switch (position)
            {
                case 2:
                    Console.Clear();
                    StoryMonster(30, 5);
                    break;
                case 3:
                    Console.Clear();
                    StoryMonster(35, 10);
                    break;
                case 4:
                    Console.Clear();
                    StoryObject();
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                default:
                    break;
            }
        }

        public void Story1()
        {
            Console.Clear();
            Nav.Map.PrintMap();

            Console.WriteLine("\nYour Postion : 1");

            Console.WriteLine("Congratulations");

            g.AddItemHeal();

            Console.WriteLine("Press Enter To Continue ...");
            Console.Read();
            Console.Clear();

        }

        public void StoryObject()
        {
            Console.Clear();

            Console.Clear();
            Nav.Map.PrintMap();

            Console.WriteLine("\nYour Postion : ");

            Console.WriteLine("Congratulations");

            g.AddItemHeal();
        }


        public void StoryMonster(int Pv, int Dmg)
        {
            int PV = Pv;

            while(PV > 0)
            {
                Monster.Monster.PrintMonsterStory(Dmg);
                Monster.Monster.PrintMonsterPV(PV);


                Console.WriteLine("YOUR PV : " + g.PV());
                int attaque = g.Choicebattle();

                PV -= attaque;

                if (PV > 0)
                {
                    Console.Clear();

                    Monster.Monster.PrintPhraseAtt();

                    g.Damage(Dmg);

                    Console.WriteLine("YOUR PV : " + g.PV());

                    System.Threading.Thread.Sleep(1000);

                    Console.Clear();
                }
            }

            if (Dmg == 5)
            {
                Console.WriteLine("OMG YOU KILLED KENNY ! YOU BASTARD");
                Console.WriteLine("Congratulations You win against your first enemies");
            }
            else
                Console.WriteLine("Congratulations You win against your enemies");
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
