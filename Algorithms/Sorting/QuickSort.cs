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
    public class QuickSort : ComparisonSort
    {
        public QuickSort()
        {
            Data = new List<int>();
        }

        public override void Sort()
        {
            try
            {
                QuicksortRecursive(Data, 0, Data.Count - 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\t{ex.InnerException}\n");
            }
        }

        private int Partition(List<int> numbers, int left, int right)
        {
            int pivot = numbers[left];

            do
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }

                while (numbers[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }

            } while (true);
        }

        private void QuicksortRecursive(List<int> array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                    QuicksortRecursive(array, left, pivot - 1);

                if (pivot + 1 < right)
                    QuicksortRecursive(array, pivot + 1, right);
            }
        }
    }
}
