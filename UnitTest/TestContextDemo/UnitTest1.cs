namespace TestContextDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public TestContext TestContext { get; set; }

        [Test]
        public void Test1()
        {
            TestContext.WriteLine("--Test1--");
            TestContext.WriteLine("Test Adý: {0}");
            TestContext.WriteLine("Test Durumu : {0}",TestContext.CurrentContext);
            TestContext.WriteLine("Test Sýnýfý : {0}"   );

            Assert.AreEqual(1, 1);
        }
        [Test]
        public void TestCleanup()
        {
            TestContext.WriteLine("--TestCleanup--");
            TestContext.WriteLine("Test Adý: {0}");
            TestContext.WriteLine("Test Durumu : {0}", TestContext.CurrentContext);

            Assert.AreEqual(1, 1);
        }
        [Test]
        public void TestInitalize()
        {
            TestContext.WriteLine("--TestInitalize--");
            TestContext.WriteLine("Test Adý: {0}");
            TestContext.WriteLine("Test Durumu : {0}", TestContext.CurrentContext);

            Assert.AreEqual(1, 1);
        }
    }
}