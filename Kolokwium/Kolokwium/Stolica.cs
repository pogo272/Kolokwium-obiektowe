using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Stolica
    {
        private string nazwa;
        private bool lotnisko;

        public Stolica(string nazwa, bool lotnisko)
        {
            this.nazwa=nazwa;
            this.lotnisko=lotnisko;
        }
        public override string ToString()
        {
            
            return "Stolica:" + nazwa + ",lotnisko" + lotnisko;
            
        }
    }
}
