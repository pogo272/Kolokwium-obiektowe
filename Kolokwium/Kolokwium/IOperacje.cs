using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    interface IOperacje
    {
        void Dodaj(string nazwa ,int powierzchnia ,string nazwaa ,bool lotnisko);
        void Usun();
        void Usun(string nazwa);
    }
}
