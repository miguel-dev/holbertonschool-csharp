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
        public void Test_Empty()
        {
            Assert.AreEqual(-1, Str.UniqueChar(string.Empty));
        }

        [Test]
        public void Test_First_Unique()
        {
            Assert.AreEqual(0, Str.UniqueChar("house"));
        }

        [Test]
        public void Test_Unique_Middle()
        {
            Assert.AreEqual(2, Str.UniqueChar("velvet"));
        }

        [Test]
        public void Test_Unique_End()
        {
            Assert.AreEqual(2, Str.UniqueChar("eel"));
        }

        [Test]
        public void Test_Not_Unique()
        {
            Assert.AreEqual(-1, Str.UniqueChar("mama"));
        }
    }
}