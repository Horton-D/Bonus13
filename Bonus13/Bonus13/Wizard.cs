using System;
namespace Bonus13
{
    public class Wizard : MagicUsingChracter
    {
        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence,magicalEnergy)
        {
            
            SpellNumber = spellNumber;
        }

        public int SpellNumber { get; set; }

        public override string Play()
        {
            return $"{base.Play()} - {MagicalEnergy} - { SpellNumber}";
        }
    }
}
