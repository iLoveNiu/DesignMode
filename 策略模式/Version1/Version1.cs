using System;

namespace 策略模式.version1
{
    /// <summary>
    /// 需求：根据物品的数量和单价 进行收费
    /// </summary>
    class Version1
    {
        static void Main1(string[] args)
        {
            //总计
            float total = 0.0f;

            total = CulTotal(2.5f,3);

        }

        static float CulTotal(float price,int num)
        {
            return price * num;
        }
    }
}