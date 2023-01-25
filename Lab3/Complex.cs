using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Complex : IPair
    {
        public double A { get; set; }
        public double B { get; set; }

        public Complex(double a, double b)
        {
            A = a;
            B = b;
        }

        public IPair Add(IPair p)
        {
            return new Complex(this.A + p.A, this.B + p.B);
        }

        public IPair Sub(IPair p)
        {
            return new Complex(this.A - p.A, this.B - p.B);
        }

        public IPair Div(IPair p)
        {
            return new Complex((this.A * p.A + this.B * p.B) / (Math.Pow(p.A, 2) + Math.Pow(p.B, 2)), (this.B * p.A - this.A * this.B) / (Math.Pow(p.A, 2) + Math.Pow(p.B, 2)));
        }

        public IPair Mul(IPair p)
        {
            return new Complex((this.A * p.A - this.B * p.B), (this.B * p.B) + (this.B * p.A));
        }
        public bool Equ(IPair p)
        {
            if (this.A == p.A && this.B == p.B) return true;
            else return false;
        }
        public IPair Conj()
        {
            return new Complex(this.A, -this.B);
        }
        public string? ToString()
        {
            return this.A + "+" + this.B + "i";
        }
    }
}
