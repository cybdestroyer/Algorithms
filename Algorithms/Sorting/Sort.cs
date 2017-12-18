using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public interface Sort
    {
        bool IsSorted();
        bool Add(int value);

        int[] GetData();
    }
}
