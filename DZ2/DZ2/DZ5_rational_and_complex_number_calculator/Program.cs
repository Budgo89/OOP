using System;

namespace DZ5_rational_and_complex_number_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational a = new Rational(1, 4);
            Rational b = new Rational(1, 2);
            Rational c = new Rational();

            c = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(a%b);
            Console.WriteLine(++a);
            Console.WriteLine(--a);
            Console.WriteLine(a==b);
            Console.WriteLine(a!=b);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a>b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine((float)a);
            Console.WriteLine((int)a);
            Console.WriteLine();

            Complex x = new Complex(1, 5);
            Complex y = new Complex(3,2);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(x+y);
            Console.WriteLine(x-y);
            Console.WriteLine(x*y);
            Console.WriteLine(x/y);
            Console.WriteLine(x==y);
            Console.WriteLine(x!=y);
        }
    }
}
