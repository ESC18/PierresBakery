using System;

namespace PriceCalc.Models
{
    public class BreadPrice
    {
        public int UserNumBread { get; }

        public BreadPrice(int userNumBread)
        {
            UserNumBread = userNumBread;
        }

        public int BreadOutput()
        {
            if (UserNumBread <= 0)
            {
                return 0;
            }

            int freeLoaves = UserNumBread / 3;
            int breadTotal = (UserNumBread - freeLoaves) * 5;

            return breadTotal;
        }
    }

    public class PastryPrice
    {
        public int UserNumPastry { get; }

        public PastryPrice(int userNumPastry)
        {
            UserNumPastry = userNumPastry;
        }

        public int PastryOutput()
        {
            if (UserNumPastry <= 0)
            {
                return 0;
            }

            int freePastries = UserNumPastry / 4;
            int pastryTotal = (UserNumPastry - freePastries) * 2;

            return pastryTotal;
        }
    }
}
