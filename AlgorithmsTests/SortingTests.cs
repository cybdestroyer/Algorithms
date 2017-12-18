using Algorithms.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        [TestCategory("Bubble Sort - Basic")]
        public void BubbleSort1()
        {
            var bubbleSort = new BubbleSort(10);
            Assert.IsTrue(bubbleSort.Add(12));
            Assert.IsTrue(bubbleSort.Add(8));
            Assert.IsTrue(bubbleSort.Add(21));
            Assert.IsTrue(bubbleSort.Add(78));
            Assert.IsTrue(bubbleSort.Add(6));
            Assert.IsTrue(bubbleSort.Add(43));
            Assert.IsTrue(bubbleSort.Add(48));
            Assert.IsTrue(bubbleSort.Add(50));
            Assert.IsTrue(bubbleSort.Add(17));
            Assert.IsTrue(bubbleSort.Add(103));

            Assert.IsFalse(bubbleSort.Add(10000));
        }

        [TestMethod]
        [TestCategory("BubbleSort - ")]
        public void BubbleSort2()
        {
            var bubbleSort = new BubbleSort(4);
            bubbleSort.Add(4);
            bubbleSort.Add(3);
            bubbleSort.Add(2);
            bubbleSort.Add(1);

            Assert.IsFalse(bubbleSort.Add(0));

            bubbleSort.Sort();

            Assert.IsTrue(bubbleSort.IsSorted());
        }

        [TestMethod]
        [TestCategory("BubbleSort - ")]
        public void BubbleSort3()
        {
            int size = 20;

            var bubbleSort = new BubbleSort(size);

            for (int i = size - 1; i >= 0; i--)
            {
                Assert.IsTrue(bubbleSort.Add(i));
            }

            bubbleSort.Sort();

            Assert.IsTrue(bubbleSort.IsSorted());
        }

        [TestMethod]
        [TestCategory("BubbleSort - Negatives")]
        public void BubbleSort4()
        {
            var bubbleSort = new BubbleSort(5);
            bubbleSort.Add(-1);
            bubbleSort.Add(-2);
            bubbleSort.Add(-3);
            bubbleSort.Add(-4);
            bubbleSort.Add(-5);

            bubbleSort.Sort();

            Assert.IsTrue(bubbleSort.IsSorted());
        }
    }
}