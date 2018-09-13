using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laba2_Klaster.Klasterization.Tests
{
    [TestClass]
    public class KlasterProcessingTests
    {
        private bool[,] originMatrix;
        private int[,] expectedMatrix;
        private int[,] matrixForKlasterization;
        private KlasterProcessing processor;

        [TestInitialize]
        public void Initialize()
        {
            this.processor = new KlasterProcessing();

            this.originMatrix = new bool[,]
            {
                { true,  true,  false, false, false, false, false, false, true,  true,  true,  true },
                { true,  false, false, false, false, true,  false, false, false, true,  true,  true },
                { false, false, false, false, true,  true,  true,  false, false, false, true,  true },
                { false, false, false, true,  true,  true,  true,  true,  false, false, false, false },
                { true,  false, true,  true,  true,  true,  true,  true,  true,  false, false, false },
                { true,  false, false, true,  true,  true,  true,  true,  false, false, false, false },
                { true,  true,  false, false, true,  false, true,  false, false, false, false, false },
                { true,  true,  true,  false, false, false, false, false, false, false, false, false }
            };

            this.expectedMatrix = new int[,]
            {
                { 1, 1, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2 },
                { 1, 0, 0, 0, 0, 3, 0, 0, 0, 2, 2, 2 },
                { 0, 0, 0, 0, 3, 3, 3, 0, 0, 0, 2, 2 },
                { 0, 0, 0, 3, 3, 3, 3, 3, 0, 0, 0, 0 },
                { 6, 0, 3, 3, 3, 3, 3, 3, 3, 0, 0, 0 },
                { 6, 0, 0, 3, 3, 3, 3, 3, 0, 0, 0, 0 },
                { 6, 6, 0, 0, 3, 0, 3, 0, 0, 0, 0, 0 },
                { 6, 6, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            this.matrixForKlasterization = new int[,]
            {
                { 1, 1, 0, 2, 2, 2, 2, 0 },
                { 1, 1, 0, 2, 2, 2, 2, 0 },
                { 0, 0, 0, 2, 2, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 3, 3, 3, 0, 0, 0, 4, 4 },
                { 3, 3, 3, 0, 0, 0, 4, 4 },
                { 3, 3, 0, 0, 0, 0, 0, 0 },
                { 3, 3, 0, 0, 0, 0, 0, 0 }
            };
        }

        [TestMethod]
        public void TestLabeling()
        {
            var result = this.processor.Labeling(this.originMatrix);

            ArrayEquals(this.expectedMatrix, result);
        }

        [TestMethod]
        public void TestSquere()
        {
            var expected = 3;
            var expected1 = 9;
            var expected2 = 23;

            var result = this.processor.Squere(this.expectedMatrix, 1);
            var result1 = this.processor.Squere(this.expectedMatrix, 2);
            var result2 = this.processor.Squere(this.expectedMatrix, 3);

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            var expected = 3;
            var expected1 = 8;
            var expected2 = 12;
            var expected3 = 7;

            var result = this.processor.Perimeter(this.expectedMatrix, 1);
            var result1 = this.processor.Perimeter(this.expectedMatrix, 2);
            var result2 = this.processor.Perimeter(this.expectedMatrix, 3);
            var result3 = this.processor.Perimeter(this.expectedMatrix, 6);

            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
            Assert.AreEqual(expected3, result3);
        }

        [TestMethod]
        public void TestKlastering()
        {
            var listOfObjects = this.processor.CreateListOfObjects(this.matrixForKlasterization);

            var result = this.processor.DivideOnKlastersAsync(2, listOfObjects).GetAwaiter().GetResult();

            Assert.IsNotNull(result);
        }

        private void ArrayEquals(int[,] expected, int[,] actual)
        {
            for (var j = 0; j < expected.GetLength(0); ++j)
            {
                for (var i = 0; i < expected.GetLength(1); ++i)
                {
                    Assert.AreEqual(expected[j, i], actual[j, i], $"Not equal in [{j},{i}]");
                }
            }
        }
    }
}
