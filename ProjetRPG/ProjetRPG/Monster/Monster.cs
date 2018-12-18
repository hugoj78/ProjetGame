﻿using System;
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

        public static void PrintMonsterStory(int Dmg)
        {
            if (Dmg == 5)
            {
                Console.WriteLine(@"
KENNY :

          _.-*'""""'*-._
       .-""            ""-.
     ,""                  "",
   .'      _.-.--.-._       ',
  /     .-'.-""    ""-.'-.    \
 /     /  /""'-.  .-'""\  \    \
:     :  :     ;:     ;  ;     ;
;     :  ; *   !! *   :  ;     :
;      ; :   .'  '.   ; :      :
:       \ \-'      '-/ /       ;
 \       '.'-_    _-'.'       /
  \        '*-""-+""-*'      /
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
            else if (Dmg == 10)
            {
                Console.WriteLine(@"                       
CARTMAN :
                       _.-**-._
                    _,(        ),_
                 .-""   '-^----'   ""-.
              .-'                    '-.
            .'                          '.
          .'    __.--**'""""""""""""'**--.__    '.
         /_.-*""'__.--**'""""""""""""'**--.__'""*-._\
        /_..-*""'   .-*""*-.  .-*""*-.   '""*-.._\
       :          /       ;:       \          ;
       :         :     *  !!  *     :         ;
        \        '.     .'  '.     .'        /
         \         '-.-'      '-.-'         /
      .-*''.                              .'-.
   .-'      '.                          .'    '.
  :           '-.        _.._        .-'        '._
 ;""*-._          '-._  --___ `   _.-'        _.*'  '*.
:      '.            `""*-.__.-*""`           (        :
 ;      ;                 *|                 '-.     ;
  '---*'                   |                    """"--'
   :                      *|                      :
   '.                      |                     .'
     '.._                 *|        ____----.._-'
      \  """"""----_____------'-----""""""         /
       \  __..-------.._        ___..---._  /
       :'""              '-..--''          ""';
        '""""""""""""""""""""""""""""""""' '""""""""""""""""""""""""""""""' ");
            }

        }
    }
}
