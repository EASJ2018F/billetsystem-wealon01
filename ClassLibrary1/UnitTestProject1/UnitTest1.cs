using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Bil_Pris()
        {
            Bil bil= new Bil();
            Assert.AreEqual(bil.Pris(),240);
        }

        [TestMethod]
        public void MC_Køretøj()
        {
            Bil køretøj = new Bil();
            Assert.AreEqual(køretøj.køretøj(), "Bil");
        }

        [TestMethod]
        public void MC_Pris()
        {
            MC bil = new MC();
            Assert.AreEqual(bil.Pris(), 125);
        }

        [TestMethod]
        public void Bil_Køretøj()
        {
            MC køretøj = new MC();
            Assert.AreEqual(køretøj.køretøj(), "MC");
        }
    }
}
