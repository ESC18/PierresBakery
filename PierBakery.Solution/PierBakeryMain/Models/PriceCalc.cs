using System;

namespace PriceCalc.Models 
{
    public class BreadPrice 
    {
        public int UserNumBread;
         public int BreadOutput(int userNumBread) 
        {
            if (userNumBread <= 0)
            {
                return 0;
            }

            int freeLoaves = userNumBread / 3;
            int breadTotal = (userNumBread - freeLoaves) * 5;

            return breadTotal;
        }
    }
}



public class PastryPrice
{
    public int UserNumPastry;
}
