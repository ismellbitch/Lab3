using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Money : IPair
    {
        public double A { get; set; }
        public double B { get; set; }

        public Money(double a, double b)
        {
            A = a;
            B = b;
        }

        public IPair Add(IPair p)
        {
            if (this.B + p.B >= 100)
            {
                return new Money(this.A + p.A + 1, (this.B + p.B) - 100);
            }
            else return new Money(this.A + p.A + 1, (this.B + p.B));
        }

        public IPair Conj()
        {
            throw new NotImplementedException();
        }

        public IPair Div(IPair p)
        {
            return new Money(this.A / p.A, this.B / p.B);
        }

        public bool Equ(IPair p)
        {
            if (this.A == p.A && this.B == p.B) return true;
            else return false;
        }

        public IPair Mul(IPair p)
        {
            if (this.B * p.B < 100)
            {
                return new Money(this.A * p.A, this.B * p.B);
            }
            else
            {
                double temp = this.B * p.B / 100;
                return new Money(this.A * p.A + temp, (this.B * p.B) - temp * 100);
            }
        }

        public IPair Sub(IPair p)
        {
            if (this.A - p.A >= 0 && this.B - p.B < 0)
            {
                return new Money(this.A - p.A - 1, ((this.B + 100) - p.B));
            }
            else if (this.A - p.A < 0)
            {
                return new Money(0, 0);
            }
            else return new Money(this.A + p.A + 1, (this.B + p.B));
        }
    }
}
