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
    public class ShellSort : ISort
    {
        public List<int> Data { get; set; }

        public bool Add(int value)
        {
            try
            {
                if (value > 0)
                {
                    Data.Add(value);

                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }

        public bool IsSorted()
        {
            if (Data.Count > 1)
            {
                bool isSorted = true;

                for (int i = 0; i < Data.Count - 1; i++)
                {
                    if (Data[i] > Data[i + 1])
                    {
                        isSorted = false;
                    }
                }

                return isSorted;
            }

            return false;
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }
    }
}
