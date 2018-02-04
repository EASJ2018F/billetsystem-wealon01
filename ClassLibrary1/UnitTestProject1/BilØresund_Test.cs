using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BilØresund_Test
    {
        [TestMethod]
        public void BilØresund_Pris()
        {
            BilØresund pris = new BilØresund();

            Assert.AreEqual(pris.Pris(), 410);
        }

        [TestMethod]
        public void BilØresund_Brobizz()
        {
            BilØresund brobizz = new BilØresund();

            brobizz.Brobizz = true;

            Assert.AreEqual(brobizz.Pris(), 161);
        }

        [TestMethod]
        public void BilØresund_køretøj()
        {
            BilØresund køretøj = new BilØresund();

            Assert.AreEqual(køretøj.køretøj(), "Øresund Bil");
        }



    }
}
