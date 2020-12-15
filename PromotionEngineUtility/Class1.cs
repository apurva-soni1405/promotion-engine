using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineUtility
{
    public class ManageOrder
    {
        //Assign SKU ID count 
        readonly int promotionACount = 3; readonly int promotionBCount = 2; 
        public int CalculateOrder(List<string> cart)
        {
            int orderValue = 0;
            int countA = 0; int countB = 0; int countC = 0; int countD = 0;
            int countCD = 0; int unitCCount = 0; int unitDCount = 0;

            countA = cart.Where(x => x == "A").Count(); //Count SKU ID "A"
            countB = cart.Where(x => x == "B").Count(); //Count SKU ID "B"
            countC = cart.Where(x => x == "C").Count(); //Count SKU ID "C"
            countD = cart.Where(x => x == "D").Count(); //Count SKU ID "D"

            //Make pair of C and D
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

            //Formula to calculate order value result
            orderValue = ((countA / promotionACount) * 130) + ((countA % promotionACount) * 50) + //Order value for A
                ((countB / promotionBCount) * 45) + ((countB % promotionBCount) * 30) + //Order value for B
                (countCD * 30) + //Order value for C-D pair
                (unitCCount * 20) + //Order value for unit C
                (unitDCount * 15); //Order value for unit D

            return orderValue;
        }
    }
}
