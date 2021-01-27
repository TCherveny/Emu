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

            Console.WriteLine($"One of my emu's is named {emuName}. \n" +
                $"{emuName} is {emuAge} years old.\n" +
                $"{emuName} is a {emuHeight} feet tall.\n" +
                $"{emuName} has claws that are {emuClaw} feet long.\n" +
                $"{emuName} is soft is a {isSoft} statement.\n" +
                $"{emuName} has a girlfriend named Rita.");

            emuName = "Rita";

            double eggWeight2 = 1.5;



            Console.WriteLine($"{emuName} lays eggs that weigh approx {eggWeight1} to {eggWeight2} pounds.");
        }
    }
}
