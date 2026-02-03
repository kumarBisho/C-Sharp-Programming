using System;

namespace Property
{
    public class Car
    {
        private int r = 1200;

        public int rate
        {
            get { return r; }
            set { r = value; }
        }
        public Car(int r)
        {
            this.r = r;
        }
    }
}