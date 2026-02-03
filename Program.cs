// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using System;

//namespace HelloWorld
//{
//    public class Program
//    {
//        public static int Add(params int[] Numbers)
//        {
//            int sum = 0;
//            for (int i = 0; i < Numbers.Length; i++)
//            {
//                sum += Numbers[i];
//            }
//            return sum;
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//            //Console.ReadKey();

//            int[] arr = new int[5];
//            arr = new int[] { 10, 2, 3, 4, 5 };

//            foreach(var i in arr)
//            {
//                Console.WriteLine(i);
//            }

//            int result = Add(arr);
//            Console.WriteLine("The sum is " + result);

//            int[,] twoDArray = new int[3, 4]
//            {
//                {1, 2, 3, 4 },
//                {5, 6, 7, 8 },
//                {9, 10, 11, 12 }
//            };

//            int[,,] threeDArray = new int[2, 3, 4]
//            {
//                {
//                    { 1, 2, 3, 4 },
//                    { 5, 6, 7, 8 },
//                    { 9, 10, 11, 12 }
//                },
//                {
//                    { 13, 14, 15, 16 },
//                    { 17, 18, 19, 20 },
//                    { 21, 22, 23, 24 }
//                }
//            };

//            Console.WriteLine("Two Dimensional Array:");
//            for (int i = 0; i < twoDArray.GetLength(0); i++)
//            {
//                for (int j = 0; j < twoDArray.GetLength(1); j++)
//                {
//                    Console.Write(twoDArray[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }

//            Console.WriteLine("Three Dimensional Array:");
//            for(int i = 0; i < threeDArray.GetLength(0); i++)
//            {
//                for(int j = 0; j < threeDArray.GetLength(1); j++)
//                {
//                    for(int k=0;k< threeDArray.GetLength(2); k++)
//                    {
//                        Console.Write(threeDArray[i, j, k] + "\t");
//                    }
//                    Console.WriteLine();
//                }
//                Console.WriteLine();
//            }

//            int[][] array = {new int[] {1,2,3,4,5},
//                            new int[] {6,7,8}
//                            };
//            for(int i = 0; i < array.Length; i++)
//            {
//                for(int j = 0; j < array[i].Length; j++)
//                {
//                    Console.Write(array[i][j] + "\t");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}


using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using ClassIntro;
using DogClass;
using Method;
using Constructor;
using Property;
using Modifier;
using LinqOperator;
using Abstraction;
using System.Reflection.Metadata;
using InterfaceImp;
using Encapsulation;
using Overloading;
using Overriding;
using Delegate;
using Multithreading;
using System.Diagnostics.Metrics;

namespace Program
{
    public class Program
    {
        //static void Main(string[] args)
        //{
            //Intro CI = new Intro();
            //CI.DisplayMessage();

            //Dog d = new Dog("ABCD", "papilon", 5, "White");

            //Console.WriteLine(d.ToString());
            //d.Bark();

            //Greeting.Greet("Bisho");

            //Animal a = new Animal();
            //Animal b = new Animal("Cow", 12);
            //b.DisplayInfo();
            //Animal c = new Animal(b);
            //c.DisplayInfo();

            //Animal.count = 98;
            //Console.WriteLine(Animal.count);
            //Animal.inc_count();
            //Animal.inc_count();
            //Console.WriteLine(Animal.count);
            //Animal a = new Animal("Cat", 3);
            //a.DisplayInfo();

            //Animal b = new Animal("Dog", 34);
            //Animal a = new Animal();
            //b.DisplayInfo();
            //a.DisplayInfo();

            //Car c = new Car(34567);
            //Console.WriteLine(c.rate);
            //c.rate = 877273;
            //Console.WriteLine(c.rate);

            //School s = new School();
            //s.SetName("MPT");
            //Console.WriteLine(s.GetName());
            //Console.WriteLine(s.Name);

            //Student st = new Student();
            //st.SetName("Kejriwal");
            //st.DisplaySchoolName();
            //Console.WriteLine(st.Name);

            //Bisho b = new Bisho();
            //b.SetName("LNJ");
            //b.DisplayInfo();
            //Console.WriteLine(b.Name);

            //int[] number = { 2, 5, 1, 7, 9, 34, 2, 65, 32, 3, 56, 8 };

