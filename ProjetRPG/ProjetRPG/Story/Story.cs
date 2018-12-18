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

            if (position == 20)
            {
                Console.WriteLine("\nYour Postion : " + position);

                Console.Write("You can't skip the next position THIS IS THE FINAL BOSS" +
                    "\n1. FIGHT" +
                    "\n2. Use Object" +
                    "\nYour choice : ");
            }
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
            //TODO AJOUTER LES LEVEL UP DES POCKETMONSTER
            switch (position)
            {
                case 2:
                    Console.Clear();
                    StoryMonster(30, 5);
                    break;
                case 3:
                    Console.Clear();
                    StoryMonster(35, 7);
                    break;
                case 4:
                    Console.Clear();
                    StoryMonster(50,9);
                    break;
                case 5:
                    Console.Clear();
                    StoryObject("dmg");
                    break;
                case 6:
                    Console.Clear();
                    StoryMonster(40, 6);
                    break;
                case 7:
                    Console.Clear();
                    StoryMonster(150, 10);
                    Console.WriteLine(@"
                       _.-**-._
                    _,(        ),_
                 .-""   '-^----'   ""-.
              .-'                    '-.
            .'                          '.
          .'    __.--**'""""""""""""'**--.__    '.
         /_.-*""'__.--**'""""""""""""'**--.__'""*-._\
        /_..-*""'                      '""*-.._\
       :              -_      _-              ;
       :                ""-..-""                ;
        \               _-''-_               /
         \            -'      '.            /
      .-*''.                              .'-.
   .-'      '.                          .'    '.
  :           '-.        _.._        .-'        '._
 ;""*-._          '-._  --___ '   _.-'        _.*'  '*.
:      '.            `""*-.__.-*""`           (        :
 ;      ;                 *|                 '-.     ;
  '---*'                   |                    """"--'
   :                      *|                      :
   '.                      |                     .'
     '.._                 *|        ____----.._-'
      \  """"""----_____------'-----""""""         /
       \  __..-------.._        ___..---._  /
       :'""              '-..--''          ""';
        '""""""""""""""""""""""""""""""""' '""""""""""""""""""""""""""""""'");
                    Console.Write("Press Enter To Continue ...");
                    Console.ReadLine();
                    StoryObject("HealUp");
                    break;
                case 8:
                    Console.Clear();
                    StoryMonster(60, 2);
                    break;
                case 9:
                    Console.Clear();
                    StoryMonster(40, 11);
                    break;
                case 10:
                    Console.Clear();
                    StoryObject("block");
                    break;
                case 11:
                    Console.Clear();
                    StoryMonster(80, 12);
                    break;
                case 12:
                    Console.Clear();
                    StoryMonster(80,13);
                    break;
                case 13:
                    Console.Clear();
                    StoryMonster(80,14);
                    break;
                case 14:
                    Console.Clear();
                    StoryObject("heal");
                    break;
                case 15:
                    Console.Clear();
                    StoryMonster(80,15);
                    break;
                case 16:
                    Console.Clear();
                    StoryMonster(50,25);
                    break;
                case 17:
                    Console.Clear();
                    StoryObject("level");
                    break;
                case 18:
                    Console.Clear();
                    StoryMonster(200, 30);
                    break;
                case 19:
                    Console.Clear();
                    StoryMonster(80, 22);
                    break;
                case 20:
                    Console.Clear();
                    StoryObject("HealUp");
                    break;
                case 21:
                    Console.Clear();
                    StoryBoss();
                    StoryMonster(666, 50);
                    Console.Write("END");
                    Console.ReadLine();
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

        public void StoryObject(string type)
        {
            Console.Clear();

            Console.WriteLine("Congratulations");

            switch (type)
            {
                case "heal":
                    g.AddItemHeal();
                    break;
                case "dmg":
                    g.AddItemDmg();
                    break;
                case "level":
                    g.AddItemLevel();
                    break;
                case "block":
                    g.AddItemBlock();
                    break;
                case "HealUp":
                    g.AddItemHealUp();
                    break;
            }

            Console.Write("Press Enter To Continue ...");
            Console.ReadLine();
        }

        public void StoryBoss()
        {
            Console.WriteLine(@"
  ______   _                   _     ____                      
 |  ____| (_)                 | |   |  _ \                     
 | |__     _   _ __     __ _  | |   | |_) |   ___    ___   ___ 
 |  __|   | | | '_ \   / _` | | |   |  _ <   / _ \  / __| / __|
 | |      | | | | | | | (_| | | |   | |_) | | (_) | \__ \ \__ \
 |_|      |_| |_| |_|  \__,_| |_|   |____/   \___/  |___/ |___/
");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
  ______   _                   _     ____                      
 |  ____| (_)                 | |   |  _ \                     
 | |__     _   _ __     __ _  | |   | |_) |   ___    ___   ___ 
 |  __|   | | | '_ \   / _` | | |   |  _ <   / _ \  / __| / __|
 | |      | | | | | | | (_| | | |   | |_) | | (_) | \__ \ \__ \
 |_|      |_| |_| |_|  \__,_| |_|   |____/   \___/  |___/ |___/
");
            System.Threading.Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear(); Console.WriteLine(@"
  ______   _                   _     ____                      
 |  ____| (_)                 | |   |  _ \                     
 | |__     _   _ __     __ _  | |   | |_) |   ___    ___   ___ 
 |  __|   | | | '_ \   / _` | | |   |  _ <   / _ \  / __| / __|
 | |      | | | | | | | (_| | | |   | |_) | | (_) | \__ \ \__ \
 |_|      |_| |_| |_|  \__,_| |_|   |____/   \___/  |___/ |___/
");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
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
    }
}
