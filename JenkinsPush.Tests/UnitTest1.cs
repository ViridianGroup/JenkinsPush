using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JenkinsPush.Controllers;
using System.Web.Mvc;

namespace JenkinsPush.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FailingTestMethod() //
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Details", result.ViewName);
        }

        [TestMethod]
        public void PassingTestMethod() //
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }

    }
}
