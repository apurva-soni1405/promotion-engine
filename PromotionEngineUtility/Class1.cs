using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineUtility
{
    public class ManageOrder
    {
        readonly int promotionACount = 3; readonly int promotionBCount = 2; 
        public int CalculateOrder(List<string> cart)
        {
            int orderValue = 0;
            int countA = 0; int countB = 0; int countC = 0; int countD = 0;
            int countCD = 0; int unitCCount = 0; int unitDCount = 0;

            countA = cart.Where(x => x == "A").Count();
            countB = cart.Where(x => x == "B").Count();
            countC = cart.Where(x => x == "C").Count();
            countD = cart.Where(x => x == "D").Count();

            if (countC <= countD)
            {
                countCD = countC;
                unitDCount = countD - countCD;
            }
            else if (countC > countD)
            {
                countCD = countD;
                unitCCount = countC - countCD;
            }

            orderValue = ((countA / promotionACount) * 130) + ((countA % promotionACount) * 50) +
                ((countB / promotionBCount) * 45) + ((countB % promotionBCount) * 30) +
                (countCD * 30) +
                (unitCCount * 20) +
                (unitDCount * 15);

            return orderValue;
        }
    }
}
