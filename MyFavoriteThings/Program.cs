using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmw = new Motorcycles("BMW", "R1150-RT", 2005);

            var honda = new Motorcycles("Honda", "Nighthawk 700SC", 1986);

            var grassroots = new Beer("Calfkiller", "Grassroots", "APA");

            var getUpGetDown = new Beer("Wiseacre", "Gotta Get Up To Get Down", "Stout");

            Console.WriteLine("These are my current favorite motorcycles:");
            Console.WriteLine(bmw.Year + " " + bmw.Make + " " + bmw.Model);
            Console.WriteLine(honda.Year + " " + honda.Make + " " + honda.Model);
            Console.WriteLine("");
            Console.WriteLine("These are some of my favorite beers:");
            Console.WriteLine(grassroots.Brand + " " + grassroots.Name + " is an " + grassroots.Type);
            Console.WriteLine(getUpGetDown.Brand + " " + getUpGetDown.Name + " is a " + getUpGetDown.Type);


            Console.ReadKey();

        }
    }
}
