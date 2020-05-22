using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Infra
{
    public class Repo : IRepo
    {
        public string Message()
        {
            return "Hi Lovely priyanka";
        }
    }
}