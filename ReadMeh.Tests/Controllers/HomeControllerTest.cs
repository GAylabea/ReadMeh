using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReadMeh;
using ReadMeh.Controllers;

namespace ReadMeh.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            WelcomeController controller = new WelcomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
