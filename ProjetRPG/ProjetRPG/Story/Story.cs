using System;
namespace ProjetRPG.Story
{   
    class Story
    {
        public Game g;

        // Constructeur Story
        public Story(Game game)
        {
            g = game;
        }


        // Fonction MoveChoice : Affiche les choix possible ainsi que la position du joueur entre les positions
        public void MoveChoice(int position)
        {
            Nav.Map.PrintMap();
            Console.WriteLine("\nYour Postion : " + position) ;

            Console.Write("You can skip the next position. But you can miss a important object if you do that" +
                "\nBe careful ! If you want to Level-Up your PocketMonster quickly, don't skip position and take the maximum XP" +
                "\n\n1. Skip the next Stop" +
                "\n2. Go to the next Stop" +
                "\n3. Use Object" +
                "\n4. Save Game" +
                "\nYour choice : ");

            // Cas particulier de la position 20
            // Il ne peut pas passer la prochaine position
            if (position == 20)
            {
                Console.WriteLine("\nYour Postion : " + position);

                Console.Write("You can't skip the next position THIS IS THE FINAL BOSS" +
                    "\n1. FIGHT" +
                    "\n2. Use Object" +
                    "\n3. Save Game" +
                    "\nYour choice : ");
            }
        }

        // Fonction StartMap :Affiche la Map avec les consignes
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

            Console.WriteLine("\nWelcome in the PocketMonster world " +
                "\nYou can move to the next position or choose to jump the first one !" +
                "\nBe careful You can't fight against the FINAL BOSS now or dodge some Positon");

            Console.WriteLine("Press enter to go to position 1.");
            Console.ReadLine();

        }

        // Fonction StartStory :Selon la position appelle la fonction StoryMonster avec comme parametre ses PV
        // et ses DMG ou la fonction StoryObject avec comme parametre le type d'objet
        // Selon la case on fait Level Up le pocketMonster
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
                    StoryMonster(35, 7);
                    break;
                case 4:
                    Console.Clear();
                    StoryMonster(50,9);
                    g.LevelUp();
                    Console.WriteLine("\n\nYOU LEVEL UP : " + g.Level());
                    Console.Write("Press Enter To Continue ...");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    StoryObject("heal");
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
                    g.LevelUp();
                    Console.WriteLine("\n\n YOU LEVEL UP : " + g.Level() );
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
                    StoryObject("heal");
                    break;
                case 11:
                    Console.Clear();
                    StoryMonster(80, 12);
                    break;
                case 12:
                    Console.Clear();
                    StoryMonster(80,13);
                    g.LevelUp();
                    Console.WriteLine("\n\n YOU LEVEL UP : " + g.Level());
                    Console.Write("Press Enter To Continue ...");
                    Console.ReadLine();
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
                    g.LevelUp();
                    Console.WriteLine("\n\n YOU LEVEL UP : " + g.Level());
                    Console.Write("Press Enter To Continue ...");
                    Console.ReadLine();
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
                    Console.Write(@"
  ______ _   _ _____    
 |  ____| \ | |  __ \   
 | |__  |  \| | |  | |  
 |  __| | . ` | |  | |  
 | |____| |\  | |__| |  
 |______|_| \_|_____/   

                    ");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }


        // Fonction Story1 : Premiere story : cas particulier pas passable et donne un objet 
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

        // Fonction StoryObject : selon le parametre donne un certain objet au joueur
        public void StoryObject(string type)
        {
            Console.Clear();

            Console.WriteLine("Congratulations");

            switch (type)
            {
                case "heal":
                    g.AddItemHeal();
                    break;
                case "level":
                    g.AddItemLevel();
                    break;
                case "HealUp":
                    g.AddItemHealUp();
                    break;
            }

            Console.Write("Press Enter To Continue ...");
            Console.ReadLine();
        }

        // Fonction StoryBoss : Effet special sur le string PrintBoss pour le boss final
        public void StoryBoss()
        {
            string PrintBoss = @"
  ______   _                   _     ____                      
 |  ____| (_)                 | |   |  _ \                     
 | |__     _   _ __     __ _  | |   | |_) |   ___    ___   ___ 
 |  __|   | | | '_ \   / _` | | |   |  _ <   / _ \  / __| / __|
 | |      | | | | | | | (_| | | |   | |_) | | (_) | \__ \ \__ \
 |_|      |_| |_| |_|  \__,_| |_|   |____/   \___/  |___/ |___/

            ";

            Console.WriteLine(PrintBoss);
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(PrintBoss);
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(PrintBoss);
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            System.Threading.Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear(); 
            System.Threading.Thread.Sleep(500);
            Console.Clear();
        }


        // Fonction StoryMonster : Combat un monstre selon les parametre de point de vie et de degats
        public void StoryMonster(int Pv, int Dmg)
        {
            int PV = Pv;

            while(PV > 0)
            {
                // Affiche le mosntre selon ses degats
                Monster.Monster.PrintMonsterStory(Dmg);
                // Affiche ses PV
                Monster.Monster.PrintMonsterPV(PV);

                // Affiche les pv du joueur
                Console.WriteLine("YOUR PV : " + g.PV());

                // On lui demande d'attaquer / utiliser un objet / fuir
                int attaque = g.Choicebattle();

                // selon le choix les PV du monstre varie
                PV -= attaque;

                // Si le Monstre n'est pas mort
                if (PV > 0)
                {
                    Console.Clear();

                    // On Affiche que le mosntre attaque avec un effet 
                    Monster.Monster.PrintPhraseAtt();

                    // On applique les degats au joueur
                    // Fonction DAMAGE verifie si le joueur est mort ou non
                    // Dans le cas ou le joueur meurt affiche GAME OVER et quitte le jeu
                    g.Damage(Dmg);

                    // On lui affiche les PV restant
                    Console.WriteLine("YOUR PV : " + g.PV());

                    System.Threading.Thread.Sleep(1000);

                    Console.Clear();
                }
            }

            // Cas particulier si le joueur tue le monstre KENNY
            // On lui affiche la phrase culte de la serie SOUTHPARK
            // Sinon on le felicite d'avoir vaincue son ennemie
            if (Dmg == 5)
            {
                Console.WriteLine("OMG YOU KILLED KENNY ! YOU BASTARD");
                Console.WriteLine("Congratulations You win against your first enemy");
            }
            else
            {
                Console.WriteLine("Congratulations You win against your enemy");
            }
            Console.Clear();
        }
    }
}
