using System;

namespace SimpleFactory.verion4
{
    /// <summary>
    /// 要求： 需要增加一个运算符号
    /// </summary>
    class Version4
    {
        static void Main(string[] args)
        {
            Console.Write("请选择运算符号：+ - * /");
            string symbol = Console.ReadLine();
            Operation oper=OperationFactory.CreateOperate(symbol);
            
            Console.Write("请输入第一个数字：");
            oper.One = double.Parse(Console.ReadLine());

            Console.Write("请输入第二个数字：");
            oper.Two = double.Parse(Console.ReadLine());

            double result = 0;
            result = oper.GetResult();
            Console.WriteLine($"结果：{result}");
        }
    }
}