            //var result = number.Where(n => n > 5).Select(n => n * 2);

            //foreach(var i in result)
            //{
            //    Console.Write(i + " ");
            //}

            //List<string> my_list = new List<string>()
            //{
            //    "This is my dog",
            //    "Name of my Dog is Robin",
            //    "This is my Cat",
            //    "Name of the cat is Mewmew"
            //};

            //var res = my_list.Where(l => l.Contains("my")).Select(l => l );

            //foreach(var l in res)
            //{
            //    Console.WriteLine(l);
            //}

            //var res1 = from l in my_list where l.Contains("This") select l;

            //foreach (var l in res1)
            //{
            //    Console.WriteLine(l);
            //}

            //int[] number = { 2, 5, 1, 7, 9, 34, 2, 5, 34, 3, 9, 1 };

            //var res1 = number.Take(4);
            //foreach(var i in res1)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //var res2 = number.TakeWhile(l => l < 40);
            //foreach (var i in res2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //var res3 = number.Skip(3);
            //foreach (var i in res3)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //var res4 = number.SkipWhile(l => l < 40);
            //foreach (var i in res4)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //var res5 = number.Distinct();
            //foreach(var i in res5)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //int[] sequence1 = { 112, 44, 55, 66, 77, 777, 56 };
            //int[] sequence2 = { 2 };
            //int[] sequence3 = { };

            //int val1 = sequence1.Single(seq => seq == 66);
            //Console.WriteLine(val1);

            //int val2 = sequence3.Single();
            //Console.WriteLine(val2);

            //List<Employee> emp = new List<Employee>()
            //{
            //    new Employee()
            //    {
            //        Id = 230, Name = "Bisho", Gender = "Male", Age = 24, Salary = 10000,
            //    },
            //    new Employee()
            //    {
            //        Id = 233, Name = "Anil", Gender = "Male", Age = 29, Salary = 12000,
            //    },
            //    new Employee()
            //    {
            //        Id = 237, Name = "Ankita", Gender = "Female", Age = 21, Salary = 7600,
            //    },
            //    new Employee()
            //    {
            //        Id = 129, Name = "Kaushal", Gender = "Male", Age = 27, Salary = 10900,
            //    }
            //};

            //var res = emp.Single(e => e.Name == "Kaushal");

            //Console.WriteLine("Id: " + res.Id + ", Name: " + res.Name + ", Gender: " + res.Gender + ", Age: " + res.Age + ",Salary: " + res.Salary);

            //var resList = emp.Where(e => e.Gender == "Male").Select(e => e);

            //Console.WriteLine("List of employee filter by Gender.");
            //foreach(var v in resList)
            //{
            //    Console.WriteLine("Id: " + v.Id + ", Name: " + v.Name + ", Gender: " + v.Gender + ", Age: " + v.Age + ",Salary: " + v.Salary);
            //}


            //Square s = new Square(23);
            //Console.WriteLine("Area of square " + s.Area());
            //Console.WriteLine("Perimeter of square " + s.Perimeter());

            // Can't create instance of the abstract type or interface
            //Shape p = new Shape();

            //Console.WriteLine("Interface Implementation Example:");
            //Cow c = new Cow();
            //c.Speak();
            //c.Eat();
            //c.Play();

            //Duck d = new Duck();
            //d.Speak();
            //d.Eat();
            //d.Swim();


            //Account bisho = new Account();

            //bisho.Name = "Bisho Kumar";

            //Console.WriteLine("Account Holder Name: " + bisho.Name);

            //bisho.Deposit(5000);
            //bisho.Deposit(-3490);
            //Console.WriteLine("Current Balance: " + bisho.GetBalance());
            //bisho.Withdraw(2000);
            //bisho.Withdraw(-4000);
            //Console.WriteLine("Current Balance: " + bisho.GetBalance());

            //Calculation c = new Calculation();

            //int res = c.Add(5, 4);
            //Console.WriteLine(res);

            //int res1 = c.Add(4, 3, 6);
            //Console.WriteLine(res1);

            //double res2 = c.Add(4.5, 4.9, 5.0);
            //Console.WriteLine(res2);

            //double res3 = c.Add(4, 3.5);
            //Console.WriteLine(res3);

            //double res4 = c.Add(4.3, 3);
            //Console.WriteLine(res4);

