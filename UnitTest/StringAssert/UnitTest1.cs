using NUnit.Framework;

namespace StringAssert
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StringContainstest()
        {
            //StringAssert.Contains("Test D�nyas� merhaba " , " yas");
        }
        [Test]
        public void StringMatchestest()
        {
            //StringAssert.Matches("Test D�nyas� merhaba " , new Regex(@"[a-zA-z]"));
            //StringAssert.DoesNotMatches("Test D�nyas� merhaba " , new Regex(@"[0-9]"));
        }
        [Test]
        public void StartsWithTest()
        {
            //StringAssert.StartsWith("Test D�nyas� Merhaba ", " Test");
        }
        [Test]
        public void EndsWithTest()
        {
            //StringAssert.EndsWith("Test D�nyas� Merhaba ", " Merhaba");
        }
    }
}