using System;
namespace ProjetRPG.PocketMonster
{
    class Glouglou : Player.Player
    {

        public Glouglou(int n):base(n)
        {

        }

        public static int AttackGlouglou(int choice)
        {
            switch (choice)
            {
                case 1:
                    return 10;
                case 2:
                    return 15;
                case 3:
                    return 25;
                case 4:
                    return 50;
                default:
                    return 0;
            }
        }

        public static void PrintGlouGlouAttack(int level)
        {

            if (level < 3)
                Console.Write("[1] Aquatail(10)           [2] O'Pistol(15)" +
                	"\nYour Choice : ");
            else if (level >= 3 && level < 5)
                Console.Write("[1] Aquatail(10)           [2] O'Pistol(15)" +
                                "\n[3] O'Spray(20)" +
                                "\nYour Choice : ");
            else if (level >= 5)
                Console.Write("[1] Aquatail(10)           [2] O'Pistol(15)" +
                                "\n[3] O'Spray(25)            [4] Siphon(50)" +
                                "\nYour Choice : ");
        }



        public static void PrintGlouglou()
        {
            Console.WriteLine(@"     __                                _.--'""7
    `. `--._                        ,-'_,-  ,'
     ,'  `-.`-.                   /' .'    ,|
     `.     `. `-     __...___   /  /     - j
       `.     `  `.-""""        "" .  /       /
         \     /                ` /       /
          \   /                         ,'
          '._'_               ,-'       |
             | \            ,|  |   ...-'
             || `         ,|_|  |   | `             _..__
            /|| |          | |  |   |  \  _,_    .-""     `-.
           | '.-'          |_|_,' __!  | /|  |  /           \
   ,-...___ .=                  ._..'  /`.| ,`,.      _,.._ |
  |   |,.. \     '  `'        ____,  ,' `--','  |    /      |
 ,`-..'  _)  .`-..___,---'_...._/  .'      '-...'   |      /
'.__' """"'      `.,------'""'      ,/            ,     `.._.' `.
  `.             | `--........,-'.            .         \     \
    `-.          .   '.,--""""     |           ,'\        |      .
       `.       /     |          L          ,\  .       |  .,---.
         `._   '      |           \        /  .  L      | /   __ `.
            `-.       |            `._   ,    l   .    j |   '  `. .
              |       |               `""' |  .    |   /  '      .' |
              |       |                   j  |    |  /  , `.__,'   |
              `.      L                 _.   `    j ,'-'           |
               |`""---..\._______,...,--' |   |   /|'      /        j
               '       |                 |   .  / |      '        /
                .      .              ____L   \'  j    -',       /
               / `.     .          _,""     \   | /  ,-','      ,'
              /    `.  ,'`-._     /         \  i'.,'_,'      .'
             .       `.      `-..'             |_,-'      _.'
             |         `._      |            ''/      _,-'
             |            '-..._\             `__,.--'
            ,'           ,' `-.._`.            .
           `.    __      |       ""'`.          |
             `-""'  `""""""""'            7         `.
                                    `---'--.,'""`'");
        }
    }
}
