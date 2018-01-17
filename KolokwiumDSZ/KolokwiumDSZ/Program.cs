using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumDSZ
{
    class Program
    {
        static void Main(string[] args)
        {

            Aplikacja start = new Aplikacja();
            start.WczytajKlawisz();

            while (true)
            {
                start.WczytajKlawisz();
            }

        }
        public class Aplikacja : Azja
        {

            string nazwa;
            string nazwa1;
            int powierzchnia;
            bool lotnisko;
            char d;
            private SortedDictionary<Kraj, Stolica> panstwa = new SortedDictionary<Kraj, Stolica>();

            public void WczytajKlawisz()
            {
                d = ' ';
                Console.WriteLine("Kraje i Stolice");
                Console.WriteLine("Co chcesz zrobić? Wpisz klawisz i zatwierdź enterem...");
                Console.WriteLine("A-Dodaj Kraj i Stolice");
                Console.WriteLine("B-Usun pierwszy wpis na liscie");
                Console.WriteLine("C-Usun pole o podanym kluczu");
                Console.WriteLine("D-Pokaz kraje");
                Console.WriteLine("E-Pokaz stolice");
                Console.WriteLine("E-Sprawdz podany kraj ");
                Console.WriteLine("X- Wyjscie");

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
                switch (d)
                {
                    case 'A':
                        Dodaj(nazwa, powierzchnia, nazwa1, lotnisko);
                        break;
                    case 'B':
                        Usun();
                        break;
                    case 'C':
                        Usun(nazwa);
                        break;
                    case 'D':
                        Kraje();
                        break;
                    case 'E':
                        Stolice();
                        break;
                    case 'X':
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Błąd!");
                        break;
                }
                Console.WriteLine("Naciśnij dowolny przycisk...");
                Console.ReadKey();
                Console.Clear();
            }

            
        }
    }
}

