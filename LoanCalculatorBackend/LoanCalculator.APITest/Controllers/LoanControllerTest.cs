using LoanCalculator.Business.ViewModels.General;
using LoanCalculator.Domain.Models;
using LoanCalculator.Interfaces.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace LoanCalculator.API.Controllers.Tests
{
    [TestClass()]
    public class LoanControllerTest
    {
        private LoanController _controller;
        private Mock<ILoanHistoryService> _mockLoanHistoryService;

        public LoanControllerTest()
        {
            _mockLoanHistoryService = new Mock<ILoanHistoryService>();
            _controller = new LoanController(_mockLoanHistoryService.Object);
            _mockLoanHistoryService.Setup(x => x.AddAsync(It.IsAny<LoanHistory>())).ReturnsAsync(true);
        }

        [TestMethod()]
        public void CalculateLvrSuccessTest()
        {
            double propertyValue = 1000000;
            double amount = 900000;
            double result = 90;
            var response = _controller.CalculateLvr(propertyValue, amount).Result as ResponseDetail<double>;

            Assert.AreEqual(response.Data, result);
        }

        [TestMethod()]
        public void CalculateLvrFailTest()
        {
            double propertyValue = 2000000;
            double amount = 900000;
            double result = 90;
            var response = _controller.CalculateLvr(propertyValue, amount).Result as ResponseDetail<double>;

            Assert.AreNotEqual(response.Data, result);
        }
    }
}