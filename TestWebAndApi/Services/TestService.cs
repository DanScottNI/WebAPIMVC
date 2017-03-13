using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace TestWebAndApi.Services
{
    public class TestService : ITestService
    {
        public Collection<string> GetStrings()
        {
            return new Collection<string>()
            {
                "dan",
                "test"
            };
        }
    }
}