using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoDen.Entities
{
    partial class Rent
    {
        public string Cinemer
        {
            get
            {
                return Cinema.NameCinema;
            }
        }
        public string Filmer2
        {
            get
            {
                return Film.NameFilm;
            }
        }
    }
}
