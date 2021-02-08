using System;
using System.Collections.Generic;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameCharacter = new List<GameChracter>();

            gameCharacter.Add(new Warrior("Jason", 53, 70, 4, 12, "Hatchet"));
            gameCharacter.Add(new Warrior("Kristy", 60, 70, 80, 90, "Saw"));
            gameCharacter.Add(new Wizard("John", 96, 67, 78, 89));
            gameCharacter.Add(new Wizard("Ben", 55, 97, 38, 99));
            gameCharacter.Add(new Wizard("Sara", 26, 37, 88, 89));

            foreach (var item in gameCharacter)
            {
                Console.WriteLine(item.Play());
            }

        }

    }
}
