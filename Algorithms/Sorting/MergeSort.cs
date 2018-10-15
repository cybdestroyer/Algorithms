using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    class MergeSort : Sort
    {
        public int[] Data { get; }

        public MergeSort(int size)
        {
            this.Data = new int[size];
        }

        public MergeSort(int[] array)
        {
            this.Data = array;
        }

        public bool Add(int value)
        {
            if (value > 0)
            {
                for (int i = 0; i < Data.Length; i++)
                {
                    if (Data[i] == 0)
                    {
                        Data[i] = value;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool IsSorted()
        {
            return Data.IsSorted();
        }

        public void Sort()
        {
            mSort(Data.ToList());
        }

        private int[] mSort(List<int> unsorted)
        {
            var left = new List<int>();
            var right = new List<int>();

            int middle = unsorted.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = mSort(left).ToList();
            right = mSort(right).ToList();

            return Merge(left, right);
        }

        private int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while(left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result.ToArray();
        }
    }
}
