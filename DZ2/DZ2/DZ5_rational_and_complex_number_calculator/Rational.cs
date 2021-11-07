using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5_rational_and_complex_number_calculator
{
    public class Rational
    {
        /// <summary>
        /// Числитель numerator
        /// </summary>
        private int nr;

        /// <summary>
        /// знаменатель denominator
        /// </summary>
        private int dm;

        private int Nr
        {
            get
            {
                return nr;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Числитель не может быть равен нулю.");
                nr = value;
            }
        }
        /// <summary>
        /// знаменатель denominator
        /// </summary>
        private int Dm
        {
            get
            {
                return dm;
            }
            set
            {
                if (value == 0)
                    throw new Exception("Знаменатель не может быть равен нулю.");
                dm = value;
            }
        }

        public Rational()
        {
            nr = 1;
            dm = 1;
        }

        public Rational(int nr, int dm)
        {

            if (nr == 0)
                throw new Exception("Числитель не может быть равен нулю.");
            this.nr = nr;

            if (dm <= 0)
                throw new Exception("Знаменатель не может быть меньше или равен нулю.");
            this.dm = dm;
        }

        public static Rational operator +(Rational x, Rational y)
        {
            Rational z = new Rational();
            if (x.dm == y.dm)
            {
                z.nr = x.dm + y.dm;
                z.dm = x.dm;
            }
            else
            {
                z.nr = x.nr * y.dm + x.dm * y.nr;
                z.dm = x.dm * y.dm;
            }
            return z;
        }
        public static Rational operator -(Rational x, Rational y)
        {
            Rational z = new Rational();
            if (x.dm == y.dm)
            {
                z.nr = x.dm - y.dm;
                z.dm = x.dm;
            }
            else
            {
                z.nr = x.nr * y.dm - y.nr * x.dm;
                z.dm = x.dm * y.dm;
            }
            return z;
        }
        public static Rational operator *(Rational x, Rational y)
        {
            Rational z = new Rational();
            z.dm = x.dm * y.dm;
            z.nr = x.nr * y.nr;
            return z;
        }
        public static Rational operator /(Rational x, Rational y)
        {
            Rational z = new Rational();
            z.nr = x.nr * y.dm;
            z.dm = x.dm * y.nr;
            return z;
        }
        public static long operator %(Rational x, Rational y)
        {
            Rational z = new Rational();
            z.nr = x.nr * y.dm;
            z.dm = x.dm * y.nr;
            return z.nr % z.dm;

        }
        public static Rational operator ++(Rational x)
        {
            Rational z = new Rational();
            z.nr = x.nr + x.dm;
            z.dm = x.dm;
            return z;
        }
        public static Rational operator --(Rational x)
        {
            Rational z = new Rational();
            z.nr = x.nr - x.dm;
            z.dm = x.dm;
            return z;
        }
        public static bool operator ==(Rational x, Rational y)
        {
            return (x.nr == y.nr && x.dm == y.dm);
        }
        public static bool operator !=(Rational x, Rational y)
        {
            return (x.nr != y.nr || x.dm != y.dm);
        }
        public static bool operator >(Rational x, Rational y)
        {
            return (x.nr * y.dm > y.nr * x.dm);
        }
        public static bool operator <(Rational x, Rational y)
        {
            return (x.nr * y.dm < y.nr * x.dm);
        }
        public static bool operator >=(Rational x, Rational y)
        {
            return (x.nr * y.dm >= y.nr * x.dm);
        }
        public static bool operator <=(Rational x, Rational y)
        {
            return (x.nr * y.dm <= y.nr * x.dm);
        }
        public static explicit operator float(Rational x)
        {
            return (float)x.nr / x.dm;
        }
        public static explicit operator int(Rational x)
        {            
            return (int)x.nr / x.dm;
        }
        public static explicit operator double(Rational x)
        {
            return (double)x.nr / x.dm;
        }

        public override string ToString()
        {
            var num = Math.Abs(nr);
            var den = Math.Abs(dm);
            int temp;

            while (num != 0 && den != 0)
            {
                if (num % den > 0)
                {
                    temp = num;
                    num = den;
                    den = temp % den;
                }
                else
                    break;
            }

            if (num != 0 && den != 0)
            {
                nr = nr / den;
                dm = dm / den;
            }

            if (nr == 0) return $"0";
            else if (nr == dm) return $"1";
            else if (nr > dm)
            {
                if (nr - dm == dm) return $"{nr / dm}";
                else return $"{nr / dm}+{nr - dm}/{dm}";
            }
            else if(nr < 0 && Math.Abs(nr) > dm) return $"{nr / dm}{nr - dm}/{dm}";
            return $"{nr}/{dm}";
        }

        public bool Equals(Rational x)
        {
            return (x.nr == Nr && x.dm == Dm);
        }
    }
}
