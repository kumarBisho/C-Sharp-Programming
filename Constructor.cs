using System;

namespace Constructor
{
    public class Animal
    {
        string Name = "Unknown";
        int Age = 0;

        // Default Constructor
        public Animal()
        {
            Console.WriteLine("Animal constructor called");
        }

        // Parameterized Constructor
        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
            Console.WriteLine("Animal parameterized constructor called");
        }

        // Copy Constructor
        public Animal(Animal other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

        // Private Constructor
        //private Animal()
        //{
        //    Console.WriteLine("Private constructor called");
        //}

        public static int count;
        public static int inc_count()
        {
            return ++count;
        }

        // Static Constructor
        //static Animal()
        //{
        //    count = 12;
        //    Console.WriteLine("Static constructor called");
        //}

        //Destructor 
        ~Animal()
        {
            Console.WriteLine("Destructor called for Animal: " + Name);
        }
    }
}