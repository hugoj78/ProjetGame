using System;
namespace ProjetRPG.PocketMonster
{
    class Saicho : Player.Player
    {
        public Saicho(int n) : base(n)
        {

        }

        public static void PrintSaichoAttack(int level)
        {
            if (level < 3)
            {
                Console.WriteLine("[1] Holy fire             [2] Blast");
            }
            else if (level >= 3 && level < 5)
            {
                Console.WriteLine("[1] Holy fire             [2] Blast" +
                                "\n[3] Flame Thrower");
            }
            else if (level >= 5)
            {
                Console.WriteLine("[1] Holy fire             [2] Blast" +
                                "\n[3] Flame Thrower         [4] Zenith(lvl 5)");
            }
        }

        public static int AttackGlouglou(int choice)
        {
            switch (choice)
            {
                case 1:
                    return 15;
                case 2:
                    return 25;
                case 3:
                    return 30;
                case 4:
                    return 35;
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
