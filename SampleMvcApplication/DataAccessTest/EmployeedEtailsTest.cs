using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleMvcApplication.Controllers;
using System.Web;
using System.IO;
using DataAccess.Utility;

namespace DataAccessTest
{
    [TestClass]
    public class EmployeedEtailsTest
    {
        [TestMethod]
        public void TestMethod1()
        {

         EmployeeDetailsController empController = new EmployeeDetailsController();

         XmlHelper xmlHelper = new XmlHelper();
         string xmlString = xmlHelper.GetXml();

         Assert.IsTrue(empController.GetDetailsByXmlString(xmlString, 1).Count == 1);

            
        }


        [TestMethod]
        public void TestMethod2()
        {

            EmployeeDetailsController empController = new EmployeeDetailsController();

            XmlHelper xmlHelper = new XmlHelper();
            string xmlString = xmlHelper.GetXml();

            Assert.IsFalse(empController.GetDetailsByXmlString(xmlString, 14).Count == 1);


        }
    }
}
