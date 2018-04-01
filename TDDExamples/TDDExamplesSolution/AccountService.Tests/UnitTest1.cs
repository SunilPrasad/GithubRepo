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
        public void ValidateUserShouldReturnNotFoundWhenUserDoesNotExist()
        {
            _repositoryMock.Setup(rep => rep.CheckUser("sunil")).Returns(false);

            var accountController = new AccountController(_repositoryMock.Object);

            var validationResult = accountController.ValidateUser("sunil", "su9!L@@");

            var result = Assert.IsType<OkObjectResult>(validationResult);
            
             Assert.True(((StatusResult)result.Value).Status);
        }
    }
}
