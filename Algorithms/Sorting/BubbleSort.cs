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
    public class BubbleSort : Sort
    {
        #region Members
        private int[] Data { get; set; }
        #endregion

        #region Public Methods
        public BubbleSort(int size)
        {
            Data = new int[size];
        }

        public BubbleSort(int[] data)
        {
            this.Data = data;
        }

        public bool Add(int value)
        {
            for (int i = 0; i < Data.Length; i++)
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
            for (int i = 0; i < Data.Length; i++)
            {
                for (int j = 0; j < Data.Length - i - 1; j++)
                {
                    if (Data[j] > Data[j + 1])
                    {
                        int temp = Data[j];
                        Data[j] = Data[j + 1];
                        Data[j + 1] = temp;
                    }
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

        public string toString()
        {
            return toString(Data);
        }
        #endregion

        #region Private Methods
        private string toString(int[] array)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < array.Length; i++)
            {
                sb.Append("[" + array[i].ToString() + "]\t");
            }

            return sb.ToString();
        }
        #endregion
    }
}
