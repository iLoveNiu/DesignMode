using System;

namespace SimpleFactory.verion1
{
    class Version1
    {
        static void Main1(string[] args)
        {
            Console.Write("请输入第一个数字：");
            double one = double.Parse(Console.ReadLine());
            Console.Write("请选择运算符号：+ - * /");
            string symbol = Console.ReadLine();
            Console.Write("请输入第二个数字：");
            double two = double.Parse(Console.ReadLine());

            double result=0;
            if (symbol == "+")
            {
                result = one + two;
            }

            if (symbol == "-")
            {
                result = one - two;
            }

            if (symbol == "*")
            {
                result = one * two;
            }

            if (symbol == "/")
            {
                result = one / two;
            }

            Console.WriteLine($"结果：{result}");
        }
    }
}