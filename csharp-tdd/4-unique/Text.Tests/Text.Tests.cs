using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        /// Test when the first char is unique
        [Test]
        public void FirstUnique()
        {
            Assert.AreEqual(Str.UniqueChar("Hello World"), 0);
        }

        /// Test when the last char is unique
        [Test]
        public void LastUnique()
        {
            Assert.AreEqual(Str.UniqueChar("aabbccdde"), 8);
        }

        /// Test when the middle char is unique
        [Test]
        public void MiddleUnique()
        {
            Assert.AreEqual(Str.UniqueChar("aabbcddee"), 4);
        }

        /// Test when there is no unique char
        [Test]
        public void NoUnique()
        {
            Assert.AreEqual(Str.UniqueChar("abccba"), -1);
        }

        /// Test with an empty string
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(Str.UniqueChar(""), -1);
        }
    }
}
