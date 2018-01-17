using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Kraj:IComparable<Kraj>
    {
        private string nazwa;
        private int powierzchnia;
        
        
        private Kraj(string nazwa, int powierzchnia)
        {
            this.nazwa = nazwa;
            this.powierzchnia = powierzchnia;
        }
        public static Kraj UtworzKraj(string nazwa, int powierzchnia)
        {
           Kraj Polska= new Kraj(nazwa,powierzchnia);
           return Polska;
        }
        
        public string ToString()
        {
             return "Kraj:" + nazwa + ",powierzchnia" + powierzchnia;
        }
        public int CompareTo(Kraj other)
        {
            if (this.powierzchnia == other.powierzchnia)
            {
                return this.nazwa.CompareTo(other.nazwa);
            }
            return other.powierzchnia.CompareTo(this.powierzchnia);
        }


    }
}
