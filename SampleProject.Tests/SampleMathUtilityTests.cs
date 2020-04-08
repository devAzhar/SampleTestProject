namespace SampleProject.Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;
    using SampleProject.Tests.Base;

    [TestClass]
    public class SampleMathUtilityTests : TestsBase, IDisposable
    {
        private SampleMathUtility SampleMathUtility { get; set; }

        // Setup
        public SampleMathUtilityTests()
        {
            var mockMultiplier = this.MockRepository.Create<IMultiplier>();
            mockMultiplier.Setup(x => x.Multiply(It.IsAny<int>(), It.IsAny<int>())).Returns<int, int>((a, b) => a * b);
            this.SampleMathUtility = new SampleMathUtility(mockMultiplier.Object);
        }

        // Tear-down
        public void Dispose()
        {
            // this.MockRepository.VerifyAll();
        }

        [DataTestMethod]
        [CustomPowerDataSource]
        [Timeout(1000)]
        public void Test_Power_With_Same_Numbers(int x, double expected)
        {
            var actual = this.SampleMathUtility.Power(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Power_With_Same_Numbers2()
        {
            var actual = this.SampleMathUtility.Power(2);
            var expected = 4d;
            Assert.AreEqual(expected, actual);
        }

        //[DynamicData(nameof(Data), DynamicDataSourceType.Property)]
        [TestMethod]
        [DataRow(2, 2, 4)]
        [DataRow(2, 5, 10)]
        public void Test_Multiply_With_Same_Numbers(int x, int y, long expected)
        {
            var actual = this.SampleMathUtility.Multiply(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Max_With_Different_Numbers()
        {
            var expected = 12;
            var actual = this.SampleMathUtility.Max(10, 12, 11);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Max_With_Two_Same_Numbers()
        {
            var expected = 2;
            var actual = this.SampleMathUtility.Max(1, 2, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Max_With_All_Same_Numbers()
        {
            var expected = 1;
            var actual = this.SampleMathUtility.Max(1, 1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Max_With_Negative_Numbes()
        {
            var expected = -2;
            var actual = this.SampleMathUtility.Max(-10, -20, -2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Greater_With_All_Same_Numbers()
        {
            var expected = false;
            var actual = this.SampleMathUtility.IsFirstGreater(10, 10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Greater_With_First_Greater()
        {
            var expected = true;
            var actual = this.SampleMathUtility.IsFirstGreater(10, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Greater_With_First_Smaller()
        {
            var expected = false;
            var actual = this.SampleMathUtility.IsFirstGreater(5, 6);
            Assert.AreEqual(expected, actual);
        }
    }
}
