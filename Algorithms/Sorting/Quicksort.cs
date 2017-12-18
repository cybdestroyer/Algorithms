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
    public class Quicksort : Sort
    {
        #region Members
        private int[] Data { get; set; }
        #endregion

        #region Public Methods
        public Quicksort(int size)
        {
            Data = new int[size];
        }

        public Quicksort(int[] array)
        {
            this.Data = array;
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        public bool Add(int value)
        {
            throw new NotImplementedException();
        }

        public int[] GetData()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
