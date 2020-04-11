using System;

namespace 策略模式.version2
{
    public partial class CashSuperReturn : CashSuper
    {
        private float moneyCondition;
        private float moneyReturn;

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