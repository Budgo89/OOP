using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5_rational_and_complex_number_calculator
{
    public class Complex
    {
        /// <summary>
        /// Мнимая часть комплексного числа
        /// </summary>
        double im;

        /// <summary>
        /// Депйствительная часть комплексного числа
        /// </summary>
        double re;

        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                if (value == 0)
                    throw new Exception("на ноль делить нельзя.");
                im = value;
            }
        }

        /// <summary>
        /// Депйствительная часть комплексного числа
        /// </summary>
        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }

        public double Sample { get; set; }

        public Complex()
        {
            im = 1;
            re = 0;
        }

        public Complex(double re, double im)
        {
            if (im == 0)
                throw new Exception("на ноль делить нельзя.");
            this.im = im;

            this.re = re;
        }

        public static Complex operator +(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.re = x.re + y.re;
            z.im = x.im + y.im;
            return z;
        }
        public static Complex operator -(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.re = x.re - y.re;
            z.im = x.im - y.im;
            return z;
        }
        public static Complex operator *(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.re = x.re*y.re - x.im*y.im;
            z.im = x.im*y.re + x.re*y.im;
            return z;
        }
        public static Complex operator /(Complex x, Complex y)
        {
            Complex z = new Complex();
            z.re = (x.re * y.re + x.im * y.im)/(y.re*y.re+y.im*y.im);
            z.im = (x.im*y.re-x.re*y.im)/(y.re * y.re + y.im * y.im);
            return z;
        }
        public static bool operator ==(Complex x, Complex y)
        {
            return (x.re == y.re && x.im == y.im);
        }
        public static bool operator !=(Complex x, Complex y)
        {
            return (x.re != y.re || x.im != y.im);
        }
        public override bool Equals(object obj)
        {
            Complex y = (Complex)obj;
            return (this.re == y.re && this.im == y.im);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(im, re);
        }
        public override string ToString()
        {
            if (im > 0)
            {
                if (re == 0) return $"{im}i";
                else return $"{re}+{im}i";
            }
            else if (im < 0)
            {
                if (re == 0) return $"{im}i";
                else return $"{re}{im}i";
            }
            else return $"{re}";
        }
    }
}
