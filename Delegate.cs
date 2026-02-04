using System;

namespace Delegate
{
    public class DelegateExample
    {
        public delegate void MyDelegate(string msg);

        public void DisplayMessage(string message)
        {
            Console.WriteLine("Message : " + message);
        }

        public delegate void Notify();
        public void MethodA()
        {
            Console.WriteLine("Method A is called.");
        }
        public void MethodB()
        {
            Console.WriteLine("Method B is called.");
        }

        public delegate int Operation(int a, int b);

        public int Add(int a, int b) => a + b;
        public int Mul(int a, int b) => a * b;
    }

    public class PredicateExample
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public bool IsPositive(int number)
        {
            return number > 0;
        }
    }

    public class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Marks { get; set; } = 0;
    }
}