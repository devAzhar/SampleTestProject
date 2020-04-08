using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaTurtles;

namespace SampleProject.Mutation.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, MutationTest]
        public void TestMethod1()
        {
            MutationTestBuilder<SampleMathUtility>
            .For("Max")
            .Run();
        }
    }
}
