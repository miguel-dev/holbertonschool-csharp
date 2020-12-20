using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Empty()
        {
            Assert.AreEqual(0, Str.CamelCase(string.Empty));
        }

        [Test]
        public void Test_Multi_Words()
        {
            Assert.AreEqual(2, Str.CamelCase("camelCase"));
        }

        [Test]
        public void Test_Single_Word()
        {
            Assert.AreEqual(1, Str.CamelCase("camel"));
        }
    }
}