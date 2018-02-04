using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MC_Test
    {

        [TestMethod]
        public void MC_Pris()
        {
            MC bil = new MC();
            Assert.AreEqual(bil.Pris(), 125);
        }

        [TestMethod]
        public void MC_Køretøj()
        {
            MC køretøj = new MC();
            Assert.AreEqual(køretøj.køretøj(), "MC");
        }

        public void Brobizz_MC()
        {

            MC rabat = new MC();
            rabat.Brobizz = true;
            Assert.AreEqual(rabat.Pris(), 95);
        }

    }
}
