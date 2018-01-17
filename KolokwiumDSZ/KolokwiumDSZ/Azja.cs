using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumDSZ
{
    public class Azja: IOperacje, ISprawdzenie
    {
        private SortedDictionary<Kraj, Stolica> panstwa = new SortedDictionary<Kraj,Stolica>();

        public void Dodaj(string nazwa,int powierzchnia, string nazwa1, bool lotnisko)
        {
            panstwa = new SortedDictionary<Kraj, Stolica>();
            panstwa.Add(Kraj.UtworzKraj(nazwa, powierzchnia), new Stolica(nazwa1, lotnisko));
        }

        public void Usun()
        {
            if(panstwa.Count()>0)
            {
                panstwa.Remove(panstwa.First().Key);
            }
        }


        public string Kraje()
        {
            string wynik=panstwa.ToString()+ Environment.NewLine;

            foreach(var panstw in panstwa)
            {
                wynik+= panstw.ToString()+Environment.NewLine;
            }

            return wynik;
        }

        public string Stolice()
        {
            string wynik = panstwa.ToString() + Environment.NewLine;

            foreach (var panstw in panstwa)
            {
                wynik += panstw.ToString() + Environment.NewLine;
            }

            return wynik;
        }

        public void Usun(string nazwa) { }

        public bool Sprawdz(string nazwa) { return true; }

    }
}
