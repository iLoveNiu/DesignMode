namespace 策略模式.version2
{
    public partial class CashSuperRebate : CashSuper
    {
        private float moneyRebate = 1f;

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