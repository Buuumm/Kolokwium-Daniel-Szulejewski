using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumDSZ
{
    class Kraj : IComparable<Kraj>
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
            return new Kraj(nazwa,powierzchnia);
        }

        public int CompareTo(Kraj other)
        {
            return this.powierzchnia.CompareTo(other.powierzchnia);
        }

        public override string ToString()
        {

            return "Kraj: " + nazwa + ", powierzchnia " + powierzchnia;
        }


    }
}
