using Microsoft.AspNetCore.Mvc;
using SlowDI.Authorization.Roles;
using SlowDI.Authorization.Users;
using SlowDI.Editions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlowDI.Tests
{
    public class TestWithoutDIAppService : ITestWithoutDIAppService
    {

        [HttpGet]
        public void Test()
        {

        }
    }
}
