using System;
namespace ProjetRPG
{
    class Menu
    {
        public Menu()
        {
            PrintMenu();
            int choix = AskChoice(1, 4);
            switch (choix)
            {
                case 1:
                    Console.Clear();
                    StartGame();
                    break;
                case 2:
                    LoadGame();
                    break;
                case 3:
                    About();
                    break;
                case 4:
                    Quit();
                    break;
                default:
                    break;
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine(@"
  _____                   _             _          
 |  __ \                 | |           | |         
 | |__) |   ___     ___  | | __   ___  | |_        
 |  ___/   / _ \   / __| | |/ /  / _ \ | __|       
 | |      | (_) | | (__  |   <  |  __/ | |_        
 |_|       \___/   \___| |_|\_\  \___|  \__|       
                                                   
                                                   
  __  __                         _                 
 |  \/  |                       | |                
 | \  / |   ___    _ __    ___  | |_    ___   _ __ 
 | |\/| |  / _ \  | '_ \  / __| | __|  / _ \ | '__|
 | |  | | | (_) | | | | | \__ \ | |_  |  __/ | |   
 |_|  |_|  \___/  |_| |_| |___/  \__|  \___| |_|   
                                                   
                                                   
");
            Console.Write("\n 1. New Game \t 3. Once upon a Time..." +
                "\n 2. Load \t 4. Exit" +
                "\n Your choice : ");
        }

        public void PrintAskName()
        {
            Console.WriteLine("Choose your Trainer Name : ");
        }

        public void PrintAskPet()
        {
            Console.WriteLine("Nice ! Now you have to choose your partner for this adventure !" +
                "\nFirst choice: Saicho ");
            PocketMonster.Saicho.PrintSaicho();

            Console.WriteLine("\nType: Fire" +
            "\nPV: 100" +
            "\nDescription: powerful but weaker" +
            "\nAttack: [1] Holy fire              [2] Blast" +
            "\n        [3] Flame Thrower (lvl 3)  [4] Zenith (lvl 5)" +
            "\n" +
             "\nSecond choice: Glouglou ");
            PocketMonster.Glouglou.PrintGlouglou();

            Console.WriteLine("\nType: water" +
            "\nPV: 150" +
            "\nDescription: Better than a Fish" +
            "\nAttack: [1] Aquatail               [2] O'Pistol" +
             "\n        [3] O'Spray (lvl 3)        [4] Siphon (lvl 5)" +
            "\nOr You can choose Glouglou who is a water fighter");


            Console.Write("1. Saicho" +
                          "\n2. Glouglou" +
                          "\nChoose Your New parterner : ");
        }

        public void PrintAskObject()
        {

            Console.WriteLine("You will get an object to start ! Choose the good one ! It could help you" +
                "\nYou can choose between Pickle or Viagra" +
                "\nEach of this object got special effect that you will discover");

            Console.Write("1. Pickle (Full Health)" +
                "\n2. Viagra (Level-Up Directly)" +
                "\nYour choice : ");
        }

        public static int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());

            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }


        public string AskStringChoice()
        {
            string text = Console.ReadLine();
            return text;
        }

        public void StartGame()
        {
            PrintAskName();
            string name = AskStringChoice();

            PrintAskPet();
            int pet = AskChoice(1, 2);

            PrintAskObject();
            int weapon = AskChoice(1, 2);

            Game g = new Game();
            g.ChoiceGame(name, pet, weapon);

        }

        public void LoadGame()
        {

        }

        public void About()
        {
            Console.Clear();

            Console.WriteLine("Welcome in a world where PocketMonster are your friend !\nThey could dominated the world " +
                "but they are too cute for that! So they fight with us for the power, the bitch and the drugs. " +
                "\nAnyway, you have to travel and fight a terrible ennemy : THE MULTIPLA !!! " +
                "\nIt's a Terrific surname for your bestfriend, he wants to dominate the world without you");

            Console.WriteLine(@"                 .""-,.__
                 `.     `.  ,
              .--'  .._,'""-' `.
             .    .'         `'
             `.   /          ,'
               `  '--.   ,-""'
                `""`   |  \
                   -. \, |
                    `--Y.'      ___.
                         \     L._, \
               _.,        `.   <  <\                _
             ,' '           `, `.   | \            ( `
          ../, `.            `  |    .\`.           \ \_
         ,' ,..  .           _.,'    ||\l            )  '"".
        , ,'   \           ,'.-.`-._,'  |           .  _._`.
      ,' /      \ \        `' ' `--/   | \          / /   ..\
    .'  /        \ .         |\__ - _ ,'` `        / /     `.`.
    |  '          ..         `-...-""  |  `-'      / /        . `.
    | /           |L__           |    |          / /          `. `.
   , /            .   .          |    |         / /             ` `
  / /          ,. ,`._ `-_       |    |  _   ,-' /               ` \
 / .           \""`_/. `-_ \_,.  ,'    +-' `-'  _,        ..,-.    \`.
.  '         .-f    ,'   `    '.       \__.---'     _   .'   '     \ \
' /          `.'    l     .' /          \..      ,_|/   `.  ,'`     L`
|'      _.-""""` `.    \ _,'  `            \ `.___`.'""`-.  , |   |    | \
||    ,'      `. `.   '       _,...._        `  |    `/ '  |   '     .|
||  ,'          `. ;.,.---' ,'       `.   `.. `-'  .-' /_ .'    ;_   ||
|| '              V      / /           `   | `   ,'   ,' '.    !  `. ||
||/            _,-------7 '              . |  `-'    l         /    `||
. |          ,' .-   ,' ||               | .-.        `.      .'     ||
 `'        ,'    `"".'    |               |    `.        '. -.'       `'
          /      ,'      |               |,'    \-.._,.'/'
          .     /        .               .       \    .''
        .`.    |         `.             /         :_,'.'
          \ `...\   _     ,'-.        .'         /_.-'
           `-.__ `,  `'   .  _.>----''.  _  __  /
                .'        /""'          |  ""'   '_
               /_|.-'\ ,"".             '.'`__'-( \
                 / ,""'""\,'               `/  `-.|"" ");

            Console.Write("\nPress Enter to return");
            Console.ReadLine();
            Console.Clear();
            Menu M1 = new Menu();
        }

        public void Quit()
        {
            Console.Write("Thank's ! See you Later" +
                "\nPress any key to close the game");
            Console.ReadLine();
        }
    }
}

