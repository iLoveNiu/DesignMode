using System;

namespace 策略模式.version4
{
    public enum Type
    {
        Normal,
        Rebate,
        Return
    }

    /// <summary>
    /// 需求：根据物品的数量和单价 进行收费
    /// </summary>
    class Version3
    {
        static void Main(string[] args)
        {
            //总计
            float total = 0.0f;
            total = CulTotal(600, 2);

            CashContext cc = new CashContext(Type.Rebate);

            //根据算法对象，计算最终要付多少钱
            float result = cc.ContextInterface(total);
            
            Console.WriteLine(result);
        }

        static float CulTotal(float price, int num)
        {
            return price * num;
        }
    }
}