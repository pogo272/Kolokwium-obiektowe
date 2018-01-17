using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Aplikacja start = new Aplikacja();

            start.Wystartuj();
            while (true)
            {
                start.WczytajKlawisz();
            }
}
        }
    public class Aplikacja
    {
        private string nazwa;
        private bool lotnisko;
        private string nazwaa;
        private int powierzchnia;
        char d;
        SortedList<Kraj, Stolica> panstwa = new SortedList<Kraj, Stolica>();
        public void WczytajKlawisz()
        {
            d = ' ';
            Console.WriteLine("Co chcesz zrobić");
            Console.WriteLine("A-dodaj pozycje");
            Console.WriteLine("B-usun pozycje");
            Console.WriteLine("C-pokaz kraje");
            Console.WriteLine("D-pokaz stolice");
            Console.WriteLine("E-sprawdz");
            Console.WriteLine("X-Wyjscie z aplikacji");

            try
            {
                d = Convert.ToChar(Console.ReadLine());
            }
            catch
            { }

            WykonajDzialanie(d);

        }
        public void WykonajDzialanie(char d)
        {
            
        
}
        public void Wystartuj()
        {
            return;
        }



    }
    }

