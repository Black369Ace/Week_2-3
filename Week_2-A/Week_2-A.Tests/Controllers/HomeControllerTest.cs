using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week_2_A;
using Week_2_A.Controllers;

namespace Week_2_A.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
