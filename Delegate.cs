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
}