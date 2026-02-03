using System;

namespace Overriding
{
    public class College
    {
        public College()
        {
            Console.WriteLine("College Constructor");
        }

        public College(int i, int j)
        {
            Console.WriteLine("College Parameterized Constructor");
        }

        public virtual void Name()
        {
            Console.WriteLine("MNIT Jaipur");
        }
        public void Location()
        {
            Console.WriteLine("Jaipur");
        }

        public virtual void swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping inside method of college : a = {0}, b = {1}", a, b);
        }
    }

    public class Teacher : College
    {
        public Teacher() : base()
        {
            Console.WriteLine("Teacher Constructor");
        }
        public Teacher(int i, int j) : base(i, j)
        {
            Console.WriteLine("Teacher Parameterized Constructor");
        }

        public override void Name()
        {
            base.Name();
            Console.WriteLine("Bisho Kumar");
        }
        public void Branch()
        {
            Console.WriteLine("ECE");
        }

        public override void swap(int a, int b)
        {
            base.swap(a, b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping inside method of teacher : a = {0}, b = {1}", a, b);
        }
    }
}