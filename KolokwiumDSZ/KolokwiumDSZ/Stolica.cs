using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumDSZ
{
    class Stolica
    {
        private string nazwa;
        private bool lotnisko;

        public Stolica(string nazwa, bool lotnisko)
        {
            this.nazwa = nazwa;
            this.lotnisko = lotnisko;
        }

        public override string ToString()
        {
            string czy;

            if(lotnisko == true)
            {
                czy="Tak";
            }
            else
            {
                czy = "Nie";
            }

            return "Stolica "+nazwa+", lotnisko " + czy;
        }
    }
}
