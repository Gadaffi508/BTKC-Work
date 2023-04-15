namespace Demo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var olcumler = new List<Olcum>()
            {
                new Olcum
                {
                    Enyuksek=10,
                    EnDusuk=1
                }
            };
            var gruplay�c� = new Gruplay�c�(1);
            var gruplar = gruplay�c�.Grupla(olcumler);

            Assert.AreEqual(1, gruplar.Count);
        }
    }
}