            //Teacher t1 = new Teacher();
            //t1.Name();
            //t1.Branch();

            //Teacher t2 = new Teacher(5, 10);
            //t2.Name();
            //t2.Branch();

            //t1.swap(10, 20);
            //t2.swap(30, 40);

            //Square s = new Square(10);
            //s.Display();
            //Circle c = new Circle(7);
            //c.Display();

            //Shape[] shapes = new Shape[] { new Square(), new Square(), new Circle(), new Circle() };
            //s1 = new Square(5);
            //s2 = new Square(12);
            //c1 = new Circle(3);
            //c2 = new Circle(15);

            //foreach (var sp in shapes)
            //{
            //    Console.WriteLine(sp.GetType().Name);
            //    if(sp.GetType().Name == "Square")
            //    {
            //        Square sq = new Square(20);
            //        sq.Display();
            //    }
            //    else
            //    {
            //        Circle cr = new Circle(10);
            //        cr.Display();
            //    }
            //}

            //foreach(var sp in shapes)
            //{
            //    var temp = sp.GetType().Name;
            //    if(temp == "Square")
            //    {
            //        Square sq = new Square(25);
            //        sq.Display();
            //    }
            //    else
            //    {
            //        Circle cr = new Circle(15);
            //        cr.Display();
            //    }
            //}
            //foreach(var sp in shapes)
            //{
            //    var temp = sp.GetType().Name;
            //    if (temp == "Square")
            //    {
            //        Square sq = (Square)sp;
            //        sq = new Square(30);
            //        sq.Display();

            //    }
            //    else
            //    {
            //        Circle cr = (Circle)sp;
            //        cr = new Circle(20);
            //        cr.Display();
            //    }
            //}

            //DelegateExample de = new DelegateExample();
            //de.DisplayMessage("Hello from Delegate Example");

            //DelegateExample.MyDelegate del = de.DisplayMessage;
            //del("Hello from Delegate");

            //del("Another message via Delegate");

            //DelegateExample.Notify notifyDel = de.MethodA;
            //notifyDel += de.MethodB;
            //notifyDel -= de.MethodA;
            //notifyDel();

            //DelegateExample.Operation op = de.Add;
            //op += de.Mul;
            //op += de.Add; // if return type will be non-void type then last method in the invocation list is returned.
            //int val = op(10, 20);
            //Console.WriteLine("Result : " + val);

            //ThreadingProgram tp = new ThreadingProgram();

            //tp.PrintNumbers();

            //Thread t1 = new Thread(tp.PrintNumbers);
            //Thread t2 = new Thread(tp.PrintNumbers1);
            //t1.Start();
            //t2.Start();

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Main : " + i * 10);
            //    Thread.Sleep(500);
            //}

            //Thread t3 = new Thread(tp.PrintMessage);
            //t3.Start("This is 3rd thread written by Bisho.");

            //// threading using lambda function, Inline logic.
            //Thread t4 = new Thread((msg) =>
            //{
            //    Console.WriteLine("thread 4 message : " + msg);
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Inline Thread : " + i * 2);
            //        Thread.Sleep(500);
            //    }
            //});
            //t4.Start("Checking for message");

            //Thread t5 = new Thread(() => Console.WriteLine("Background Thread running."));
            //t5.IsBackground = true;
            //t5.Start();

            //Thread Synchronization

            //Counter counter = new Counter();

            //Thread t1 = new Thread(counter.Increment);
            //Thread t2 = new Thread(counter.Increment);

            //t1.Start();
            //t2.Start();

            //ThreadPool.QueueUserWorkItem(tp.PrintMessage, "Task 1");
            //ThreadPool.QueueUserWorkItem(tp.PrintMessage, "Task 2");

            //Task t1 = Task.Run(() =>
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Task1 : " + i * 5);
            //    }
            //});
            //Task t2 = Task.Run(() =>
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        Console.WriteLine("Task2 : " + i * 7);
            //    }
            //});
            //Console.WriteLine("Working or not");

            //Console.WriteLine("Fetching...");
            //await tp.FetchData();
            //Console.WriteLine("Done!");
        //}
        static async Task Main(string[] args)
        {
            ThreadingProgram tp = new ThreadingProgram();
            Console.WriteLine("Fetching...");
            await tp.FetchData();
            Console.WriteLine("Done!");
        }
    }
}