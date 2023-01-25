using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IPair
    {
        public double A { get; set; }
        public double B { get; set; }

        IPair Add(IPair p);
        IPair Sub(IPair p);
        IPair Mul(IPair p);
        IPair Div(IPair p);
        bool Equ(IPair p);
        IPair Conj();
    }
}
