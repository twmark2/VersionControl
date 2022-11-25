using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test3
{
    public class AccountControllerTestFixture
    {
        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountController = new AccountController();

           
            var actualResult = accountController.ValidateEmail(email);

            
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
