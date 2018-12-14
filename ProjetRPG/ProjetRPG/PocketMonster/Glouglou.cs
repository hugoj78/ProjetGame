﻿using System;
namespace ProjetRPG.PocketMonster
{
    class Glouglou : Player.Player;
    {
        public int level;

        public Glouglou(string n) : base(n)
        {
            
        }

        public int Aquatail()
        {
            return 10;
        }

        public int OPistol()
        {
            return 15;
        }

        public int OSpray()
        {
            if (level<= 3)
                return 20;
            else
            {
                return 0;
            }
        }

        public int Siphon()
        {
            if (level <= 5)
                return 25;
            else
            {
                return 0;
            }
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
