using System;

namespace InterfaceImp
{
    public interface IAnimal
    {
        void Speak();
        void Eat();
    }

    public interface IPet
    {
        void Play();
    }

    public class Cow : IAnimal, IPet
    {
        public void Speak()
        {
            Console.WriteLine("Moo!");
        }

        public void Eat()
        {
            Console.WriteLine("The cow is eating.");
        }

        public void Play()
        {
            Console.WriteLine("The cow is playing.");
        }
    }

    public class Duck : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Quack!");
        }
        public void Eat()
        {
            Console.WriteLine("The duck is eating.");
        }
        
        public void Swim()
        {
            Console.WriteLine("The duck is swimming.");
        }
        
    }
}