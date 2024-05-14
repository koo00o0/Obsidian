using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;
using MvcApplication1.Controllers;

namespace test.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // 정렬
            HomeController controller = new HomeController();

            // 동작
            ViewResult result = controller.Index() as ViewResult;

            // 어설션
            ViewDataDictionary viewData = result.ViewData;
            Assert.AreEqual("ASP.NET MVC 시작", viewData["Message"]);
        }

        [TestMethod]
        public void About()
        {
            // 정렬
            HomeController controller = new HomeController();

            // 동작
            ViewResult result = controller.About() as ViewResult;

            // 어설션
            Assert.IsNotNull(result);
        }
    }
}
