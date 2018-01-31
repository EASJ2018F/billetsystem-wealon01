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
        public void Bil_Køretøj()
        {
            Bil køretøj = new Bil();
            Assert.AreEqual(køretøj.køretøj(), "Bil");
        }
    }
}
