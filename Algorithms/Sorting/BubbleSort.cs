using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /*
        https://en.wikipedia.org/wiki/Bubble_sort
     */
    public class BubbleSort : ComparisonSort
    {
        public BubbleSort()
        {
            Data = new List<int>();
        }

        public override void Sort()
        {
            try
            {
                if (Data != null && Data.Count > 1)
                {
                    for (int i = 0; i < Data.Count; i++)
                    {
                        for (int j = 0; j < (Data.Count - 1) - i; j++)
                        {
                            if (Data[j] > Data[j + 1])
                            {
                                var temp = Data[j];
                                Data[j] = Data[j + 1];
                                Data[j + 1] = temp;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\t{ex.InnerException}\n");
            }
        }
    }
}
