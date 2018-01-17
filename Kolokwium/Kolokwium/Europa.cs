using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium
{
    class Europa
    {
        SortedList<Kraj,Stolica> panstwa = new SortedList<Kraj,Stolica>();
        /*public void Dodaj(string nazwa,int powierzchnia,string nazwaa,bool lotnisko)
        {
            panstwa.Add(new Kraj(nazwa, powierzchnia), new Stolica(nazwaa,lotnisko));
        }*/
        public void Usun()
        {
            panstwa.RemoveAt(0);
        }
        public void Usun(string nazwa)
        {
            panstwa.Remove(panstwa.First().Key);
        }
        public string Kraje()
        { 
            string txt=" ";
         

            foreach(var t in panstwa)
            {
                  txt += t.ToString();
            }
            return txt;
        }
        public string Stolice()
        {
            string a = "";
            foreach (var t in panstwa)
            {
                a += t.ToString();
            }
            return a;
        }
        /*public bool Sprawdz(string nazwa)
        {
            
        }*/
    }
}
