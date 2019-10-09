using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /*
        https://en.wikipedia.org/wiki/Shellsort
     */
    public class ShellSort : ComparisonSort
    {
        public ShellSort()
        {
            Data = new List<int>();
        }

        public override void Sort()
        {
            base.Sort();

            if (Data != null && Data.Count > 1)
            {
                int i, j, inc, temp;

                inc = 3;
                while(inc > 0)
                {
                    for (i = 0; i < Data.Count; i++)
                    {
                        j = i;
                        temp = Data[i];
                        while ((j >= inc) && (Data[j - inc] > temp))
                        {
                            Data[j] = Data[j - inc];
                            j = j - inc;
                        }
                        Data[j] = temp;
                    }

                    if (inc / 2 != 0)
                        inc = inc / 2;
                    else if (inc == 1)
                        inc = 0;
                    else
                        inc = 1;
                }
            }
        }
    }
}
