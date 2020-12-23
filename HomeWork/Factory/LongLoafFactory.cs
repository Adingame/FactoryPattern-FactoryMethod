using HomeWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    public class LongLoafFactory : IBreadFactory
    {
        public IBread creteBread()
        {
            return new LongLoaf();
        }
    }
}
