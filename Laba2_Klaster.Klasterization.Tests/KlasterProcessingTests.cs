using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laba2_Klaster.Klasterization.Tests
{
    [TestClass]
    public class KlasterProcessingTests
    {
        private bool[,] originMatrix;
        private KlasterProcessing processor;

        [TestInitialize]
        public void Initialize()
        {
            this.processor = new KlasterProcessing();

            this.originMatrix = new bool[,]
            {
                { true, false, true, true, false, false, false, false },
                { false, false, true, true, false, false, false, false },
                { true, true, true, true, false, false, false, false },
                { true, true, true, true, false, true, true, false },
                { false, false, false, false, false, true, true, false },
                { false, false, false, false, false, false, false, false}
            };
        }

        [TestMethod]
        public void TestMethod1()
        {
            var expected = new int[,]
            {
                { 1, 0, 2, 2, 0, 0, 0, 0 },
                { 0, 0, 2, 2, 0, 0, 0, 0 },
                { 2, 2, 2, 2, 0, 0, 0, 0 },
                { 2, 2, 2, 2, 0, 3, 3, 0 },
                { 0, 0, 0, 0, 0, 3, 3, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            var result = this.processor.Labeling(this.originMatrix);

            ArrayEquals(expected, result);
        }

        private void ArrayEquals(int[,] expected, int[,] actual)
        {
            for (var j = 0; j < expected.GetLength(0); ++j)
            {
                for (var i = 0; i < expected.GetLength(1); ++i)
                {
                    Assert.AreEqual(expected[j, i], actual[j, i]);
                }
            }
        }
    }
}
