using AutoFixture;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Web_App.Controllers;

namespace Tests
{
    [TestClass]
    public class HomeControllerTests : BaseTest
    {
        [TestMethod]
        public void IndexTest()
        {
            //Arrange
            var logger = Fixture.Freeze<Mock<ILogger<HomeController>>>();

            var sut = new HomeController(logger.Object);

            //Act
            var result = sut.Index();

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<ViewResult>();
        }
    }
}
