using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dcascontroller
{
    class ctData
    {
        double minCurr;
        double maxCurr;
        double temp;
        double dur;
        public ctData()
        {
            minCurr = 0;
            maxCurr = 0;
            temp = 25;
            dur = 1;   
        }
        public ctData(double inminCurr,double inmaxCurr,double intemp,double indur)
        {
            minCurr = inminCurr;
            maxCurr = inmaxCurr;
            temp = intemp;
            dur = indur;
        }
        public double minimumCurr
        {
            get
            {
                return minCurr;
            }
            set
            {
                minCurr = value;
            }

        }
        public double maximumCurr
        {
            get
            {
                return maxCurr;
            }
            set
            {
                maxCurr = value;
            }

        }
        public double temperature
        {
            get
            {
                return temp;
            }
            set
            {
                temp= value;
            }

        }
        public double duration
        {
            get
            {
                return dur;
            }
            set
            {
                dur = value;
            }

        }
    }
}
