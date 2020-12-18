using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests_Sum
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(5, 2, 7)]
        [TestCase(7, -3, 4)]
        [TestCase(3, -7, -4)]
        [TestCase(3, 0, 3)]
        public void isSum(int a, int b, int sum)
        {
            Assert.AreEqual(sum, Operations.Add(a, b));
        }
    }
}