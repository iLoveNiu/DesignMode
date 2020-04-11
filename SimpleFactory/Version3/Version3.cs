using System;

namespace SimpleFactory.verion3
{
    /// <summary>
    /// 封装出Operation操作类
    /// </summary>
    class Version3
    {
        static void Main3(string[] args)
        {
            Console.Write("请输入第一个数字：");
            double one = double.Parse(Console.ReadLine());
            Console.Write("请选择运算符号：+ - * /");
            string symbol = Console.ReadLine();
            Console.Write("请输入第二个数字：");
            double two = double.Parse(Console.ReadLine());

            double result = 0;

            result = Operation.GetResult(one, two, symbol);

            Console.WriteLine($"结果：{result}");
        }
    }
}