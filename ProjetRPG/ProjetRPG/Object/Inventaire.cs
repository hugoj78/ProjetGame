using System;
namespace ProjetRPG.Object
{
    public class Inventaire
    {
        public string Name;
        public string Description;
        public float Value;

        public Inventaire(string name, string descript, float v)
        {
            Name = name;
            Description = descript;
            Value = v;
        }

        public void Print()
        {
            Console.WriteLine(Name + " : " + Description);
        }

        public virtual void PickUp()
        {
            Console.WriteLine("You got:" + Name);
        }

        public virtual void Use()
        {
            Console.WriteLine("You used :" + Name);
        }
    }
}
