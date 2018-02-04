using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class MCØresund_Test
    {
        [TestMethod]
        public void MCØresund_Pris()
        {
            MCØresund pris = new MCØresund();
          
            Assert.AreEqual(pris.Pris(),210);
        }

        [TestMethod]
        public void MCØresund_Brobizz()
        {
            MCØresund brobizz = new MCØresund();
            brobizz.Brobizz = true;

            Assert.AreEqual(brobizz.Pris(), 73);
        }

        [TestMethod]
        public void MCØresund_køretøj()
        {
            MCØresund køretøj = new MCØresund();

            Assert.AreEqual(køretøj.køretøj(), "Øresund MC");
        }

    }
}
