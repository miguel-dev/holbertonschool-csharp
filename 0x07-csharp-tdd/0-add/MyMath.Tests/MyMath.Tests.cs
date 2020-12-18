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

        [Test]
        public void isSum()
        {
            var sum = Operations.Add(5, 3);
            Assert.AreEqual(sum, 5 + 3);
        }
    }
}