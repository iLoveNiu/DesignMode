namespace 策略模式.version4
{
    public class CashSuperNormal : CashSuper
    {
        public override float acceptCash(float money)
        {
            return money;
        }
    }
}