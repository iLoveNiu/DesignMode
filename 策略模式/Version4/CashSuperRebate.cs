namespace 策略模式.version4
{
    public class CashSuperRebate : CashSuper
    {
        public float moneyRebate = 1f;

        public CashSuperRebate(float moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }

        public override float acceptCash(float money)
        {
            return money * moneyRebate;
        }
    }
}