using System;
namespace ProjetRPG.Battle
{
    class Battle
    {
        public static void IsPlayerDead()
        {
            if (Player.Player.P1.PV <= 0 || Player.Player.P1.PV <= 0)
            {
                Console.Clear();
                Console.WriteLine("Damn your ennemy kick your ass so bad!");
                Console.WriteLine("You lose the Game, Try to be better next time!");
                Console.WriteLine(@"   _____          __  __ ______    ______      ________ _____  
  / ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
 | |  __   /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
 | | |_ | / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
 | |__| |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
  \_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
                                                               
                                                               ");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(Monster PV, Person person2)
        {
            Monster.PrintStats();
            Console.WriteLine("");
            BestFriend.PrintStats();
            Console.WriteLine("");
        }

        public static void WithBandit(Hero hero, Bandit bandit)
        {
            while (bandit.health > 0 && hero.health > 0)
            {
                PrintTheStats(bandit, hero);

                hero.YourTurn(hero.Choice(), bandit);

                if (bandit.health > 0)
                {
                    bandit.BanditTurn(bandit.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} was killed!", bandit.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithKnight(Hero hero, Knight knight)
        {
            while (knight.health > 0 && hero.health > 0)
            {
                PrintTheStats(knight, hero);

                hero.YourTurn(hero.Choice(), knight);

                if (knight.health > 0)
                {
                    knight.KnightTurn(knight.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine("{0} was killed!", knight.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithDragon(Hero hero, Dragon dragon)
        {
            while (dragon.health > 0 && hero.health > 0)
            {
                PrintTheStats(dragon, hero);

                hero.YourTurn(hero.Choice(), dragon);

                if (dragon.health > 0)
                {
                    dragon.DragonTurn(dragon.EChoice(), hero);
                    IsHeroDead(hero);
                }
            }

            Console.WriteLine("{0} was killed !", dragon.name);
            Console.ReadLine();
            Console.Clear();
        }
    }
}