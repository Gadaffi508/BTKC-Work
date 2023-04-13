namespace DemoTest
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
            const double girilenDeger = 16;
            const double beklenen = 4;
            double gerceklesen = Math.Sqrt(girilenDeger);
            Assert.AreEqual(beklenen,gerceklesen,"{0} sayýsýnýn karekökü {1} olamilidir",girilenDeger,beklenen);
        }
        [Test]
        public void Test2()
        {
            double beklenen = 3.1622;
            double delta = 0.0001;

            double gercek = Math.Sqrt(10);
            Assert.AreEqual(beklenen,gercek,delta);
        }
        [Test]
        public void Test3()
        {
            string beklenen = "Merhaba";
            string gerceklesen = "merhaba";

            Assert.AreEqual(beklenen,gerceklesen);
        }
        [Test]
        public void Test4()
        {
            const double beklenmeyen = 0;
            var gerceklesen = Math.Pow(5,0);
            Assert.AreNotEqual(beklenmeyen,gerceklesen);
        }
        [Test]
        public void Test5()
        {
            var sayilar = new byte[] {1 , 2 , 3};
            var digerSayýlar = sayilar;
            sayilar[0] = 4;
            Assert.AreSame(sayilar,digerSayýlar);
        }
        [Test]
        public void Test6()
        {
            int a = 10, b = a;
            Assert.AreEqual(a, b,"Areaqual Failed");
            Assert.AreNotSame(a,b,"AreaSame Failed");
        }
    }
}