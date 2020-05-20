using Microsoft.AspNetCore.Mvc;
using SlowDI.Authorization.Roles;
using SlowDI.Authorization.Users;
using SlowDI.Editions;
using SlowDI.SlowDis;
using System;
using System.Collections.Generic;
using System.Text;

namespace SlowDI.Tests
{
    public class TestAppService : ITestAppService
    {
        private readonly EditionManager _editionManager;

        public TestAppService(EditionManager pEditionManager, RoleManager pRoleManager, 
            UserManager pUserManager)
        {
            _editionManager = pEditionManager;
        }

        [HttpGet]
        public void Test([FromServices]ISlowDiRepository pSlowDiRepository)
        {

        }
    }
}
