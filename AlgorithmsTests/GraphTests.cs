using DataStructures.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        [TestCategory("Graph Tests - Basic")]
        public void GraphTest01()
        {
            var graph = new Graph(16);

            // Add 16 Vertices
            Assert.IsTrue(graph.AddVertex("A"));
            Assert.IsTrue(graph.AddVertex("B"));
            Assert.IsTrue(graph.AddVertex("C"));
            Assert.IsTrue(graph.AddVertex("D"));
            Assert.IsTrue(graph.AddVertex("E"));
            Assert.IsTrue(graph.AddVertex("F"));
            Assert.IsTrue(graph.AddVertex("G"));
            Assert.IsTrue(graph.AddVertex("H"));
            Assert.IsTrue(graph.AddVertex("I"));
            Assert.IsTrue(graph.AddVertex("J"));
            Assert.IsTrue(graph.AddVertex("K"));
            Assert.IsTrue(graph.AddVertex("L"));
            Assert.IsTrue(graph.AddVertex("M"));
            Assert.IsTrue(graph.AddVertex("N"));
            Assert.IsTrue(graph.AddVertex("O"));
            Assert.IsTrue(graph.AddVertex("P"));

            // Should not be able to add 17th vertex
            Assert.IsFalse(graph.AddVertex("Q"));

            // Add Weights
            Assert.IsTrue(graph.AddEdge("A", "B", 1));
            Assert.IsTrue(graph.AddEdge("A", "C", 1));
            Assert.IsTrue(graph.AddEdge("B", "D", 3));
            Assert.IsTrue(graph.AddEdge("C", "D", 3));
            Assert.IsTrue(graph.AddEdge("B", "E", 1));
            Assert.IsTrue(graph.AddEdge("D", "H", 8));
            Assert.IsTrue(graph.AddEdge("C", "F", 1));
            Assert.IsTrue(graph.AddEdge("E", "H", 3));
            Assert.IsTrue(graph.AddEdge("F", "H", 3));
            Assert.IsTrue(graph.AddEdge("E", "G", 1));
            Assert.IsTrue(graph.AddEdge("F", "I", 1));
            Assert.IsTrue(graph.AddEdge("H", "J", 8));
            Assert.IsTrue(graph.AddEdge("H", "K", 8));
            Assert.IsTrue(graph.AddEdge("G", "L", 1));
            Assert.IsTrue(graph.AddEdge("I", "N", 1));
            Assert.IsTrue(graph.AddEdge("G", "J", 3));
            Assert.IsTrue(graph.AddEdge("I", "K", 3));
            Assert.IsTrue(graph.AddEdge("J", "O", 3));
            Assert.IsTrue(graph.AddEdge("K", "P", 3));
            Assert.IsTrue(graph.AddEdge("H", "M", 3));
            Assert.IsTrue(graph.AddEdge("L", "O", 1));
            Assert.IsTrue(graph.AddEdge("O", "M", 1));
            Assert.IsTrue(graph.AddEdge("M", "P", 1));
            Assert.IsTrue(graph.AddEdge("P", "N", 1));

            // Bi-Directional Edges
            Assert.IsTrue(graph.HasEdge("N", "P"));
            Assert.IsTrue(graph.HasEdge("M", "P"));
            Assert.IsTrue(graph.HasEdge("O", "L"));
            Assert.IsTrue(graph.HasEdge("G", "L"));
        }
    }
}
