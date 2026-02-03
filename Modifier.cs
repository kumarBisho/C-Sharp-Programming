using System;

namespace Modifier
{
    public class School
    {
        internal string Name = string.Empty;

        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return Name;
        }
    }

    public class Student : School
    {
        public void DisplaySchoolName()
        {
            Console.WriteLine("School Name: " + Name);
        }

    }

    public class Bisho : Student
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Student School Name: " + Name);
        }
    }
}