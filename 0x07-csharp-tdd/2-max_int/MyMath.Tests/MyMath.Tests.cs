using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Is_Empty()
        {
            List<int> emptyList = new List<int>();
            Assert.AreEqual(0, Operations.Max(emptyList));
        }

        [Test]
        public void Test_Max()
        {
            List<int> list = new List<int>() {1, 2, 3, 4};
            Assert.AreEqual(4, Operations.Max(list));
        }

        [Test]
        public void Text_Max_Beginning()
        {
            List<int> list = new List<int>() {4, 3, 2, 1};
            Assert.AreEqual(4, Operations.Max(list));
        }

        [Test]
        public void Text_Max_Middle()
        {
            List<int> list = new List<int>() {1, 2, 4, 3};
            Assert.AreEqual(4, Operations.Max(list));
        }

        [Test]
        public void Test_Max_For_Negatives()
        {
            List<int> list = new List<int>() {-4, -3, -2, -1};
            Assert.AreEqual(-1, Operations.Max(list));
        }
    }
}