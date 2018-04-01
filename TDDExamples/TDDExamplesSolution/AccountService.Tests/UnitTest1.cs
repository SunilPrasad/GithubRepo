using AccountService;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using Xunit;

namespace AccountServiceUnitTests
{
    public class AccountServiceTests
    {
        private Mock<IRepository> _repositoryMock;
        public AccountServiceTests()
        {
            _repositoryMock = new Mock<IRepository>();
        }
        [Fact]
        public void ReturnNotFoundWhenUserDoesNotExist()
        {
            _repositoryMock.Setup(rep => rep.CheckUser("sunil")).Returns(false);

            var accountController = new AccountController(_repositoryMock.Object);

            var result = accountController.ValidateUser("sunil", "su9!L@@");

           // Assert.Equal(1, result.);
        }
    }
}
