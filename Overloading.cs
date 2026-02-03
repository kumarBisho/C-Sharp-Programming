using System;

namespace Overloading
{
    public class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        public double Add(int a, double b)
        {
            return a + b;
        }

        public double Add(double b, int a)
        {
            return a + b;
        }
    }
}