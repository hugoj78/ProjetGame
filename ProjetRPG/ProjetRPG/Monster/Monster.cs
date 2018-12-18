using System;
namespace ProjetRPG.Monster
{
    class Monster
    {

        public static void PrintMonsterPV(int PV)
        {
            Console.WriteLine("PV : " + PV);
        }

        public static void PrintPhraseAtt()
        {
            Console.WriteLine("LE MONSTRE AAAATTTTTAAAAAAAQQQQQQQUUUUUUUEEEEEE");
        }

        public static void PrintMonsterStory2()
        {
            Console.WriteLine(@"
KENNY :

          _.-*'""""'*-._
       .-""            ""-.
     ,""                  "",
   .'      _.-.--.-._      ',
  /     .-'.-""    ""-.'-.     \
 /     /  /""'-.  .-'""\  \     \
:     :  :     ;:     ;  ;     ;
;     :  ; *   !! *   :  ;     :
;      ; :   .'  '.   ; :      :
:       \ \-'      '-/ /       ;
 \       '.'-_    _-'.'       /
  \        '*-""-+""-*'        /
   '.          /|          .'
     *,       / |        ,*
     / '-_            _-'  \
    /     ""*-.____.-*""      \
   /            |            \
  :    :        |        ;    ;
  |.--.;        |        :.--.|
  (   ()        |        ()   )
   '--^_        |        _^--'
      | ""'*--.._I_..--*'"" |
      | __..._  | _..._   |
     .'""      `""'""     ''""'.");
        }
    }
}
