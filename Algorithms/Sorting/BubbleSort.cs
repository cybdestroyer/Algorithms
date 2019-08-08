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
    public class BubbleSort : ISort
    {
        #region Members
        public List<int> Data { get; set; }
        #endregion

        #region Public Methods
        public bool Add(int value)
        {
            for (int i = 0; i < Data.Count; i++)
            {
                if (Data[i] == 0)
                {
                    Data[i] = value;
                    return true;
                }
            }

            return false;
        }

        public void Sort()
        {
            
        }

        public bool IsSorted()
        {
           
            return true;
        }
        #endregion
    }
}
