using System;

namespace MyFavoriteThings
{
    class Motorcycles
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }

        public Motorcycles(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}