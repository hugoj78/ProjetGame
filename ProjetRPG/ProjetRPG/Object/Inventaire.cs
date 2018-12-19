using System;
namespace ProjetRPG.Object
{
    // Class Inventaire ( Heritage : Parent de ItemStart et Item)
    public class Inventaire
    {
        public string Name;
        public string Description;
        public float Value;

        // Constructeur de Inventaire
        public Inventaire(string name, string descript, float v)
        {
            Name = name;
            Description = descript;
            Value = v;
        }

        // Fonction print : Affiche l'Item de l'inventaire 
        public void Print()
        {
            Console.WriteLine(Name + " : " + Description + "(" + Value +")");
        }

        // Fonction PickUp : Indique au joueur qu'il a un nouvelle item
        public virtual void PickUp()
        {
            Console.WriteLine("You got: " + Name + " ( " + Description + ")");
        }

        // Fonction Use : selon l'object a un effet sur le joueur
        public virtual void Use(Player.Player p)
        {
            Console.WriteLine("You used : " + Name);
        }
    }
}
