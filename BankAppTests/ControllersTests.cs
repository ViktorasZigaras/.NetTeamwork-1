using AutoFixture;
using FluentAssertions;
using Homework.Domain.Interfaces;
using Homework.Domain.Models;
using Homework.Domain.Services;
using Homework.WebApp.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankAppTests
{
    public class ControllersTests
    {
        [Fact]
        public void AccountControllerIndexTest()
        {
            //Arrange
            var fixture = new Fixture();
            var accountService = new AccountService();
            var account1 = fixture.Build<Account>().Without(c => c.Id).Create();
            var account2 = fixture.Build<Account>().Without(c => c.Id).Create();
            var mockAccountRepository = new Mock<IAccountRepository>();
            mockAccountRepository.Setup(m => m.GetAll()).Returns(new List<Account>()
            {
                account1,
                account2
            });
            var accountController = new AccountController(mockAccountRepository.Object, accountService);
            //Act
            var result = accountController.Index();
            //Assert
            result.Should().BeAssignableTo<ViewResult>();
        }

        [Fact]
        public void AccountControllerTopupTest()
        {
            //Arrange
            var fixture = new Fixture();
            var accountService = new AccountService();
            var topupModel = fixture.Create<Topup>();
            var mockAccountRepository = new Mock<IAccountRepository>();
            mockAccountRepository.Setup(m => m.Topup(topupModel));
            var accountController = new AccountController(mockAccountRepository.Object, accountService);
            //Act
            var result = accountController.Topup(8);
            //Assert
            result.Should().BeAssignableTo<ViewResult>();
        }

        [Fact]
        public void AccountControllerTopupFormTest()
        {
            //Arrange
            var fixture = new Fixture();
            var accountService = new AccountService();
            var topupModel = fixture.Create<Topup>();
            //Mocking AccountRepository
            var mockAccountRepository = new Mock<IAccountRepository>();
            mockAccountRepository.Setup(m => m.Topup(topupModel));
            //Mocking TempData
            var httpContext = new DefaultHttpContext();
            var tempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());
            tempData["MsgChangeStatus"] = "You are successfully topup account";
            var accountController = new AccountController(mockAccountRepository.Object, accountService)
            {
                TempData = tempData
            };
            //Act
            var result = accountController.TopupForm(topupModel);
            //Assert
            result.Should().BeAssignableTo<RedirectToActionResult>();
        }
    }
}
