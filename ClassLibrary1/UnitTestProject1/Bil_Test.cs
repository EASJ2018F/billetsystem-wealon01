using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Bil_Test
    {
        [TestMethod]
        public void Bil_Pris()
        {
            Bil bil = new Bil();
            Assert.AreEqual(bil.Pris(), 240);
        }

        [TestMethod]
        public void Bil_Køretøj()
        {
            Bil køretøj = new Bil();
            Assert.AreEqual(køretøj.køretøj(), "Bil");
        }

        [TestMethod]
        public void nummberplade_max7tegn()
        {
            Bil tegn = new Bil();
            tegn.Nummerplade = "ABCDEFG";
            Assert.AreEqual("ABCDEFG",tegn.Nummerplade);
        }

        [TestMethod]
        public void Brobizz_bil()
        {

            Bil rabat = new Bil();
            rabat.Brobizz = true;
            Assert.AreEqual(rabat.Pris(), 190);
        }

        public void WeekendRabat()
        {
            Bil bil = new Bil();
            bil.Brobizz = false;
            bil.Dato = new DateTime(2018, 02, 04);
            Assert.AreEqual(160, bil.Pris());
        }


    }
}
