using System;
using System.Threading;

namespace Multithreading
{
    public class ThreadingProgram
    {
        public void PrintNumbers()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker Thread : " + i*5);
                Thread.Sleep(500); // Simulate some work
            }
        }

        public void PrintNumbers1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Worker Thread 1: " + i * 15);
                Thread.Sleep(500); // Simulate some work
            }
        }
        public void PrintMessage(object msg)
        {
            Console.WriteLine("Message from thread: " + msg);
            Thread.Sleep(500);
        }

        public async Task FetchData()
        {
            await Task.Delay(2000); // Simulate a delay
            Console.WriteLine("Data fetched asynchronously.");
        }
    }

    public class Counter
    {
        private int count = 0;
        private readonly object lockObj = new object();

        public void Increment()
        {
            lock (lockObj)
            {
                for(int i = 0;i< 100; i++)
                {
                    count++;
                    Console.WriteLine("Count: " + count);
                }
            }
            //lock (lockObj)
            //{
            //    count++;
            //    Console.WriteLine("Count: " + count);
            //}
        }
    }
}