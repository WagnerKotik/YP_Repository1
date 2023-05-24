using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoDen.Entities
{
    partial class Purchase
    {
        public string Filmer
        {
            get
            {
                return Film.NameFilm;
            }
        }
        public string ProviderName
        {
            get
            {
                return Provider.NameProvider;
            }
        }
    }
}
