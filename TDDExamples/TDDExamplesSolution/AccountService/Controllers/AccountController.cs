using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AccountService
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private IRepository _accountRepository;
        public AccountController(IRepository repository)
        {
            _accountRepository = repository;
        }
        
        [HttpPost]
        public IActionResult ValidateUser(string userName , string password)
        {
            if (!_accountRepository.CheckUser(userName))
                return NotFound("User does not exist");

            if (_accountRepository.ValidateUser(userName,password))
            {
                return Ok(new StatusResult(true));
            }

            return Unauthorized();
        }
 
    }
}
