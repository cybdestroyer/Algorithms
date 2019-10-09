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
            var bubbleSort = new BubbleSort();
            // Assert you can add integers
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

            // Assert Data is accessible
            Assert.AreEqual(10, bubbleSort.Data.Count);

            bubbleSort.Sort();

            // Validate Array is Sorted
            Assert.IsTrue(bubbleSort.IsSorted());
        }

        [TestMethod]
        [TestCategory("BubbleSort - Negative Numbers")]
        public void BubbleSort2()
        {
            var bubbleSort = new BubbleSort();
            Assert.IsTrue(bubbleSort.Add(20));
            Assert.IsTrue(bubbleSort.Add(-13));
            Assert.IsTrue(bubbleSort.Add(35));
            Assert.IsTrue(bubbleSort.Add(157));
            Assert.IsTrue(bubbleSort.Add(-1));
            Assert.IsTrue(bubbleSort.Add(9));

            bubbleSort.Sort();

            Assert.IsTrue(bubbleSort.IsSorted());
        }

        [TestMethod]
        [TestCategory("ShellSort - Basic")]
        public void SellSort1()
        {
            var shellSort = new ShellSort();
            Assert.IsTrue(shellSort.Add(43));
            Assert.IsTrue(shellSort.Add(7));
            Assert.IsTrue(shellSort.Add(11));
            Assert.IsTrue(shellSort.Add(68));
            Assert.IsTrue(shellSort.Add(55));
            Assert.IsTrue(shellSort.Add(22));
            Assert.IsTrue(shellSort.Add(102));
            Assert.IsTrue(shellSort.Add(3));

            shellSort.Sort();

            Assert.IsTrue(shellSort.IsSorted());
        }

        [TestMethod]
        [TestCategory("QuickSort - Basic")]
        public void QuickSort1()
        {
            var quickSort = new QuickSort();
            quickSort.Add(14);
            quickSort.Add(11);
            quickSort.Add(6);
            quickSort.Add(3);
            quickSort.Add(134);
            quickSort.Add(44);
            quickSort.Add(87);

            quickSort.Sort();

            Assert.IsTrue(quickSort.IsSorted());
        }
    }
}