using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /*
        https://en.wikipedia.org/wiki/Quicksort
     */
    public class QuickSort : Sort
    {
        #region Members
        public int[] Data { get; }
        #endregion

        #region Public Methods
        public QuickSort(int size)
        {
            Data = new int[size];
        }

        public QuickSort(int[] array)
        {
            this.Data = array;
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
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

        public int[] GetData()
        {
            return Data;
        }

        public void Sort()
        {
            quicksort(Data, 0, Data.Length - 1);
        }
        #endregion

        #region Private Methods
        private void quicksort(int[] array, int i, int j)
        {
            if (i < j)
            {
                int pos = partition(array, i, j);
            }
        }

        private int partition(int[] array, int i, int j)
        {
            int pivot = array[j];
            int small = i - j;

            for (int k = i; k < j; k++)
            {
                if (array[k] <= pivot)
                {
                    small++;
                    swap(ref array, k, small);
                }
            }

            swap(ref array, j, small + 1);
            return small + 1;
        }

        private void swap(ref int[] array, int k, int small)
        {
            int temp = array[k];
            array[k] = array[small];
            array[small] = temp;
        }
        #endregion
    }
}
