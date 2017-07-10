using System;
using System.Collections.Generic;

namespace hashsets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> showRoom = new HashSet<string>();

            showRoom.Add("Wrangler");
            showRoom.Add("Cherokee");
            showRoom.Add("Commanche");
            showRoom.Add("Jeepster");
            showRoom.Add("Wrangler");

            Console.WriteLine(showRoom.Count);

            HashSet<string> usedLot = new HashSet<string>();

            usedLot.Add("Explorer");
            usedLot.Add("Bronco");

            showRoom.UnionWith(usedLot);

            showRoom.Remove("Explorer");

            HashSet<string> junkYard = new HashSet<string>();

            // junkYard.Add("Wrangler");
            junkYard.Add("F-150");
            junkYard.Add("s-10");
            junkYard.Add("Tundra");
            junkYard.Add("LandRover");


            // junkYard.IntersectWith(showRoom);

            showRoom.UnionWith(junkYard);

            showRoom.Remove("Tundra");

            Console.WriteLine(showRoom.Count);

            foreach (var item in showRoom)
            {
                Console.WriteLine(item);
            }


        }
    }
}
