using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings
{
    class Comedians
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string BestWork { get; }

        public Comedians(string firstname, string lastname, string bestwork)
        {
            FirstName = firstname;
            LastName = lastname;
            BestWork = bestwork;
        }

    }
}
