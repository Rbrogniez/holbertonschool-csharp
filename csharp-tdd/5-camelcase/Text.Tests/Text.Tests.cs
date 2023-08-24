using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        /// Test with 1 word
        [Test]
        public void OneWord()
        {
            Assert.AreEqual(Str.CamelCase("hello"), 1);
        }

        /// Test with 2 words
        [Test]
        public void TwoWords()
        {
            Assert.AreEqual(Str.CamelCase("helloWorld"), 2);
        }

        /// Test with 4 words
        [Test]
        public void FourWords()
        {
            Assert.AreEqual(Str.CamelCase("helloWorldIsMine"), 4);
        }

        /// Test with an empty string
        [Test]
        public void EmptyString()
        {
            Assert.AreEqual(Str.CamelCase(""), 0);
        }
    }
}
