using System;

namespace 策略模式.version3
{
    public class CashSuperReturn : CashSuper
    {
        public float moneyCondition;
        public float moneyReturn;

        public CashSuperReturn(float moneyCondition, float moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        public override float acceptCash(float money)
        {
            double result = money;
            if (money > moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return (float) result ;
        }
    }
}