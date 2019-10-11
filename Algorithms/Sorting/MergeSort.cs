using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSort : ComparisonSort
    {
        public MergeSort()
        {
            Data = new List<int>();
        }

        public override void Sort()
        {
            try
            {
                Data = PerformMergeSort(Data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n\t{ex.InnerException}\n");
            }
        }

        private List<int> PerformMergeSort(List<int> unsorted)
        {
            // If only 1 element then list is sorted
            if (unsorted.Count <= 1)
                return unsorted;

            var left = new List<int>();
            var right = new List<int>();

            // Divide list into sub-groups
            int middle = unsorted.Count / 2;
            for(int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for(int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            // Break into Left
            left = PerformMergeSort(left);
            // Break into Right
            right = PerformMergeSort(right);

            return PerformMerge(left, right);
        }

        private List<int> PerformMerge(List<int> left, List<int> right)
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

            return result;
        }
    }
}
