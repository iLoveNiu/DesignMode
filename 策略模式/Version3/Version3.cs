using System;

namespace 策略模式.version3
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
        static void Main3(string[] args)
        {
            //总计
            float total = 0.0f;
            total = CulTotal(600, 2);


            CashContext cc = CashType(Type.Return);

            //根据算法对象，计算最终要付多少钱
            float result = cc.ContextInterface(total);


            Console.WriteLine(result);
        }

        static float CulTotal(float price, int num)
        {
            return price * num;
        }

        //==================================在下一版本版本中要取消客户端创建对象
        /// <summary>
        /// 根据优惠活动返回算法对象
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        static CashContext CashType(Type type)
        {
            CashContext cashContext = null;

            switch (type)
            {
                case Type.Normal:
                    cashContext = new CashContext(new CashSuperNormal());
                    break;
                case Type.Rebate:
                    cashContext = new CashContext(new CashSuperRebate(0.5f));
                    break;
                case Type.Return:
                    cashContext = new CashContext(new CashSuperReturn(1000,100));
                    break;
            }

            return cashContext;
        }
    }
}