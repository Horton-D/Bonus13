using System;
namespace Bonus13
{
    public class GameChracter
    {
        public GameChracter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;

        }

        

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }


        public virtual string Play()
        {
            return $"{Name} - {Strength} - {Intelligence}";
        }
    }





}


