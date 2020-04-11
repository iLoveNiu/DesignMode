using System;

namespace SimpleFactory.verion4
{
    public class Operation
    {
        private double one = 0;
        private double two = 0;

        public double One
        {
            get => one;
            set => one = value;
        }

        public double Two
        {
            get => two;
            set => two = value;
        }


        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}