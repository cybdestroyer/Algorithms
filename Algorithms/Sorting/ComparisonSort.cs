using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class ComparisonSort : ISort
    {
        public List<int> Data { get; set; }

        public bool Add(int value)
        {
            try
            {
                Data.Add(value);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\t{ex.InnerException}\n");
            }

            return false;
        }

        public bool IsSorted()
        {
            var isSorted = true;

            try
            {
                for (int i = 0; i < (Data.Count - 1); i++)
                {
                    if (Data[i] > Data[i + 1])
                        isSorted = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\t{ex.InnerException}\n");
            }

            return isSorted;
        }

        public virtual void Sort() { }
    }
}
