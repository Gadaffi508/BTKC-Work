using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Tests
{
    [TestClass]
    public class StringHelper
    {
        [TestMethod]
        public void Girilen_Fazla_bosluklar_sonundaki_silinmelidir()
        {
            //Arrange
            var ifade = "Yusuf Arslan ";
            var Beklenen = "Yusuf Arslan ";
            //Act
            var gerceklesen = StringHelper.VerySpaceDeleted(ifade);
            //Assert
            Assert.AreEqual(Beklenen,gerceklesen);

		}
        [TestMethod]
		public void Girilen_Fazla_bosluklar_içindeki_silinmelidir()
		{
			//Arrange
			var ifade = "Yusuf  Arslan    sachbsj    cascb      ksac       a";
			var Beklenen = "Yusuf Arslan sachbsj cascb ksac a ";
			//Act
			var gerceklesen = StringHelper.VerySpaceDeleted(ifade);
			//Assert
			Assert.AreEqual(Beklenen, gerceklesen);

		}
	}
}
