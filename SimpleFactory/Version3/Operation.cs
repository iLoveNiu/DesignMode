using System;

namespace SimpleFactory.verion3
{
    public class Operation
    {
        public static double GetResult(double one, double two, string operate)
        {
            double result = 0f;

            switch (operate)
            {
                case "+":
                    result = one + two;
                    break;
                case "-":
                    result = one - two;
                    break;
                case "*":
                    result = one * two;
                    break;
                case "/":
                    result = one / two;
                    break;
                default:
                    Console.WriteLine("符号有误！");
                    break;
            }

            return result;
        }
    }
}