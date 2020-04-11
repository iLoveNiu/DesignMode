using System.Data.SqlTypes;

namespace 策略模式.version4
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class CashContext
    {
        private CashSuper cashSuper;

        /// <summary>
        /// 初始化的时候传入具体的策略对象
        /// </summary>
        /// <param name="cashSuper"></param>
        public CashContext(Type type)
        {
            switch (type)
            {
                case Type.Normal:
                    cashSuper=new CashSuperNormal();
                    break;
                case Type.Rebate:
                    cashSuper=new CashSuperRebate(0.1f);
                    break;
                case Type.Return:
                    cashSuper=new CashSuperReturn(500,200);
                    break;
            }
        }

        /// <summary>
        /// 上下文接口，根据具体策略对象调用它的算法
        /// </summary>
        public float ContextInterface(float money)
        {
            return cashSuper.acceptCash(money);
        }
    }
}