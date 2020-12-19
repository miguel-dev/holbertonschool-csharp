using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_First_Unique()
        {
            Assert.AreEqual(0, Str.UniqueChar("house"));
        }

        [Test]
        public void Test_Not_Unique()
        {
            Assert.AreEqual(-1, Str.UniqueChar("mama"));
        }
    }
}