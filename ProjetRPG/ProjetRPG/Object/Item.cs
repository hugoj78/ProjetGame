using System;
namespace ProjetRPG.Object
{
    public class Item : Inventaire
    {
        public enum ItemType { Heal, Dmg, Level, block, HealUp };

        public ItemType Type;
        public Item(string name, string descript, float v, ItemType t) : base(name, descript, v)
        {
            Type = t;
        }

        public override void PickUp()
        {
            base.PickUp();
            Console.WriteLine("You got a new Item");
        }

        public override void Use()
        {
            base.Use();
            Console.WriteLine("You have use an Item");
        }
    }
}