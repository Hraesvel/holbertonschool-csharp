using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Racecar", ExpectedResult=true)]
        [TestCase("racecar", ExpectedResult=true)]
        [TestCase("A man, a plan, a canal: Panama.", ExpectedResult=true)]
        [TestCase("fish", ExpectedResult=false)]
        [TestCase("", ExpectedResult=true)]
        [TestCase(null, ExpectedResult=true)]
        public bool IsPalindromeTest(string s)
        {
            return Text.Str.IsPalindrome(s);
        }
    }
}