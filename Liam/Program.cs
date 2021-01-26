using System;

namespace Liam
{
    class Program
    {
        static void Main(string[] args)
        {
            string emuName = "Liam";

            double emuAge = 1.5;

            int emuHeight = 5;

            bool isSoft = true;

            decimal emuClaw = .4m;

            char eggWeight1 = '1';

            Console.WriteLine($"One of my emu's is named {emuName}.");
            Console.WriteLine($"{emuName} is {emuAge} years old.");
            Console.WriteLine($"{emuName} is a {emuHeight} feet tall.");
            Console.WriteLine($"{emuName} has claws that are {emuClaw} feet long.");
            Console.WriteLine($"{emuName} is soft is a {isSoft} statement.");
            Console.WriteLine($"{emuName} has a girlfriend named Rita.");

            emuName = "Rita";

            double eggWeight2 = 1.5;



            Console.WriteLine($"{emuName} lays eggs that weigh approx {eggWeight1} to {eggWeight2} pounds.");
        }
    }
}
