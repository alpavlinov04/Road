using System;

namespace road
{
    class Program
    {
        static void Main(string[] args)
        {
            Road firstRoad = new Road();
            Road secondRoad = new Road("Highway", 140, 1550, 4, "E79");
            Console.WriteLine(firstRoad);
            Console.WriteLine(secondRoad);
        }
    }
}
