using System;

namespace DogClass
{
    public class Dog
    {
        string name;
        string bread;
        int age;
        string color;

        public Dog(string name, string bread, int age, string color)
        {
            this.name = name;
            this.bread = bread;
            this.age = age;
            this.color = color;
        }

        public string GetName()
        {
            return name;
        }
        public string GetBread()
        {
            return bread;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetColor()
        {
            return color;
        }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public override string ToString()
        {
            return $"Name: {name}, Bread: {bread}, Age: {age}, Color: {color}";
        }
    }
}
