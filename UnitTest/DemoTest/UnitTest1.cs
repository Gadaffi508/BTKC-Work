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
            Assert.AreEqual(beklenen,gerceklesen,"{0} say�s�n�n karek�k� {1} olamilidir",girilenDeger,beklenen);
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
            var digerSay�lar = sayilar;
            sayilar[0] = 4;
            Assert.AreSame(sayilar,digerSay�lar);
        }
        [Test]
        public void Test6()
        {
            int a = 10;
            int b = a;
            Assert.AreEqual(a, b,"Areaqual Failed");
            Assert.AreNotEqual(a,b,"AreaSame Failed");
        }
        [Test]
        public void Test7()
        {
            Assert.AreEqual(1,1);
            Assert.Inconclusive("Bu test yeterli de�il");
        }
        [Test]
        public void Test8()
        {
            var say� = 5m;
            //Assert.IsInstanceOf(say�,typeof(decimal));
            //Assert.IsNotInstanceOf(say�,typeof(int));
        }
        [Test]
        public void Test9()
        {
            Assert.IsTrue(10%2==0);
            Assert.IsFalse(10%2==1);
        }
        [Test]
        public void Test10()
        {
            List<string> say�lar = new List<string> {"Yusuf","Eda","P�nar"};

            var cIleBaslayanIlkIs�m = say�lar.FirstOrDefault(t=>t.StartsWith("C"));
            var yIleBaslayanIlkIs�m = say�lar.FirstOrDefault(t=>t.StartsWith("Y"));

            Assert.IsNull(cIleBaslayanIlkIs�m,"IsNull Ba�ar�s�z oldu");
            Assert.IsNotNull(yIleBaslayanIlkIs�m,"IsNotnull ba�ar�s�z oldu");

        }
        [Test]
        public void Test11()
        {
            try
            {
                var sayi = 5;
                int sonuc = sayi / 0;
            }
            catch (DivideByZeroException)
            {

                Assert.Fail("Test Ba�ar�s�z oldu");
            }
        }
    }
}