using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        #region Members
        private int[] Data { get; set; }
        #endregion

        public BubbleSort(int[] data)
        {
            this.Data = data;
        }

        public void Sort()
        {
            for (int i = Data.Length; i > 0; i--)
            {
                if (Data[i] < Data[i - 1])
                {
                    int tmp = Data[i];
                    Data[i] = Data[i - 1];
                    Data[i - 1] = tmp;
                }
            }
        }

        public int[] GetData()
        {
            return Data;
        }

        public bool IsSorted()
        {
            for (int i = 0; i < Data.Length - 1; i++)
            {
                if (Data[i] > Data[i + 1])
                    return false;
            }

            return true;
        }
    }
}
