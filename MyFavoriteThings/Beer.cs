using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Beer
    {
        public string Brand { get; }
        public string Name { get;  }
        public string Type { get;  }

        public Beer(string brand, string name, string type)
        {
            Brand = brand;
            Name = name;
            Type = type;
        }
    }
}
