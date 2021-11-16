using System;

namespace RPGClasses
{
    class Rogue : PlayerChar
    {
        public Rogue(string inputName)
        {
            this.playerClass = "Rogue";
            this.dexterity = 18;
            this.name = inputName;
        }
        public void sneakAttack()
        {
            Console.WriteLine($"{this.name} attacked from the shadows!");
        }
    }
}
