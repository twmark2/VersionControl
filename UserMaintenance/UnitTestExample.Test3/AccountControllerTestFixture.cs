﻿using NUnit.Framework;
using System;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test3
{
    public class AccountControllerTestFixture
    {
        [Test,
     TestCase("abcd1234", false),
     TestCase("irf@uni-corvinus", false),
     TestCase("irf.uni-corvinus.hu", false),
     TestCase("irf@uni-corvinus.hu", true)]

        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountController = new AccountController();


            var actualResult = accountController.ValidateEmail(email);


            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expectedResult, actualResult);


        }



        [
    Test,
    TestCase("irf@uni-corvinus.hu", "Abcd1234"),
    TestCase("irf@uni-corvinus.hu", "Abcd1234567"),
]
        public void TestRegisterHappyPath(string email, string password)
        {
            
            var accountController = new AccountController();

            
            var actualResult = accountController.Register(email, password);

            
            Assert.AreEqual(email, actualResult.Email);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
        }


    }
}
