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
            //StringAssert.Contains("Test Dünyasý merhaba " , " yas");
        }
        [Test]
        public void StringMatchestest()
        {
            //StringAssert.Matches("Test Dünyasý merhaba " , new Regex(@"[a-zA-z]"));
            //StringAssert.DoesNotMatches("Test Dünyasý merhaba " , new Regex(@"[0-9]"));
        }
        [Test]
        public void StartsWithTest()
        {
            //StringAssert.StartsWith("Test Dünyasý Merhaba ", " Test");
        }
        [Test]
        public void EndsWithTest()
        {
            //StringAssert.EndsWith("Test Dünyasý Merhaba ", " Merhaba");
        }
    }
}