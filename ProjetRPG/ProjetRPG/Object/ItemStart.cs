using System;
namespace ProjetRPG.Object
{
    public class ItemStart : Inventaire
    {
        public enum ItemType {Pickle, Viagra, Pepper, Friendzone};

        public ItemType Type;

        public ItemStart(string name, string descript, float v, ItemType t) : base(name, descript, v)
        {
            Type = t;
        }


        public override void PickUp()
        {
            base.PickUp();
            Console.WriteLine("You got a new Item");
        }

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
