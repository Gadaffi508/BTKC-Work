using Microsoft.VisualStudio.TestPlatform;
using NUnit.Framework;
using System.Collections.Generic;
namespace CollectionAssert
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private List<string> kullan�c�lar;
        [Test]
        public void Test1()
        {
            kullan�c�lar.Add("Yusuf");
            kullan�c�lar.Add("Eda");
            kullan�c�lar.Add("P�nar");
        }
        [Test]
        public void ElamanVeS�ras�Ayn�()
        {
            List<string> yenikullan�c�lar = new List<string>();

            yenikullan�c�lar.Add("Yusuf");
            yenikullan�c�lar.Add("Eda");
            yenikullan�c�lar.Add("P�nar");

           //CollectionAssert.AreEqual(kullan�c�lar,yenikullan�c�lar);
        }
        [Test]
        public void ElemanAyn�S�raFark()
        {
            List<string> yenikullan�c�lar = new List<string>();

            yenikullan�c�lar.Add("Eda");
            yenikullan�c�lar.Add("Yusuf");
            yenikullan�c�lar.Add("P�nar");

            //CollectionAssert.AreEquivalent(kullan�c�lar,yenikullan�c�lar);
        }
        [Test]
        public void ElamanVeS�ras�Ayn�Olmama()
        {
            List<string> yenikullan�c�lar = new List<string>();

            yenikullan�c�lar.Add("Yusuf");
            yenikullan�c�lar.Add("P�nar");
            yenikullan�c�lar.Add("Eda");

            //CollectionAssert.AreNotEqual(kullan�c�lar,yenikullan�c�lar);
        }
        [Test]
        public void ElamanFarkl�Olmal�()
        {
            List<string> yenikullan�c�lar = new List<string>();

            yenikullan�c�lar.Add("Yusuf");
            yenikullan�c�lar.Add("P�nar");
            yenikullan�c�lar.Add("Eda");
            yenikullan�c�lar.Add("bilie");

            //CollectionAssert.AreNotEquivalent(kullan�c�lar,yenikullan�c�lar);
        }
        [Test]
        public void Kullan�c�Nulldeg()
        {
            //CollectionAssert.AllItemsAreNotNull(kullan�c�lar);
        }
        [Test]
        public void kullan�c�BenzersizOl()
        {
            //CollectionAssert.AllItemsAreUnique(kullan�c�lar);
        }
        [Test]
        public void T�mElamanAyn�Tipte()
        {
            /*ArrayList liste = new ArrayList
            {
                "P�nar","Eda","Yusuf"
            };*/

            //CollectionAssert.AllItemsAreInstancesOfType(liste,typeof(string));
        }
        [Test]
        public void IsSubsetOf_test()
        {
            List<string> yeniKullan�c� = new List<string> {"Yusuf","Eda","p�nar" };
            List<string> eskiKullan�c� = new List<string> {"lydia","bilie","selena" };

            /*CollectionAssert.IsSubsetOf(yeniKullan�c�,kullan�c�lar);
            CollectionAssert.IsNotSubsetOf(eskiKullan�c�,kullan�c�lar);*/
        }
        [Test]
        public void Contains_test()
        {
            /*CollectionAssert.Contains(kullan�c�lar,"Yusuf");
            CollectionAssert.DoesNotContains(kullan�c�lar,"Isabella");*/
        }
    }
}