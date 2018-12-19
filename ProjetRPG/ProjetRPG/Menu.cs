using System;
using System.IO;

namespace ProjetRPG
{
    public class Menu
    {

        // Fonction Menu
        public Menu()
        {
            // Fonction Print Menu : Affiche le Menu
            PrintMenu();

            // On demande l'utilisateur un choix compris entre 1 et 4
            int choix = AskChoice(1, 4);

            // Selon le choix de l'utilisateur on appelle d'autre fonction
            switch (choix)
            {
                case 1:
                    // On Clear le terminal
                    // Puis on Lance le jeu avec la fonction StartGame()
                    Console.Clear();
                    StartGame();
                    break;
                case 2:
                    // Fonction Load game : recupère la derniere sauvegarde
                    LoadGame();
                    break;
                case 3:
                    // Fonction About : Affiche le A Propos
                    About();
                    break;
                case 4:
                    // Fonction Quit : Quitte le jeu
                    Quit();
                    break;
                default:
                    break;
            }
        }

        // Fonction printMenu : Affiche le Menu
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

        // Function PrintAskName : affiche la demande du nom
        public void PrintAskName()
        {
            Console.WriteLine("Choose your Trainer Name : ");
        }

        // Function PrintAskPet : affiche la demande du pocket monster
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

        // Function PrintAskObject : affiche la demande de l'objet
        public void PrintAskObject()
        {

            Console.WriteLine("You will get an object to start ! Choose the good one ! It could help you" +
                "\nYou can choose between Pickle or Viagra" +
                "\nEach of this object got special effect that you will discover");

            Console.Write("1. Pickle (Full Health)" +
                "\n2. Viagra (Level-Up Directly)" +
                "\nYour choice : ");
        }

        // Fonction AskChoice : ReadLine obligeant l'utilisateur de fournir une reponse entre un minimum et un maximum
        public static int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());

            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }


        // Fonction AskStringChoice : Readline d'un string
        public string AskStringChoice()
        {
            string text = Console.ReadLine();
            return text;
        }


        // Fonction StartGame : Demande le nom, le pocket monster et l'objet de depart puis demarre le jeu avec les paramètres rentrer par l'utilisateur
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

        // Fonction LoadGame : Permet de charger une sauvegarde si elle existe
        public void LoadGame()
        {
            // La sauvegarde s'appelle save.txt et est enregistré sur le bureau si elle existe
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/save.txt";

            // On essaie de recuperer les informations 
            try
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    string l;

                    l = sr.ReadLine();

                    // Les informations stockées sont séparés par un ";"
                    string[] parts = l.Split(';');

                    // Puis on les assignes a des variables
                    string n = parts[0];
                    string p = parts[1];
                    string w = parts[2];
                    int pos = int.Parse(parts[3]);
                    int lv = int.Parse(parts[4]);
                    int pv = int.Parse(parts[5]);

                    // Puis on relance le jeu avec les parametres recuperes
                    Game g = new Game();
                    g.LoadGame(n, p, w, pos, lv, pv);
                }
            }
            // Si il n'y a pas de fichier save
            // Alors on relance un Menu disant qu'il n'y a pas de sauvegarde
            catch
            {
                Console.WriteLine("No save found");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Menu m1 = new Menu();
            }



        }


        // Fonction SaveGame : Sauvegarde l'etat d'avancé du joueur dans le jeu au moment demandé
        public static void SaveGame(Player.Player p) 
        {
            // On sauvegarde dans un fichier sur le bureau nommée save.txt
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter s = new StreamWriter(mydocpath + @"/save.txt"))
            {
                // On rentre les informations du joueur
                s.WriteLine(p.Name + ";" + p.Pet + ";" + p.Item + ";" + p.Position + ";" + p.Level + ";" + p.PV);
            }

            // Puis on Quitte le jeu
            Console.Write("Press Enter to Quit ...");
            Console.ReadLine();
            Environment.Exit(0);
        }

        // Fonction About : Affiche le A Propos
        public void About()
        {
            Console.Clear();

            Console.WriteLine("Welcome to a world where PocketMonster are your friend ! " +
            	"\nThey could dominated the world but they are too cute for that! " +
            	"\nSo they fight with us for the power. " +
            	"\nAnyway, you have to travel and reach the end to fight a terrible enemy : The Magician !!! " +
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

        // Fonction Quit : Quitte le jeu
        public void Quit()
        {
            Console.Write("Thank's ! See you Later" +
                "\nPress any key to close the game");
            Console.ReadLine();
        }
    }
}

