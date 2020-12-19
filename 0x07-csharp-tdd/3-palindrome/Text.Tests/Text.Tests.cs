using NUnit.Framework;
using Text;

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
        public void Test_Empty_String()
        {
            Assert.IsTrue(Str.IsPalindrome(string.Empty));
        }

        [Test]
        public void Test_Not_Palindrome()
        {
            Assert.IsFalse(Str.IsPalindrome("politics"));
        }

        [Test]
        public void Test_Palindrome_Lowercase()
        {
            Assert.IsTrue(Str.IsPalindrome("racecar"));
        }

        [Test]
        public void Test_Palindrome_Case_Insensitive()
        {
            Assert.IsTrue(Str.IsPalindrome("Level"));
        }

        [Test]
        public void Test_Palindrome_Ignoring_Spaces_And_Puntuation()
        {
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }
    }
}