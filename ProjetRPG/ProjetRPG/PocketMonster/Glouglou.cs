﻿using System;
namespace ProjetRPG.PocketMonster
{
    class Glouglou : Player.Player
    {

        public Glouglou(int n):base(n)
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
            if (Level<= 3)
                return 20;
            else
            {
                return 0;
            }
        }

        public int Siphon()
        {
            if (Level <= 5)
                return 25;
            else
            {
                return 0;
            }
        }

        public static void PrintGlouGlouAttack(int level)
        {
            if (level < 3)
                Console.WriteLine("[1] Holy fire             [2] Blast");
            else if (level >= 3 && level < 5)
                Console.WriteLine("[1] Holy fire             [2] Blast" +
                                "\n[3] Flame Thrower");
            else if (level >= 5)
                Console.WriteLine("[1] Holy fire             [2] Blast" +
                                "\n[3] Flame Thrower         [4] Zenith(lvl 5)");

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
