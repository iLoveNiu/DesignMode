using System;

namespace SimpleFactory.verion2
{
    /// <summary>
    /// 解决0不能作为除数的问题
    /// </summary>
    class Version2
    {
        static void Main2(string[] args)
        {
            try
            {
                Console.Write("请输入第一个数字：");
                double one = double.Parse(Console.ReadLine());
                Console.Write("请选择运算符号：+ - * /");
                string symbol = Console.ReadLine();
                Console.Write("请输入第二个数字：");
                double two = double.Parse(Console.ReadLine());

                double result = 0;
                switch (symbol)
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
                        if (two != 0f)
                        {
                            result = one / two;
                        }
                        else
                        {
                            Console.WriteLine("0 不能被作为除数");
                        }

                        break;
                }

                Console.WriteLine($"结果：{result}");
            }
            catch (Exception e)
            {
                Console.WriteLine("输入有误!");
            }
        }
    }
}