﻿using System;
namespace ProjetRPG.PocketMonster
{
    class Saicho 
    {

        public static void PrintSaichoAttack(int level)
        {
            if (level < 3)
            {
                Console.Write("[1] Holy fire(20)         [2] Blast(30)" +
                              "\nYour Choice : ");
            }
            else if (level >= 3 && level < 5)
            {
                Console.Write("[1] Holy fire(20)         [2] Blast(30)" +
                                "\n[3] Flame Thrower(40)" +
                                "\nYour Choice : ");
            }
            else if (level >= 5)
            {
                Console.Write("[1] Holy fire(20)         [2] Blast(30)" +
                                "\n[3] Flame Thrower(40)     [4] Zenith(80)" +
                                "\nYour Choice : ");
            }
        }

        public static int AttackGlouglou(int choice)
        {
            switch (choice)
            {
                case 1:
                    return 20;
                case 2:
                    return 30;
                case 3:
                    return 40;
                case 4:
                    return 80;
                default:
                    return 0;
            }
        }


        public static void PrintSaicho()
        {
            Console.WriteLine(@"              _.--""""`-..
            ,'          `.
          ,'          __  `.
         /|          "" __   \
        , |           / |.   .
        |,'          !_.'|   |
      ,'             '   |   |
     /              |`--'|   |
    |                `---'   |
     .   ,                   |                       ,"".
      ._     '           _'  |                    , ' \ `
  `.. `.`-...___,...---""""    |       __,.        ,`""   L,|
  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \
-:..     `. `-..--_.,.<       `""      / `.        `-/ |   .
  `,         """"""""'     `.              ,'         |   |  ',,
    `.      '            '            /          '    |'. |/
      `.   |              \       _,-'           |       ''
        `._'               \   '""\                .      |
           |                '     \                `._  ,'
           |                 '     \                 .'|
           |                 .      \                | |
           |                 |       L              ,' |
           `                 |       |             /   '
            \                |       |           ,'   /
          ,' \               |  _.._ ,-..___,..-'    ,'
         /     .             .      `!             ,j'
        /       `.          /        .           .'/
       .          `.       /         |        _.'.'
        `.          7`'---'          |------""'_.'
       _,.`,_     _'                ,''-----""'
   _,-_    '       `.     .'      ,\
   -"" /`.         _,'     | _  _  _.|
    """"--'---""""""""""'        `' '! |! /
                            `"" "" -' ");
        }
    }
}
