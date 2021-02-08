using System;
namespace Bonus13
{
    public class MagicUsingChracter : GameChracter
    {
        public MagicUsingChracter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public int MagicalEnergy { get; set; }
    

        public override string Play()
        {
            return $"{base.Play()} -  {MagicalEnergy}";
        }

    }



}

