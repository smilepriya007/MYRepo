using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI
{
    public class MyConcretClass:IMyInterface
    {
        
        public string Message()
        {
            return "Hello";
        }
    }
}