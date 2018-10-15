using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public interface Sort
    {
        int[] Data { get; }

        bool IsSorted();
        bool Add(int value);

        void Sort();
    }
}
