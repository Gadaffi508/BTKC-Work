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

        private List<string> kullanýcýlar;
        [Test]
        public void Test1()
        {
            kullanýcýlar.Add("Yusuf");
            kullanýcýlar.Add("Eda");
            kullanýcýlar.Add("Pýnar");
        }
        [Test]
        public void ElamanVeSýrasýAyný()
        {
            List<string> yenikullanýcýlar = new List<string>();

            yenikullanýcýlar.Add("Yusuf");
            yenikullanýcýlar.Add("Eda");
            yenikullanýcýlar.Add("Pýnar");

           //CollectionAssert.AreEqual(kullanýcýlar,yenikullanýcýlar);
        }
        [Test]
        public void ElemanAynýSýraFark()
        {
            List<string> yenikullanýcýlar = new List<string>();

            yenikullanýcýlar.Add("Eda");
            yenikullanýcýlar.Add("Yusuf");
            yenikullanýcýlar.Add("Pýnar");

            //CollectionAssert.AreEquivalent(kullanýcýlar,yenikullanýcýlar);
        }
        [Test]
        public void ElamanVeSýrasýAynýOlmama()
        {
            List<string> yenikullanýcýlar = new List<string>();

            yenikullanýcýlar.Add("Yusuf");
            yenikullanýcýlar.Add("Pýnar");
            yenikullanýcýlar.Add("Eda");

            //CollectionAssert.AreNotEqual(kullanýcýlar,yenikullanýcýlar);
        }
        [Test]
        public void ElamanFarklýOlmalý()
        {
            List<string> yenikullanýcýlar = new List<string>();

            yenikullanýcýlar.Add("Yusuf");
            yenikullanýcýlar.Add("Pýnar");
            yenikullanýcýlar.Add("Eda");
            yenikullanýcýlar.Add("bilie");

            //CollectionAssert.AreNotEquivalent(kullanýcýlar,yenikullanýcýlar);
        }
        [Test]
        public void KullanýcýNulldeg()
        {
            //CollectionAssert.AllItemsAreNotNull(kullanýcýlar);
        }
        [Test]
        public void kullanýcýBenzersizOl()
        {
            //CollectionAssert.AllItemsAreUnique(kullanýcýlar);
        }
        [Test]
        public void TümElamanAynýTipte()
        {
            /*ArrayList liste = new ArrayList
            {
                "Pýnar","Eda","Yusuf"
            };*/

            //CollectionAssert.AllItemsAreInstancesOfType(liste,typeof(string));
        }
        [Test]
        public void IsSubsetOf_test()
        {
            List<string> yeniKullanýcý = new List<string> {"Yusuf","Eda","pýnar" };
            List<string> eskiKullanýcý = new List<string> {"lydia","bilie","selena" };

            /*CollectionAssert.IsSubsetOf(yeniKullanýcý,kullanýcýlar);
            CollectionAssert.IsNotSubsetOf(eskiKullanýcý,kullanýcýlar);*/
        }
        [Test]
        public void Contains_test()
        {
            /*CollectionAssert.Contains(kullanýcýlar,"Yusuf");
            CollectionAssert.DoesNotContains(kullanýcýlar,"Isabella");*/
        }
    }
}