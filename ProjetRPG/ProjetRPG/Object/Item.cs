using System;
namespace ProjetRPG.Object
{
    // Class Item ( Heritage : enfant de Inventaire )
    public class Item : Inventaire
    {
        public enum ItemType { Heal, Level, HealUp };

        public ItemType Type;

        // Construteur de Item
        public Item(string name, string descript, float v, ItemType t) : base(name, descript, v)
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
                case ItemType.Heal:
                    p.PV += 10;
                    break;
                case ItemType.HealUp:
                    if (p.Pet == Player.Player.PocketMonster.Glouglou)
                        p.PV = 150;
                    else if (p.Pet == Player.Player.PocketMonster.Saicho)
                    {
                        p.PV = 100;
                    }
                    break;
                case ItemType.Level:
                    p.Level++;
                    Console.WriteLine("YOU LEVEL UP : " + p.Level);

                    break;
            }
            Console.WriteLine("You have use an Item");
        }
    }
}