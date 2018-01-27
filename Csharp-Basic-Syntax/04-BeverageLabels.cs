using System;
using System.Collections.Generic;
using System.Linq;


namespace _04__BeverageLabels
{
    class BeverageLabels
    {
        static void Main()
        {
            string name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energyPer100Ml = double.Parse(Console.ReadLine());
            var sugarPer100Ml = double.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(energyPer100Ml * volume) / 100}kcal, {(sugarPer100Ml * volume) / 100}g sugars");




        }
    }
}
