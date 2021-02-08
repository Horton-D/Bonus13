using System;
namespace Bonus13
{
    public class Warrior : Wizard  
    {
        public Warrior(string name, int strength, int intelligence, int magicalEnergy, int spellNumber, string weaponType) : base(name, strength, intelligence, magicalEnergy, spellNumber)
        {
            WeaponType = weaponType;
        }

        public string WeaponType { get; set; }


        public override string Play()
        {
            return $"{base.Play()} - {MagicalEnergy} - {SpellNumber} {WeaponType}";
        }
    }
}