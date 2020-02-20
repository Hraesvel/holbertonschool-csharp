using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Racecar", ExpectedResult = true)]
        [TestCase("racecar", ExpectedResult = true)]
        [TestCase("A man, a plan, a canal: Panama.", ExpectedResult = true)]
        [TestCase("fish", ExpectedResult = false)]
        [TestCase("", ExpectedResult = true)]
        [TestCase(null, ExpectedResult = true)]
        public bool IsPalindromeTest(string s)
        {
            return Text.Str.IsPalindrome(s);
        }

        [TestCase("abc", ExpectedResult = 0)]
        [TestCase("", ExpectedResult = -1)]
        [TestCase("aaa", ExpectedResult = -1)]
        [TestCase("text", ExpectedResult = 1)]
        [TestCase("txext", ExpectedResult = 2)]
        [TestCase("xabctxextabc", ExpectedResult = 6)]
        [TestCase("xqabctxextzabc", ExpectedResult = 1)]
        public int UniqueCharTest(string s)
        {
            return Text.Str.UniqueChar(s);
        }

        [Test]
        public void UniqueCharNullTest()
        {
            Assert.AreEqual(Text.Str.UniqueChar(null), -1);
        }

        [TestCase("fishermansTale", ExpectedResult = 2)]
        [TestCase("camel", ExpectedResult = 1)]
        [TestCase("camelCase", ExpectedResult = 2)]
        [TestCase("", ExpectedResult = 0)]
        public int CamelCaseTest(string s)
        {
            return Text.Str.CamelCase(s);
        }
    }
}