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

        private List<string> kullanıcılar;
        [Test]
        public void Test1()
        {
            kullanıcılar.Add("Yusuf");
            kullanıcılar.Add("Eda");
            kullanıcılar.Add("Pınar");
        }
        [Test]
        public void ElamanVeSırasıAynı()
        {
            List<string> yenikullanıcılar = new List<string>();

            yenikullanıcılar.Add("Yusuf");
            yenikullanıcılar.Add("Eda");
            yenikullanıcılar.Add("Pınar");

           //CollectionAssert.AreEqual(kullanıcılar,yenikullanıcılar);
        }
        [Test]
        public void ElemanAynıSıraFark()
        {
            List<string> yenikullanıcılar = new List<string>();

            yenikullanıcılar.Add("Eda");
            yenikullanıcılar.Add("Yusuf");
            yenikullanıcılar.Add("Pınar");

            //CollectionAssert.AreEquivalent(kullanıcılar,yenikullanıcılar);
        }
        [Test]
        public void ElamanVeSırasıAynıOlmama()
        {
            List<string> yenikullanıcılar = new List<string>();

            yenikullanıcılar.Add("Yusuf");
            yenikullanıcılar.Add("Pınar");
            yenikullanıcılar.Add("Eda");

            //CollectionAssert.AreNotEqual(kullanıcılar,yenikullanıcılar);
        }
        [Test]
        public void ElamanFarklıOlmalı()
        {
            List<string> yenikullanıcılar = new List<string>();

            yenikullanıcılar.Add("Yusuf");
            yenikullanıcılar.Add("Pınar");
            yenikullanıcılar.Add("Eda");
            yenikullanıcılar.Add("bilie");

            //CollectionAssert.AreNotEquivalent(kullanıcılar,yenikullanıcılar);
        }
        [Test]
        public void KullanıcıNulldeg()
        {
            //CollectionAssert.AllItemsAreNotNull(kullanıcılar);
        }
        [Test]
        public void kullanıcıBenzersizOl()
        {
            //CollectionAssert.AllItemsAreUnique(kullanıcılar);
        }
        [Test]
        public void TümElamanAynıTipte()
        {
            /*ArrayList liste = new ArrayList
            {
                "Pınar","Eda","Yusuf"
            };*/

            //CollectionAssert.AllItemsAreInstancesOfType(liste,typeof(string));
        }
        [Test]
        public void IsSubsetOf_test()
        {
            List<string> yeniKullanıcı = new List<string> {"Yusuf","Eda","pınar" };
            List<string> eskiKullanıcı = new List<string> {"lydia","bilie","selena" };

            /*CollectionAssert.IsSubsetOf(yeniKullanıcı,kullanıcılar);
            CollectionAssert.IsNotSubsetOf(eskiKullanıcı,kullanıcılar);*/
        }
        [Test]
        public void Contains_test()
        {
            /*CollectionAssert.Contains(kullanıcılar,"Yusuf");
            CollectionAssert.DoesNotContains(kullanıcılar,"Isabella");*/
        }
    }
}