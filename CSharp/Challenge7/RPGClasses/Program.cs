using System;

namespace RPGClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("This Code Makes a rogue that sneak attacks you!");
            Console.WriteLine("------------------------------------------------");
            Rogue Bilbo = new Rogue("Bilbo");
            Bilbo.sneakAttack();
            Console.WriteLine($"{Bilbo.Name}'s dexterity ({Bilbo.Dexterity}) is higher than other characters because he is a Rogue.");
        }
    }
}
