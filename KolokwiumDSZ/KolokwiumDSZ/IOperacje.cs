using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolokwiumDSZ
{
    interface IOperacje
    {
        void Dodaj(string nazwa ,int powierzchnia,string nazwa1 ,bool lotnisko);
        void Usun();

        void Usun(string nazwa);
    }
}
