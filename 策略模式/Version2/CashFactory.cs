using System;
using System.Diagnostics;

namespace 策略模式.version2
{
    public class CashFactory
    {
        public static CashSuper cashSuperCreate(Type type)
        {
            CashSuper cs = null;
            
            switch (type)
            {
                case Type.Normal:
                    cs=new CashSuperNormal();
                    break;
                case Type.Rebate:
                    cs=new CashSuperRebate(0.8f);
                    break;
                case Type.Return:
                    cs=new CashSuperReturn(300,100);
                    break;
            }

            return cs;
        }
    }
}