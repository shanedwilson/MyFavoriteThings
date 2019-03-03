using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Whiskey
    {
        public string Brand { get; }
        public string Name { get; }
        public string Proof { get; }

        public Whiskey(string brand, string name, string proof)
        {
            Brand = brand;
            Name = name;
            Proof = proof;
        }
    }
}
