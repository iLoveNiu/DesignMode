using System;

namespace 策略模式.version2
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
    class Version2
    {
        static void Main2(string[] args)
        {
            //总计
            float total = 0.0f;

            total = CulTotal(600, 2);

            CashSuper cashSuper = CashFactory.cashSuperCreate(Type.Normal);
            float result = cashSuper.acceptCash(total);

            Console.WriteLine(result);
        }

        static float CulTotal(float price, int num)
        {
            return price * num;
        }
    }
}