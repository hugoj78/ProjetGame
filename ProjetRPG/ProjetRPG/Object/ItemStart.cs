using System;
namespace ProjetRPG.Object
{
    // Class ItemStart ( Heritage : enfant de Inventaire )
    public class ItemStart : Inventaire
    {
        public enum ItemType {Pickle, Viagra};

        public ItemType Type;

        // Construteur de ItemStart
        public ItemStart(string name, string descript, float v, ItemType t) : base(name, descript, v)
        {
            Type = t;
        }

        // Fonction PickUp : Indique au joueur qu'il a un nouvelle item
        public override void PickUp()
        {
            base.PickUp();
            Console.WriteLine("You got a new Item");
        }

        // Fonction Use : selon l'object a un effet sur le joueur
        public override void Use(Player.Player p)
        {
            base.Use(p);
            switch (Type)
            {
                case ItemType.Pickle:
                    if (p.Pet == Player.Player.PocketMonster.Glouglou)
                        p.PV = 150;
                    else
                    {
                        p.PV = 100;
                    }
                    break;
                case ItemType.Viagra:
                    p.Level++;
                    Console.WriteLine("YOU LEVEL UP : "  + p.Level);
                    break;
            }

            Console.WriteLine("You have use an Item");
        }
    }
}
