using System;

namespace RPGClasses
{
    abstract class Character
    {
        protected string name;
        public string Name
        {
            get { return name; }
        }
        protected string gender;
        protected int hitPoints;
        protected int strength;
        protected int dexterity;
        public int Dexterity
        {
            get { return dexterity; }
        }
        protected int constitution;
        protected int intelligence;
        protected int wisdom;
        protected int charisma;

        public Character()
        {
            this.name = "";
            this.gender = "";
            this.hitPoints = 8;
            this.strength = 10;
            this.dexterity = 10;
            this.constitution = 10;
            this.intelligence = 10;
            this.wisdom = 10;
            this.charisma = 10;
        }
    }
}
