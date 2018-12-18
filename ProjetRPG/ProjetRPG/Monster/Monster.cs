using System;
namespace ProjetRPG.Monster
{
    class Monster
    {
        public int MonsterDmg(int dmg)
        {
            return dmg;
        }

        public static void PrintMonsterPV(int PV)
        {
            Console.WriteLine("PV : " + PV);
        }

        public static void PrintMonsterStory2()
        {
            Console.WriteLine(@"          _.-*'""""'*-._
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
