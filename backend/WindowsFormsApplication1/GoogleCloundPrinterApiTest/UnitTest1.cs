using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoogleCloudPrintServices.Support;

namespace GoogleCloundPrinterApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cloudPrint = new GoogleCloudPrint();
            cloudPrint.UserName = "mvbios@gmail.com";
            cloudPrint.Password = "@abc123!@";
            var printers = cloudPrint.Printers;
        }
    }
}
