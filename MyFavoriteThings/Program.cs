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

            var elijah = new Whiskey("Elijah Craig", "Small Batch", "94");

            var balcones = new Whiskey("Balcones", "True Blue", "100");

            var sarah = new Comedians("Sarah", "Silverman", "Jesus Is Magic");

            var cross = new Comedians("David", "Cross", "Mr. Show");


            Console.WriteLine("These are my current favorite motorcycles:");
            Console.WriteLine(bmw.Year + " " + bmw.Make + " " + bmw.Model);
            Console.WriteLine(honda.Year + " " + honda.Make + " " + honda.Model);
            Console.WriteLine("");
            Console.WriteLine("These are some of my favorite beers:");
            Console.WriteLine(grassroots.Brand + " " + grassroots.Name + " is an " + grassroots.Type);
            Console.WriteLine(getUpGetDown.Brand + " " + getUpGetDown.Name + " is a " + getUpGetDown.Type);
            Console.WriteLine("");
            Console.WriteLine("These are some of my favorite whiskeys:");
            Console.WriteLine(elijah.Brand + " " + elijah.Name + " is " + elijah.Proof + " proof");
            Console.WriteLine(balcones.Brand + " " + balcones.Name + " is " + balcones.Proof + " proof");
            Console.WriteLine("");
            Console.WriteLine("These are some of my favorite comedians:");
            Console.WriteLine(sarah.FirstName + " " + sarah.LastName + " was awesome in '" + sarah.BestWork + "'");
            Console.WriteLine(cross.FirstName + " " + cross.LastName + " was awesome in '" + cross.BestWork + "'");

            Console.ReadKey();

        }
    }
}
