using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        /// Test palindrome
        [Test]
        public void Palindrome()
        {
            Assert.AreEqual(Str.IsPalindrome("Kayak"), true);
        }

        /// Test not palindrome
        [Test]
        public void NotPalindrome()
        {
            Assert.AreEqual(Str.IsPalindrome("Palindrome"), false);
        }

        /// Test a palindrome with ponctuations and space
        [Test]
        public void PalindromPonctuations()
        {
            Assert.AreEqual(Str.IsPalindrome("A man, a plan, a canal: Panama."), true);
        }

        /// Test an empty string
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(Str.IsPalindrome(""), true);
        }
    }
}
