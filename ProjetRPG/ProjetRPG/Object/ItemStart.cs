using System;
namespace ProjetRPG.Object
{
    public class ItemStart : Inventaire
    {
        public enum ItemType { Heal, Defense, Attack };

        public ItemType Type;
        public ItemStart(string name, string descript, float v, float w, ItemType t) : base(name, descript, v, w)
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
