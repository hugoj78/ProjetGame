namespace ProjetRPG.Player
{
    // Class Player
    public class Player
    {
        public enum PocketMonster { Saicho, Glouglou};
        public enum Objet { Pickle, Pepper, Friendzone, Viagra}

        public string Name;
        public PocketMonster Pet;
        public Objet Item;
      
        public int PV;
        public int Level;
        public int Count_Inventaire;
        public int Position;

        // Constructeur Player : selon les choix de l'utilisteur créer un Player avec diffents parametre
        public Player(string na, PocketMonster p, Objet i)
        {
            Name = na;
            Pet = p;
            Item = i;

            Count_Inventaire = 0;
            Position = 1;


            if (p == PocketMonster.Saicho)
            {
                PV = 100;
                Level = 1;

            } 
            else if (p == PocketMonster.Glouglou)
            {
                PV = 150;
                Level = 1;
            }
        }

        // Fonction Ask Attack : retourne le niveau du joueur
        // Fonction qui sert a retourner le nombre de choix possible
        // d'attaque selon les niveau
        // Car au niveau 3 et 5 le pocket monster debloque des attaques
       public static int AskAttack(int level)
        {
            if (level >= 3 && level < 5)
            {
                return 3;
            }
            if (level >= 5)
            {
                return 4;
            }

            return 2;

        }
    }
}
