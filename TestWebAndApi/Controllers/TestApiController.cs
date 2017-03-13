using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebAndApi.Services;

namespace TestWebAndApi.Controllers
{
    public class TestApiController : ApiController
    {
        private readonly ITestService testService;

        public TestApiController(ITestService testService)
        {
            this.testService = testService;
        }

        [HttpGet]
        public Collection<string> TestOutput()
        {
            return this.testService.GetStrings();
        }
    }
}
